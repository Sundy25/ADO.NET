using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalisanKargoDataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCon"].ConnectionString);
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);
            this.Text = ConfigurationManager.AppSettings["username"] + " " + ConfigurationManager.AppSettings["mail"];
        }

        private void btnDataSet_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select ShipperID,CompanyName,Phone from Shippers", connection);
            DataSet ds = new DataSet("Shippers");
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnDataTable_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Employees", connection);

            DataTable dt = new DataTable("Employees");
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataTable dataTable = new DataTable("Employees");
            //dataTable = (DataTable)dataGridView1.DataSource;            
            //this.Text = dataTable.Rows[e.RowIndex]["FirstName"].ToString();

            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            DialogResult cevap = MessageBox.Show($"{id}'li kayıdı silmek istiyor musunuz?","Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                productsTableAdapter.DeleteQuery(id);
                this.productsTableAdapter.Fill(this.northwindDataSet.Products);
            }
        }
    }
}
