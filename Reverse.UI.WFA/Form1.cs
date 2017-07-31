using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reverse.BLL.Repository;
using static Reverse.BLL.Repository.Repository;

namespace Reverse.UI.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = $"{new ProductRepo().GetAll().Count} adet Ürün var";
        }
    }
}
