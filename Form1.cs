using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ısım;
        string soyısım;

       

        private void button1_Click(object sender, EventArgs e)
        {
         
            ısım = Convert.ToString(textBox1.Text);
            soyısım = Convert.ToString(textBox2.Text);


            if (textBox1.Text == "EMRE")
            {
                if (textBox2.Text == "SEFEROGLU")
                {
                    MessageBox.Show("SİNEMAMIZA HOŞGELDİNİZ", "BİLGİLENDİRME", MessageBoxButtons.OK);
                    filmler film2 = new filmler();
                    film2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("LÜTFEN BOŞ ALAN BIRAKMAYINIZ");
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN BOŞ ALAN BIRAKMAYINIZ");
            }
        }
    }
}
