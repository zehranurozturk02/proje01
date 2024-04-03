using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(comboBox1.Text== "mavi")
            {
                label4.Text = textBox1.Text + " isimli kişi mavi rengini seçti";
            }else if (comboBox1.Text == "sarı")
            {
                label4.Text = textBox1.Text + " isimli kişi sarı rengini seçti" ;
            }else if (comboBox1.Text == "kırmızı")
            {
                label4.Text = textBox1.Text + " isimli kişi kırmızı rengini seçti";
            }
            else
            {
                MessageBox.Show("listedeki rengi seçmediniz");
            }
            }
        }
    }

