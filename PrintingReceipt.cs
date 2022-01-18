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
    public partial class PrintingReceipt : Form
    {
        public PrintingReceipt()
        {
            InitializeComponent();
        }

        private void PrintingReceipt_Load(object sender, EventArgs e)
        {
            label1.Text = $"Напечатан чек на сумму {Basket.FullPrice} рублей!";
            button.Text = "OK";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
