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
    public partial class ChequeEmpty : Form
    {
        public ChequeEmpty()
        {
            InitializeComponent();
        }

        private void ChequeEmpty_Load(object sender, EventArgs e)
        {
            label1.Text = $"Ошибка! Корзина пуста.";
            button1.Text = "OK";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChequeEmpty_Click(object sender, EventArgs e)
        {

        }
    }
}
