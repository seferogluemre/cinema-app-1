using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp123
{
    public partial class büfe : Form
    {
        public büfe()
        {
            InitializeComponent();
        }
        int genel_toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int mısır, pizza, hamburger, çikolata, ıtea, su, fanta, bılet, toplam;

                mısır = Convert.ToInt32(textBox1.Text);
                pizza = Convert.ToInt32(textBox2.Text);
                hamburger = Convert.ToInt32(textBox3.Text);
                çikolata = Convert.ToInt32(textBox4.Text);
                ıtea = Convert.ToInt32(textBox5.Text);
                su = Convert.ToInt32(textBox6.Text);
                fanta = Convert.ToInt32(textBox7.Text);
                bılet = Convert.ToInt32(textBox8.Text);

                toplam = (mısır * 15) + (pizza * 20) + (hamburger * 12) + (çikolata * 7) + (ıtea * 5) + (su * 2) + (fanta * 7) + (bılet * 15);
                MessageBox.Show("TOPLAM TUTARINIZ :" + toplam, "AFİYET OLSUN(:");
                label18.Text = toplam + " TL";


                genel_toplam = genel_toplam + toplam;
                label19.Text = genel_toplam + " TL";


            }
            catch (Exception)
            {
                MessageBox.Show("KUTULARI 0-YADA 1-DEN FAZLA DOLDURUNUZ BOŞ BIRAKMAYINIZ");
                
            }
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BÜTÜNF filmlerr1 = new BÜTÜNF(); ;
            filmlerr1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            filmler filmlerr3 = new filmler();
            filmlerr3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            filmler Bfefilm = new filmler();
            Bfefilm.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ALANLARI DOLDURUNUZ");
            groupBox5.Visible = true;
            groupBox4.Visible = true;
            pictureBox1.Visible = true;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
        

           


        }

        private void label20_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            labelısım.Text = textBox9.Text;
        }

        private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            labelKartNo.Text = maskedTextBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSkt.Text = comboBox1.Text + "/" + comboBox2.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSkt.Text = comboBox1.Text + "/" + comboBox2.Text;
        }

        private void maskedTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            labelCvv.Text = maskedTextBox2.Text;
        }

        private void büfe_Load(object sender, EventArgs e)
        {
            int ay;
            int yil;
            for (ay = 1; ay < 13; ay++)
            {
                comboBox1.Items.Add(ay);
            }
            for (yil = 21; yil < 30; yil++)
            {
                comboBox2.Items.Add(yil);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                int mısır, pizza, hamburger, çikolata, ıtea, su, fanta, bılet, toplam;

                mısır = Convert.ToInt32(textBox1.Text);
                pizza = Convert.ToInt32(textBox2.Text);
                hamburger = Convert.ToInt32(textBox3.Text);
                çikolata = Convert.ToInt32(textBox4.Text);
                ıtea = Convert.ToInt32(textBox5.Text);
                su = Convert.ToInt32(textBox6.Text);
                fanta = Convert.ToInt32(textBox7.Text);
                bılet = Convert.ToInt32(textBox8.Text);

                toplam = (mısır * 15) + (pizza * 20) + (hamburger * 12) + (çikolata * 7) + (ıtea * 5) + (su * 2) + (fanta * 7) + (bılet * 15);
                MessageBox.Show("TOPLAM TUTARINIZ :" + toplam, "AFİYET OLSUN(: \n TEKRAR BEKLERİZ");
                label18.Text = toplam + " TL";


                genel_toplam = genel_toplam + toplam;
                label19.Text = genel_toplam + " TL";


            }
            catch (Exception)
            {
                MessageBox.Show("KUTULARI 0-YADA 1-DEN FAZLA DOLDURUNUZ BOŞ BIRAKMAYINIZ");

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            groupBox4.Visible = false;
            pictureBox1.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
            maskedTextBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            maskedTextBox2.Text = "";

            labelısım.Text = "";
            labelKartNo.Text = "";
            labelSkt.Text = "";
            labelCvv.Text = "";


        }
    }
}
