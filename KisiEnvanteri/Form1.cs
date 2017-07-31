using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KisiEnvanteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Kisi> kisiler = new List<Kisi>();
        Kisi seciliKisi;
        private const string myCon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Kisi yeniKisi = new Kisi() //Object initializer
                {
                    Ad = txtAd.Text,
                    Boy = int.Parse(txtBoy.Text),
                    Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                    DogumTarihi = dtpDogumTarihi.Value,
                    Kilo = int.Parse(txtKilo.Text),
                    MedeniDurum = (MedeniDurumlar)Enum.Parse(typeof(MedeniDurumlar), cmbMedeniDurum.SelectedItem.ToString()),
                    Meslek = txtMeslek.Text,
                    Soyad = txtSoyad.Text,
                    TCKN = txtTCKN.Text
                };
                if (memoryStream.Length > 0)
                {
                    yeniKisi.Fotograf = memoryStream.ToArray();
                }
                memoryStream = new MemoryStream();
                kisiler.Add(yeniKisi);
                DbEkle(yeniKisi);
                ListeyiDoldur();
                FormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void DbEkle(Kisi kisi)
        {
            SqlConnection con = new SqlConnection(myCon);
            try
            {

                SqlCommand command = new SqlCommand("insert into Kisiler(Id,Ad,Soyad,Boy,Kilo,DogumTarihi,Cinsiyet,MedeniDurum,Meslek,Fotograf,TCKN)values(@id,@ad,@soyad,@boy,@kilo,@dogumtarihi,@cinsiyet,@medenidurum,@meslek,@fotograf,@tckn)", con);
                command.Parameters.AddWithValue("@id", kisi.Id);
                command.Parameters.AddWithValue("@ad", kisi.Ad);
                command.Parameters.AddWithValue("@soyad", kisi.Soyad);
                command.Parameters.AddWithValue("@boy", kisi.Boy);
                command.Parameters.AddWithValue("@kilo", kisi.Kilo);
                command.Parameters.AddWithValue("@dogumtarihi", kisi.DogumTarihi);
                command.Parameters.AddWithValue("@cinsiyet", (int)kisi.Cinsiyet);
                command.Parameters.AddWithValue("@medenidurum", (int)kisi.MedeniDurum);
                command.Parameters.AddWithValue("@meslek", kisi.Meslek);
                command.Parameters.AddWithValue("@fotograf", kisi.Fotograf);
                command.Parameters.AddWithValue("@tckn", kisi.TCKN);
                con.Open();
                int row = command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("DB Ekleme işlemi Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void DbVeriCek()
        {
            try
            {
                SqlConnection con = new SqlConnection(myCon);

                SqlCommand cmd = new SqlCommand("select * from Kisiler", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                kisiler = new List<Kisi>();
                while (reader.Read())
                {
                    Kisi gelenKisi = new Kisi()
                    {
                        Ad = reader["Ad"].ToString(),
                        Soyad = reader["Soyad"].ToString(),
                        Boy = Convert.ToInt32(reader["Boy"]),
                        Kilo = Convert.ToInt32(reader["Kilo"]),
                        Cinsiyet = (Cinsiyetler)(Convert.ToInt32(reader["Cinsiyet"])),
                        MedeniDurum = (MedeniDurumlar)(Convert.ToInt32(reader["MedeniDurum"])),
                        DogumTarihi = Convert.ToDateTime(reader["DogumTarihi"]),
                        Id = Guid.Parse(reader["Id"].ToString()),
                        Meslek = reader["Meslek"].ToString(),
                        Fotograf = (byte[])reader["Fotograf"],
                        TCKN = reader["TCKN"].ToString()
                    };
                    kisiler.Add(gelenKisi);
                }
                con.Close();
                ListeyiDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void DbGuncelle(Kisi kisi)
        {
            SqlConnection con = new SqlConnection(myCon);
            try
            {
                SqlCommand command = new SqlCommand("update Kisiler set Ad=@ad, Soyad=@soyad,Boy=@boy,Kilo=@kilo,DogumTarihi=@dogumtarihi,Cinsiyet=@cinsiyet,MedeniDurum=@medenidurum,Meslek=@meslek,Fotograf=@fotograf where Id=@id", con);
                command.Parameters.AddWithValue("@id", kisi.Id);
                command.Parameters.AddWithValue("@ad", kisi.Ad);
                command.Parameters.AddWithValue("@soyad", kisi.Soyad);
                command.Parameters.AddWithValue("@boy", kisi.Boy);
                command.Parameters.AddWithValue("@kilo", kisi.Kilo);
                command.Parameters.AddWithValue("@dogumtarihi", kisi.DogumTarihi);
                command.Parameters.AddWithValue("@cinsiyet", (int)kisi.Cinsiyet);
                command.Parameters.AddWithValue("@medenidurum", (int)kisi.MedeniDurum);
                command.Parameters.AddWithValue("@meslek", kisi.Meslek);
                if (kisi.Fotograf != null)
                    command.Parameters.AddWithValue("@fotograf", kisi.Fotograf);
                else
                {
                    Image image = Properties.Resources.noprofile;
                    MemoryStream stream = new MemoryStream();
                    image.Save(stream, ImageFormat.Png);
                    byte[] nofoto = stream.ToArray();
                    command.Parameters.AddWithValue("@fotograf", nofoto);
                }
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                FormuTemizle();
                DbVeriCek();
                MessageBox.Show("Güncelleme işlemi başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void DbSil(Kisi kisi)
        {
            SqlConnection con = new SqlConnection(myCon);
            try
            {
                SqlCommand command = new SqlCommand("delete from kisiler where Id=@id", con);
                command.Parameters.AddWithValue("@id", kisi.Id);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                DbVeriCek();
                MessageBox.Show($"{kisi} kaydı silinmiştir.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbMedeniDurum.Items.AddRange(Enum.GetNames(typeof(MedeniDurumlar)));
            DbVeriCek();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliKisi == null)
            {
                MessageBox.Show("Neyi güncelleyeyim?");
                return;
            }
            DialogResult cevap = MessageBox.Show($"{seciliKisi.Ad} adlı kişiyi güncellemek istiyor musunuz?", "Kişi güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    seciliKisi = kisiler.Where(item => item.TCKN == seciliKisi.TCKN).FirstOrDefault();
                    seciliKisi.Ad = txtAd.Text;
                    seciliKisi.Soyad = txtSoyad.Text;
                    seciliKisi.DogumTarihi = dtpDogumTarihi.Value;
                    seciliKisi.Meslek = txtMeslek.Text;
                    seciliKisi.Boy = int.Parse(txtBoy.Text);
                    seciliKisi.Kilo = int.Parse(txtKilo.Text);
                    seciliKisi.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
                    seciliKisi.MedeniDurum = (MedeniDurumlar)Enum.Parse(typeof(MedeniDurumlar), cmbMedeniDurum.SelectedItem.ToString());
                    seciliKisi.TCKN = txtTCKN.Text;
                    if (memoryStream.Length != 0)
                        seciliKisi.Fotograf = memoryStream.ToArray();
                    else
                        seciliKisi.Fotograf = null;
                    DbGuncelle(seciliKisi);
                    ListeyiDoldur();
                    FormuTemizle();
                    seciliKisi = null;
                    MessageBox.Show("Güncelleme Başarılı");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kisiler.Count == 0)
            {
                MessageBox.Show("Zaten kimse kayıtlı değil neyi dışarı aktaracaksın?");
                return;
            }
            dosyaKaydet.Title = $"{kisiler.Count} adet kişi dışarı aktarılacak";
            dosyaKaydet.Filter = "XML Format | *.xml";
            dosyaKaydet.FileName = string.Empty;
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kisi>));
                TextWriter writer = new StreamWriter(dosyaKaydet.FileName);
                xmlSerializer.Serialize(writer, kisiler);
                writer.Close();
                writer.Dispose();
                MessageBox.Show("Kişiler Dışarıya aktarıldı");
            }
        }
        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir Kisi XML dosyasını seçiniz";
            dosyaAc.Filter = "XML Format | *.xml";
            dosyaAc.Multiselect = false;
            dosyaAc.FileName = string.Empty;
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kisi>));
                TextReader reader = new StreamReader(dosyaAc.FileName);
                // kisiler = xmlSerializer.Deserialize(reader) as List<Kisi>;
                kisiler = (List<Kisi>)xmlSerializer.Deserialize(reader);
                ListeyiDoldur();
                reader.Close();
                reader.Dispose();
                MessageBox.Show($"{kisiler.Count} adet kişi programa aktarıldı");
            }
        }
        MemoryStream memoryStream = new MemoryStream();
        int bufferSize = 64;
        byte[] resimArray = new byte[64];
        private void pbResim_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir fotoğraf dosyasını seçiniz";
            dosyaAc.Filter = "JPG | *.jpg";
            dosyaAc.Multiselect = false;
            dosyaAc.FileName = string.Empty;
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.Open(dosyaAc.FileName, FileMode.Open);
                while (dosya.Read(resimArray, 0, bufferSize) != 0)
                {
                    memoryStream.Write(resimArray, 0, resimArray.Length);
                }
                dosya.Close();
                dosya.Dispose();
                pbResim.Image = new Bitmap(memoryStream);
            }
        }
        void FormuTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = 0;
                else if (item is DateTimePicker)
                    (item as DateTimePicker).Value = DateTime.Now;
                else if (item is PictureBox)
                    (item as PictureBox).Image = null;
            }
        }
        void ListeyiDoldur()
        {
            lstKisi.Items.Clear();
            foreach (Kisi item in kisiler)
            {
                lstKisi.Items.Add(item);
            }
        }
        void ListeyiDoldur(List<Kisi> aramasonucu)
        {
            lstKisi.Items.Clear();
            foreach (Kisi item in aramasonucu)
            {
                lstKisi.Items.Add(item);
            }
        }
        private void lstKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisi.SelectedIndex == -1) return;
            seciliKisi = lstKisi.SelectedItem as Kisi;
            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            txtBoy.Text = seciliKisi.Boy.ToString();
            txtKilo.Text = seciliKisi.Kilo.ToString();
            txtMeslek.Text = seciliKisi.Meslek;
            txtTCKN.Text = seciliKisi.TCKN;
            cmbCinsiyet.SelectedIndex = (int)seciliKisi.Cinsiyet;
            cmbMedeniDurum.SelectedIndex = (int)seciliKisi.MedeniDurum;
            dtpDogumTarihi.Value = seciliKisi.DogumTarihi;
            if (seciliKisi.Fotograf != null && seciliKisi.Fotograf.Length > 0)
                pbResim.Image = new Bitmap(new MemoryStream(seciliKisi.Fotograf));
            else
                pbResim.Image = null;
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstKisi.SelectedItem == null)
            {
                MessageBox.Show("Neyi sileyim?");
                return;
            }
            seciliKisi = lstKisi.SelectedItem as Kisi;

            DialogResult cevap = MessageBox.Show($"{seciliKisi.Ad} adlı kişiyi silmek istiyor musunuz?", "Kişi silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                kisiler.Remove(seciliKisi);
                DbSil(seciliKisi);
                ListeyiDoldur();
                FormuTemizle();
                seciliKisi = null;
                MessageBox.Show("Kişi silindi");
            }
        }
    }
}
