using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class ProductIsNotSelected : Form
    {
        public ProductIsNotSelected()
        {
            InitializeComponent();
        }

        private void ProductIsNotSelected_Load(object sender, EventArgs e)
        {
            label1.Text = "Ошибка! Товар не выбран.";
            button1.Text = "Ok";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
