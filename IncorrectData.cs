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
    public partial class IncorrectData : Form
    {
        public IncorrectData()
        {
            InitializeComponent();
        }

        private void IncorrectData_Load(object sender, EventArgs e)
        {
            label1.Text = $"Ошибка! Введены некорректные данные.";
            button1.Text = "OK";
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
