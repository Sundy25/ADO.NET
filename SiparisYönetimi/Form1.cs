using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisYönetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string myCOn = "Data Source=DESKTOP-SR4J92V;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection con = new SqlConnection(myCOn);

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select EmployeeID,Firstname+' '+LastName as isim from Employees", con);
            try
            {
                if (con.State == ConnectionState.Closed) // bağlantı kapalıysa 
                {
                    con.Open(); // aç
                    //SqlDataReader dr = command.ExecuteReader();
                    //while (dr.Read())
                    //{
                    //    cmbPersoneller.Items.Add(dr["isim"].ToString());
                    //}
                    // biz üstte adım adım seçip yüklüyorduk. BUnun da kısası var.
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    // bu dataTable nin içine data adapteri atacağız.
                    dataAdapter.Fill(dataTable); // adaptörümüzü doldurduk.
                    cmbPersoneller.DataSource = dataTable; // bunu verilir göstermek için bir şey yazıyorduk data source da Ne idi hatırlayalım. 
                    // bu şekilde çalıştırınca dataların class ını gösteriyor cmbox içinde.
                    // bir şey yapmalı bak. 
                    cmbPersoneller.DisplayMember = "isim"; // bu hangi verinin gösterileceğini.
                    // bu da getselectedvalue u yu verecek.
                    cmbPersoneller.ValueMember = "EmployeeID";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); } // connection u kapat. 
        }

        private void btnSiparisleriGetir_Click(object sender, EventArgs e)
        {
            string id = cmbPersoneller.SelectedValue.ToString();
            //MessageBox.Show(id); // bir bakalım id lerimiz doğru geliyor mu? 
            // geliyor. Şİmdi bu id ile yeni sorgular yazabiliriz.
            SqlCommand command = new SqlCommand("SELECT e.FirstName+' '+e.LastName isim, o.OrderID,  o.OrderDAte, o.ShippedDate, o.Freight from dbo.Employees e INNER JOIN dbo.Orders o ON e.EmployeeID = o.EmployeeID where e.EmployeeID=@id", con);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                lstSiparisler.DataSource = table;
                lstSiparisler.DisplayMember = "OrderID";
                lstSiparisler.ValueMember = "OrderID";
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void btnSiparisDetayGetir_Click(object sender, EventArgs e)
        {
            string orderid = lstSiparisler.SelectedValue.ToString();

            SqlCommand command = new SqlCommand("Select OrderID,OrderDate,ShippedDate,Freight from Orders where OrderID=@id", con);
            command.Parameters.AddWithValue("@id", orderid);
            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) 
                {
                    lblKargoUcreti.Text = $"Kargo Ücreti: {dr["Freight"]:c2}";
                    lblSiparisTarihi.Text = $"Sipariş Tarihi : {dr["OrderDate"]:dd.MMM.yy}";
                    lblTeslimTarihi.Text = dr["ShippedDate"]!=null? $"Teslim Tarihi: {dr["ShippedDate"]:dd.MMM.yy}" : "Teslim Edilmedi"; 
                    // bak üstte kısa if içine soktuk, return ü de teslim edilmedi oldu. 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }
    }
}
