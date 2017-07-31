using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arabalarim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Yukle()
        {

            MyContext db = new MyContext();
            cmbMarkaListesi.DisplayMember = "MarkaAdi";
            cmbMarkalar.DisplayMember = "MarkaAdi";

            var markalar = db.Markalar.ToList();

            cmbMarkalar.DataSource = markalar;
            cmbMarkaListesi.DataSource = markalar;
            
        }

        void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = -1; // neden -1, ilk eklemeni yaptığında bilgisayar buraya girdiğin değere bakıyor. Eğer 0 koyarsan ilk değeri seçmeye çalışıyor. Olmadığı içinde hata veriyor. -1 ise zaten olmayan değer demek olduğu için hata kalkıyor. 
                }
            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();


            try
            {
                db.Markalar.Add(new Marka()
                {
                    MarkaAdi = txtMarkaAdi.Text,
                    Kurucusu = txtKurucusu.Text,
                    KurulusYili = int.Parse(txtKurulusYili.Text),
                });
                db.SaveChanges();
                Temizle();
                Yukle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbMarkaListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var marka = cmbMarkaListesi.SelectedItem as Marka;

            if (marka !=null)
            {
                int seciliMarkaID = marka.MarkaID;
                txtMarkaAdi.Text = marka.MarkaAdi;
                txtKurucusu.Text = marka.Kurucusu;
                txtKurulusYili.Text = marka.KurulusYili.ToString();

                var modeller = new MyContext().Markalar.Find(marka.MarkaID).Modeller;
                lstModelListesi.DisplayMember = "ModelAdi";
                lstModelListesi.DataSource = modeller;
            }
        }

        private void btnModelEkle_Click(object sender, EventArgs e)
        {
            var marka = cmbMarkaListesi.SelectedItem as Marka;
            if (marka != null)
            {
                try
                {
                    MyContext db = new MyContext();
                    db.Modeller.Add(new Model()
                    {
                        ModelAdi = txtModelAdi.Text,
                        MotorHacmi = double.Parse(txtMotorHacmi.Text.Replace(".",",")), // bunu neden böyle yapmıştık. Ekleyince para hesabında noktayı double a çevirmiyor. 1.6 yı 16 diye okuyor sonra alt tarafta 16.0 yazıyor. Sıkkıntı kardeş.
                        Yil = int.Parse(txtModelYili.Text),
                        MarkaID = marka.MarkaID // bunu sakın unutma.
                    });
                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Temizle();
                    Yukle();

                }

                
            }
        }

        private void lstModelListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var model = lstModelListesi.SelectedItem as Model;
            if (model != null)
            {
                txtModelAdi.Text = model.ModelAdi;
                txtModelYili.Text = model.Yil.ToString();
                txtMotorHacmi.Text = model.MotorHacmi.ToString("0.00");
                cmbMarkalar.SelectedItem = model.Marka;

            }
        }

        private void btnModelGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var seciliModel = lstModelListesi.SelectedItem as Model;
                MyContext db = new MyContext();
                seciliModel = db.Modeller.Find(seciliModel.ModelID);
                seciliModel.ModelAdi = txtModelAdi.Text;
                seciliModel.Yil = int.Parse(txtModelYili.Text);
                seciliModel.MotorHacmi = double.Parse(txtMotorHacmi.Text.Replace(".",","));
                seciliModel.MarkaID = (cmbMarkalar.SelectedItem as Marka).MarkaID;
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Temizle();
                Yukle();
            }
        }

        private void btnModelSil_Click(object sender, EventArgs e)
        {
            try
            {
                var seciliModel = lstModelListesi.SelectedItem as Marka;
                MyContext db = new MyContext();
                db.Markalar.Remove(db.Markalar.Find(seciliModel.MarkaID));
                db.SaveChanges();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Temizle();
                Yukle();
            }
        }

        private void btnMarkaSil_Click(object sender, EventArgs e)
        {
            try
            {
                var seciliMarka = cmbMarkaListesi.SelectedItem as Marka;
                MyContext db = new MyContext();
                db.Markalar.Remove(db.Markalar.Find(seciliMarka.MarkaID));
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally
            {
                Temizle();
                Yukle();
            }
        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var seciliMarka = cmbMarkaListesi.SelectedItem as Marka;
                MyContext db = new MyContext();
                seciliMarka = db.Markalar.Find(seciliMarka.MarkaID);
                seciliMarka.Kurucusu = txtKurucusu.Text;
                seciliMarka.KurulusYili = int.Parse(txtKurulusYili.Text);
                seciliMarka.MarkaAdi = txtMarkaAdi.Text;
                db.SaveChanges();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Temizle();
                Yukle();
            }
        }

        private void btnDataGetir_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            dataGridView1.DataSource = db.Markalar.ToList();

            var sorgu1 = db.Markalar.Select(x => new
            {
                Markasi = x.MarkaAdi,
                Modeli = x.Modeller,
                KurulusYili=x.KurulusYili,
                Kurucu=x.Kurucusu


            }).Take(100);

            dataGridView1.DataSource = sorgu1.ToList();
        }
    }
}
