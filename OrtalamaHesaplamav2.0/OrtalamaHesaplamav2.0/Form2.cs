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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        double edebi, dil, cog, tarih, biyolo, kimya, fizik, mate, yabanc, ikinc, din, gm, beden, sec1, sec2, sec3, sec4, sec5, sec6, sec7;

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        double a, b, c, d;
        double sonuc1, sonuc2;
        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            label21.Visible = false;
            comboBox1.Visible = false;

            if (comboBox1.Text == "3")
            {
                groupBox2.Height = 113;
            }
            else if (comboBox1.Text == "4")
            {
                groupBox2.Height = 147;
            }
            else if (comboBox1.Text == "5")
            {
                groupBox2.Height = 175;
            }
            else if (comboBox1.Text == "6")
            {
                groupBox2.Height = 206;
            }
            else if (comboBox1.Text == "7")
            {

            }
            else
            {
                MessageBox.Show("Sen Kendini Akıllımı Zannettin ?");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            d = Convert.ToDouble(textBox4.Text);
            edebi = a + b + c + d;
            edebi = edebi / 4;
            edebi *= 3;
            //==================================================
            a = Convert.ToDouble(textBox9.Text);
            b = Convert.ToDouble(textBox10.Text);
            c = Convert.ToDouble(textBox11.Text);
            d = Convert.ToDouble(textBox12.Text);
            dil = a + b + c + d;
            dil = dil / 4;
            dil *= 2;
            //==================================================
            a = Convert.ToDouble(textBox45.Text);
            b = Convert.ToDouble(textBox46.Text);
            c = Convert.ToDouble(textBox47.Text);
            d = Convert.ToDouble(textBox48.Text);
            cog = a + b + c + d;
            cog = cog / 4;
            cog *= 2;
            //==================================================
            a = Convert.ToDouble(textBox5.Text);
            b = Convert.ToDouble(textBox6.Text);
            c = Convert.ToDouble(textBox7.Text);
            d = Convert.ToDouble(textBox8.Text);
            tarih = a + b + c + d;
            tarih = tarih / 4;
            tarih *= 2;
            //==================================================
            a = Convert.ToDouble(textBox13.Text);
            b = Convert.ToDouble(textBox14.Text);
            c = Convert.ToDouble(textBox15.Text);
            d = Convert.ToDouble(textBox16.Text);
            biyolo = a + b + c + d;
            biyolo = biyolo / 4;
            biyolo *= 3;
            //==================================================
            a = Convert.ToDouble(textBox17.Text);
            b = Convert.ToDouble(textBox18.Text);
            c = Convert.ToDouble(textBox19.Text);
            d = Convert.ToDouble(textBox20.Text);
            kimya = a + b + c + d;
            kimya = kimya / 4;
            kimya *= 2;
            //==================================================
            a = Convert.ToDouble(textBox21.Text);
            b = Convert.ToDouble(textBox22.Text);
            c = Convert.ToDouble(textBox23.Text);
            d = Convert.ToDouble(textBox24.Text);
            fizik = a + b + c + d;
            fizik = fizik / 4;
            fizik *= 2;
            //==================================================
            a = Convert.ToDouble(textBox25.Text);
            b = Convert.ToDouble(textBox26.Text);
            c = Convert.ToDouble(textBox27.Text);
            d = Convert.ToDouble(textBox28.Text);
            mate = a + b + c + d;
            mate = mate / 4;
            mate *= 6;
            //==================================================
            a = Convert.ToDouble(textBox29.Text);
            b = Convert.ToDouble(textBox30.Text);
            c = Convert.ToDouble(textBox31.Text);
            d = Convert.ToDouble(textBox32.Text);
            yabanc = a + b + c + d;
            yabanc = yabanc / 4;
            yabanc *= 4;
            //==================================================
            a = Convert.ToDouble(textBox33.Text);
            b = Convert.ToDouble(textBox34.Text);
            c = Convert.ToDouble(textBox35.Text);
            d = Convert.ToDouble(textBox36.Text);
            ikinc = a + b + c + d;
            ikinc = ikinc / 4;
            ikinc *= 2;
            //==================================================
            a = Convert.ToDouble(textBox37.Text);
            b = Convert.ToDouble(textBox38.Text);
            c = Convert.ToDouble(textBox39.Text);
            d = Convert.ToDouble(textBox40.Text);
            din = a + b + c + d;
            din = din / 4;
            din *= 2;
            //==================================================
            a = Convert.ToDouble(textBox41.Text);
            b = Convert.ToDouble(textBox42.Text);
            c = Convert.ToDouble(textBox43.Text);
            d = Convert.ToDouble(textBox44.Text);
            gm = a + b + c + d;
            gm = gm / 4;
            gm *= 1;
            //==================================================
            a = Convert.ToDouble(textBox49.Text);
            b = Convert.ToDouble(textBox50.Text);
            c = Convert.ToDouble(textBox51.Text);
            d = Convert.ToDouble(textBox52.Text);
            beden = a + b + c + d;
            beden = beden / 4;
            beden *= 2;







            if (comboBox1.Text == "2")
            {
                a = Convert.ToDouble(textBox57.Text);
                b = Convert.ToDouble(textBox58.Text);
                c = Convert.ToDouble(textBox59.Text);
                d = Convert.ToDouble(textBox60.Text);
                sec1 = a + b + c + d;
                sec1 = sec1 / 4;
                sec1 *= 4;
                //====================================================
                a = Convert.ToDouble(textBox53.Text);
                b = Convert.ToDouble(textBox54.Text);
                c = Convert.ToDouble(textBox55.Text);
                d = Convert.ToDouble(textBox56.Text);
                sec2 = a + b + c + d;
                sec2 = sec2 / 4;
                sec2 *= 3;
                sonuc1 = edebi + dil + cog + tarih + biyolo + kimya + fizik + mate + yabanc + ikinc + din + gm + beden + sec1 + sec2;
                sonuc2 = sonuc1 / 39;
            }
            else if (comboBox1.Text == "3")
            {

                a = Convert.ToDouble(textBox57.Text);
                b = Convert.ToDouble(textBox58.Text);
                c = Convert.ToDouble(textBox59.Text);
                d = Convert.ToDouble(textBox60.Text);
                sec1 = a + b + c + d;
                sec1 = sec1 / 4;
                sec1 *= 3;
                //====================================================
                a = Convert.ToDouble(textBox53.Text);
                b = Convert.ToDouble(textBox54.Text);
                c = Convert.ToDouble(textBox55.Text);
                d = Convert.ToDouble(textBox56.Text);
                sec2 = a + b + c + d;
                sec2 = sec2 / 4;
                sec2 *= 2;
                //====================================================
                a = Convert.ToDouble(textBox65.Text);
                b = Convert.ToDouble(textBox66.Text);
                c = Convert.ToDouble(textBox67.Text);
                d = Convert.ToDouble(textBox68.Text);
                sec3 = a + b + c + d;
                sec3 = sec3 / 4;
                sec3 *= 2;
                sonuc1 = edebi + dil + cog + tarih + biyolo + kimya + fizik + mate + yabanc + ikinc + din + gm + beden + sec1 + sec2 + sec3;
                sonuc2 = sonuc1 / 39;
            }
            else if (comboBox1.Text == "4")
            {

                a = Convert.ToDouble(textBox57.Text);
                b = Convert.ToDouble(textBox58.Text);
                c = Convert.ToDouble(textBox59.Text);
                d = Convert.ToDouble(textBox60.Text);
                sec1 = a + b + c + d;
                sec1 = sec1 / 4;
                sec1 *= 2;
                //====================================================
                a = Convert.ToDouble(textBox53.Text);
                b = Convert.ToDouble(textBox54.Text);
                c = Convert.ToDouble(textBox55.Text);
                d = Convert.ToDouble(textBox56.Text);
                sec2 = a + b + c + d;
                sec2 = sec2 / 4;
                sec2 *= 2;
                //====================================================
                a = Convert.ToDouble(textBox65.Text);
                b = Convert.ToDouble(textBox66.Text);
                c = Convert.ToDouble(textBox67.Text);
                d = Convert.ToDouble(textBox68.Text);
                sec3 = a + b + c + d;
                sec3 = sec3 / 4;
                sec3 *= 2;
                //====================================================
                a = Convert.ToDouble(textBox61.Text);
                b = Convert.ToDouble(textBox62.Text);
                c = Convert.ToDouble(textBox63.Text);
                d = Convert.ToDouble(textBox64.Text);
                sec4 = a + b + c + d;
                sec4 = sec4 / 4;
                sec4 *= 1;
                sonuc1 = edebi + dil + cog + tarih + biyolo + kimya + fizik + mate + yabanc + ikinc + din + gm + beden + sec1 + sec2 + sec3 + sec4;
                sonuc2 = sonuc1 / 39;
            }
            else if (comboBox1.Text == "5")
            {
                a = Convert.ToDouble(textBox57.Text);
                b = Convert.ToDouble(textBox58.Text);
                c = Convert.ToDouble(textBox59.Text);
                d = Convert.ToDouble(textBox60.Text);
                sec1 = a + b + c + d;
                sec1 = sec1 / 4;
                sec1 *= 2;
                //====================================================
                a = Convert.ToDouble(textBox53.Text);
                b = Convert.ToDouble(textBox54.Text);
                c = Convert.ToDouble(textBox55.Text);
                d = Convert.ToDouble(textBox56.Text);
                sec2 = a + b + c + d;
                sec2 = sec2 / 4;
                sec2 *= 2;
                //====================================================
                a = Convert.ToDouble(textBox65.Text);
                b = Convert.ToDouble(textBox66.Text);
                c = Convert.ToDouble(textBox67.Text);
                d = Convert.ToDouble(textBox68.Text);
                sec3 = a + b + c + d;
                sec3 = sec3 / 4;
                sec3 *= 1;
                //====================================================
                a = Convert.ToDouble(textBox61.Text);
                b = Convert.ToDouble(textBox62.Text);
                c = Convert.ToDouble(textBox63.Text);
                d = Convert.ToDouble(textBox64.Text);
                sec4 = a + b + c + d;
                sec4 = sec4 / 4;
                sec4 *= 1;
                //====================================================
                a = Convert.ToDouble(textBox73.Text);
                b = Convert.ToDouble(textBox74.Text);
                c = Convert.ToDouble(textBox75.Text);
                d = Convert.ToDouble(textBox76.Text);
                sec5 = a + b + c + d;
                sec5 = sec5 / 4;
                sec5 *= 1;
                sonuc1 = edebi + dil + cog + tarih + biyolo + kimya + fizik + mate + yabanc + ikinc + din + gm + beden + sec1 + sec2 + sec3 + sec4 + sec5;
                sonuc2 = sonuc1 / 39;


            }
            else if (comboBox1.Text == "5")
            {

                a = Convert.ToDouble(textBox57.Text);
                b = Convert.ToDouble(textBox58.Text);
                c = Convert.ToDouble(textBox59.Text);
                d = Convert.ToDouble(textBox60.Text);
                sec1 = a + b + c + d;
                sec1 = sec1 / 4;
                sec1 *= 2;
                //====================================================
                a = Convert.ToDouble(textBox53.Text);
                b = Convert.ToDouble(textBox54.Text);
                c = Convert.ToDouble(textBox55.Text);
                d = Convert.ToDouble(textBox56.Text);
                sec2 = a + b + c + d;
                sec2 = sec2 / 4;
                sec2 *= 1;
                //====================================================
                a = Convert.ToDouble(textBox65.Text);
                b = Convert.ToDouble(textBox66.Text);
                c = Convert.ToDouble(textBox67.Text);
                d = Convert.ToDouble(textBox68.Text);
                sec3 = a + b + c + d;
                sec3 = sec3 / 4;
                sec3 *= 1;
                //====================================================
                a = Convert.ToDouble(textBox61.Text);
                b = Convert.ToDouble(textBox62.Text);
                c = Convert.ToDouble(textBox63.Text);
                d = Convert.ToDouble(textBox64.Text);
                sec4 = a + b + c + d;
                sec4 = sec4 / 4;
                sec4 *= 1;
                //====================================================
                a = Convert.ToDouble(textBox73.Text);
                b = Convert.ToDouble(textBox74.Text);
                c = Convert.ToDouble(textBox75.Text);
                d = Convert.ToDouble(textBox76.Text);
                sec5 = a + b + c + d;
                sec5 = sec5 / 4;
                sec5 *= 1;
                //=====================================================
                a = Convert.ToDouble(textBox69.Text);
                b = Convert.ToDouble(textBox70.Text);
                c = Convert.ToDouble(textBox71.Text);
                d = Convert.ToDouble(textBox72.Text);
                sec6 = a + b + c + d;
                sec6 = sec6 / 4;
                sec6 *= 1;
                sonuc1 = edebi + dil + cog + tarih + biyolo + kimya + fizik + mate + yabanc + ikinc + din + gm + beden + sec1 + sec2 + sec3 + sec4 + sec5 + sec6;
                sonuc2 = sonuc1 / 39;
            }
            else if (comboBox1.Text == "7")
            {
                a = Convert.ToDouble(textBox57.Text);
                b = Convert.ToDouble(textBox58.Text);
                c = Convert.ToDouble(textBox59.Text);
                d = Convert.ToDouble(textBox60.Text);
                sec1 = a + b + c + d;
                sec1 = sec1 / 4;
                sec1 *= 2;
                //====================================================
                a = Convert.ToDouble(textBox53.Text);
                b = Convert.ToDouble(textBox54.Text);
                c = Convert.ToDouble(textBox55.Text);
                d = Convert.ToDouble(textBox56.Text);
                sec2 = a + b + c + d;
                sec2 = sec2 / 4;
                sec2 *= 1;
                //====================================================
                a = Convert.ToDouble(textBox65.Text);
                b = Convert.ToDouble(textBox66.Text);
                c = Convert.ToDouble(textBox67.Text);
                d = Convert.ToDouble(textBox68.Text);
                sec3 = a + b + c + d;
                sec3 = sec3 / 4;
                sec3 *= 1;
                //====================================================
                a = Convert.ToDouble(textBox61.Text);
                b = Convert.ToDouble(textBox62.Text);
                c = Convert.ToDouble(textBox63.Text);
                d = Convert.ToDouble(textBox64.Text);
                sec4 = a + b + c + d;
                sec4 = sec4 / 4;
                sec4 *= 1;
                //====================================================
                a = Convert.ToDouble(textBox73.Text);
                b = Convert.ToDouble(textBox74.Text);
                c = Convert.ToDouble(textBox75.Text);
                d = Convert.ToDouble(textBox76.Text);
                sec5 = a + b + c + d;
                sec5 = sec5 / 4;
                sec5 *= 1;
                //=====================================================
                a = Convert.ToDouble(textBox69.Text);
                b = Convert.ToDouble(textBox70.Text);
                c = Convert.ToDouble(textBox71.Text);
                d = Convert.ToDouble(textBox72.Text);
                sec6 = a + b + c + d;
                sec6 = sec6 / 4;
                sec6 *= 1;
                //=====================================================
                a = Convert.ToDouble(textBox77.Text);
                b = Convert.ToDouble(textBox78.Text);
                c = Convert.ToDouble(textBox79.Text);
                d = Convert.ToDouble(textBox80.Text);
                sec7 = a + b + c + d;
                sec7 = sec7 / 4;
                sec7 *= 1;
                sonuc1 = edebi + dil + cog + tarih + biyolo + kimya + fizik + mate + yabanc + ikinc + din + gm + beden + sec1 + sec2 + sec3 + sec4 + sec5 + sec6 + sec7;
                sonuc2 = sonuc1 / 39;
            }
            label22.Visible = true;
            label23.Visible = true;
            sonuc2 = Math.Round(sonuc2, 2);




            label23.Text = Convert.ToString(sonuc2);
        }

    }

}
