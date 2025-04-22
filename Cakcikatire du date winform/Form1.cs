using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cakcikatire_du_date_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DateTime data1 = DTP1.Value;
            DateTime data2 = DTP2.Value;
            TimeSpan data3 = data2 - data1;
            label1.Text = data3.Days.ToString() + " giorni";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime data1 = DTP3.Value;
            string data2 = textBox1.Text.ToString();
            if (int.TryParse(data2, out int data3))
            {
                DateTime data4 = data1.AddDays(data3);
                label3.Text = data4.ToString("dd/MM/yyyy");
            }
            else
            {
                label3.Text = "Giorno non valido";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime data1 = DTP3.Value;
            string data2 = textBox1.Text.ToString();
            if (int.TryParse(data2, out int data3))
            {               
                DateTime data4 = data1.AddDays(-data3);
                label3.Text = data4.ToString("dd/MM/yyyy");
            }
            else
            {
                label3.Text = "Giorno non valido";
            }
        }
    }
}
