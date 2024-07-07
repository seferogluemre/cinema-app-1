using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp123
{
    public partial class kartOde : Form
    {
        public kartOde()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            long kartNo = 482755550053;
            string sahıbınınAdı = "EMRESEFEROGLU";
            int skt = 2204;
            int cvv = 597;

            kartNo = Convert.ToInt64(textBox9.Text);
            sahıbınınAdı = Convert.ToString(textBox10.Text);
            skt = Convert.ToInt32(textBox2.Text);
            cvv = Convert.ToInt32(textBox1.Text);

            string[] sembol1 = { "A", "B", "C", "D", "E", "F", "G" };
            string[] sembol2 = { "+", "-", "*", "/", "½", "#"};

            Random r1 = new Random();
            int s1, s2, s3;
            s1 = r1.Next(0, sembol1.Length);
            s2 = r1.Next(0, sembol2.Length);
            s3 = r1.Next(0, 10);

            label25.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s3.ToString();

            if (textBox9.Text == "")
            {
                MessageBox.Show("LÜTFEN BOŞ ALAN BIRAKMAYINIZ");

            }
            if (textBox10.Text == "")
            {
                MessageBox.Show("LÜTFEN BOŞ ALAN BIRAKMAYINIZ");
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("LÜTFEN BOŞ ALAN BIRAKMAYINIZ");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("LÜTFEN BOŞ ALAN BIRAKMAYINIZ");
            }
            else
            {
                MessageBox.Show("ALANI DOLDURUNUZ");
                label24.Visible = true;
                label25.Visible = true;

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }
    }
}
