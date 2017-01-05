using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrtalamaHesaplamav2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double turk, cog, tarih, biyolo, kimya, fizik, mate, yabanc, ikinc, din, gm, beden, saglik, sec1, sec2, sec3, sec4;
        double a, b, c, d;
        double sonuc1, sonuc2;

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            d = Convert.ToDouble(textBox4.Text);
            turk = a + b + c + d;
            turk = turk / 4;
            turk *= 5;
            // ==============================
            a = Convert.ToDouble(textBox9.Text);
            b = Convert.ToDouble(textBox10.Text);
            c = Convert.ToDouble(textBox11.Text);
            d = Convert.ToDouble(textBox12.Text);
            cog = a + b + c + d;
            cog = cog / 4;
            cog *= 2;
            // ==============================
            a = Convert.ToDouble(textBox45.Text);
            b = Convert.ToDouble(textBox46.Text);
            c = Convert.ToDouble(textBox47.Text);
            d = Convert.ToDouble(textBox48.Text);
            tarih = a + b + c + d;
            tarih = tarih / 4;
            tarih *= 2;
            // ==============================
            a = Convert.ToDouble(textBox5.Text);
            b = Convert.ToDouble(textBox6.Text);
            c = Convert.ToDouble(textBox7.Text);
            d = Convert.ToDouble(textBox8.Text);
            biyolo = a + b + c + d;
            biyolo = biyolo / 4;
            biyolo *= 3;
            // ==============================
            a = Convert.ToDouble(textBox13.Text);
            b = Convert.ToDouble(textBox14.Text);
            c = Convert.ToDouble(textBox15.Text);
            d = Convert.ToDouble(textBox16.Text);
            kimya = a + b + c + d;
            kimya = kimya / 4;
            kimya *= 2;
            // ==============================
            a = Convert.ToDouble(textBox17.Text);
            b = Convert.ToDouble(textBox18.Text);
            c = Convert.ToDouble(textBox19.Text);
            d = Convert.ToDouble(textBox20.Text);
            fizik = a + b + c + d;
            fizik = fizik / 4;
            fizik *= 2;
            // ==============================
            a = Convert.ToDouble(textBox21.Text);
            b = Convert.ToDouble(textBox22.Text);
            c = Convert.ToDouble(textBox23.Text);
            d = Convert.ToDouble(textBox24.Text);
            mate = a + b + c + d;
            mate = mate / 4;
            mate *= 6;
            // ==============================
            a = Convert.ToDouble(textBox25.Text);
            b = Convert.ToDouble(textBox26.Text);
            c = Convert.ToDouble(textBox27.Text);
            d = Convert.ToDouble(textBox28.Text);
            yabanc = a + b + c + d;
            yabanc = yabanc / 4;
            yabanc *= 6;
            // ==============================
            a = Convert.ToDouble(textBox29.Text);
            b = Convert.ToDouble(textBox30.Text);
            c = Convert.ToDouble(textBox31.Text);
            d = Convert.ToDouble(textBox32.Text);
            ikinc = a + b + c + d;
            ikinc = ikinc / 4;
            ikinc *= 2;
            // ==============================
            a = Convert.ToDouble(textBox33.Text);
            b = Convert.ToDouble(textBox34.Text);
            c = Convert.ToDouble(textBox35.Text);
            d = Convert.ToDouble(textBox36.Text);
            din = a + b + c + d;
            din = din / 4;
            din *= 2;
            // ==============================
            a = Convert.ToDouble(textBox37.Text);
            b = Convert.ToDouble(textBox38.Text);
            c = Convert.ToDouble(textBox39.Text);
            d = Convert.ToDouble(textBox40.Text);
            gm = a + b + c + d;
            gm = gm / 4;
            gm *= 1;
            // ==============================
            a = Convert.ToDouble(textBox41.Text);
            b = Convert.ToDouble(textBox42.Text);
            c = Convert.ToDouble(textBox43.Text);
            d = Convert.ToDouble(textBox44.Text);
            beden = a + b + c + d;
            beden = beden / 4;
            beden *= 2;
            // ==============================
            a = Convert.ToDouble(textBox49.Text);
            b = Convert.ToDouble(textBox50.Text);
            c = Convert.ToDouble(textBox51.Text);
            d = Convert.ToDouble(textBox52.Text);
            saglik = a + b + c + d;
            saglik = saglik / 4;
            saglik *= 1;
            if(comboBox1.Text == "2")
            {
                // ==============================
                a = Convert.ToDouble(textBox57.Text);
                b = Convert.ToDouble(textBox58.Text);
                c = Convert.ToDouble(textBox59.Text);
                d = Convert.ToDouble(textBox60.Text);
                sec1 = a + b + c + d;
                sec1 = sec1 / 2;
                // ==============================
                a = Convert.ToDouble(textBox53.Text);
                b = Convert.ToDouble(textBox54.Text);
                c = Convert.ToDouble(textBox55.Text);
                d = Convert.ToDouble(textBox56.Text);
                sec2 = a + b + c + d;
                sec2 = sec2 / 2;
                sonuc1 = turk + cog + tarih + biyolo + kimya + fizik + mate + yabanc + ikinc + din + gm + beden + saglik + sec1 + sec2;
                sonuc2 = sonuc1 / 39;
            }
            else if(comboBox1.Text == "3")
            {
                // ==============================
                a = Convert.ToDouble(textBox57.Text);
                b = Convert.ToDouble(textBox58.Text);
                c = Convert.ToDouble(textBox59.Text);
                d = Convert.ToDouble(textBox60.Text);
                sec1 = a + b + c + d;
                sec1 = sec1 / 2;
                // ==============================
                a = Convert.ToDouble(textBox53.Text);
                b = Convert.ToDouble(textBox54.Text);
                c = Convert.ToDouble(textBox55.Text);
                d = Convert.ToDouble(textBox56.Text);
                sec2 = a + b + c + d;
                sec2 = sec2 / 2;
                // ==============================
                a = Convert.ToDouble(textBox65.Text);
                b = Convert.ToDouble(textBox66.Text);
                c = Convert.ToDouble(textBox67.Text);
                d = Convert.ToDouble(textBox68.Text);
                sec3 = a + b + c + d;
                sec3 = sec3 / 1;
                sonuc1 = turk + cog + tarih + biyolo + kimya + fizik + mate + yabanc + ikinc + din + gm + beden + saglik + sec1 + sec2 + sec3;
                sonuc2 = sonuc1 / 39;
            }
            else if(comboBox1.Text == "4")
            {
                // ==============================
                a = Convert.ToDouble(textBox57.Text);
                b = Convert.ToDouble(textBox58.Text);
                c = Convert.ToDouble(textBox59.Text);
                d = Convert.ToDouble(textBox60.Text);
                sec1 = a + b + c + d;
                sec1 = sec1 / 1;
                // ==============================
                a = Convert.ToDouble(textBox53.Text);
                b = Convert.ToDouble(textBox54.Text);
                c = Convert.ToDouble(textBox55.Text);
                d = Convert.ToDouble(textBox56.Text);
                sec2 = a + b + c + d;
                sec2 = sec2 / 1;
                // ==============================
                a = Convert.ToDouble(textBox65.Text);
                b = Convert.ToDouble(textBox66.Text);
                c = Convert.ToDouble(textBox67.Text);
                d = Convert.ToDouble(textBox68.Text);
                sec3 = a + b + c + d;
                sec3 = sec3 / 1;
                // ==============================
                a = Convert.ToDouble(textBox61.Text);
                b = Convert.ToDouble(textBox62.Text);
                c = Convert.ToDouble(textBox63.Text);
                d = Convert.ToDouble(textBox64.Text);
                sec4 = a + b + c + d;
                sec4 = sec4 / 1;
                sonuc1 = turk + cog + tarih + biyolo + kimya + fizik + mate + yabanc + ikinc + din + gm + beden + saglik + sec1 + sec2 + sec3 + sec4;
                sonuc2 = sonuc1 / 39;
            }

            label22.Visible = true;
            label23.Visible = true;
            sonuc2 = Math.Round(sonuc2, 2);




            label23.Text = Convert.ToString(sonuc2);


        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label21.Visible = false;
            comboBox1.Visible = false;
            groupBox2.Visible = true;
            button1.Visible = true;

            if(comboBox1.Text == "2")
            {
                groupBox2.Height = 89;

            }else if(comboBox1.Text == "3")
            {
                groupBox2.Height = 115;

            }else if(comboBox1.Text == "4")
            {
                groupBox2.Height = 145;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            button1.Visible = false;
            label22.Visible = false;
            label23.Visible = false;

        }
    }
}
