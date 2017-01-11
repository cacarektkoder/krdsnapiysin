using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace taşkağıtmakas
{

    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        int gelen, giden;
        int hata;
        MySqlConnection con;
        public Form2()
        {
            

            InitializeComponent();
            try
            {
                con = new MySqlConnection(MySQL.conString);
                con.Open();
                 MySqlCommand sil = new MySqlCommand("DELETE from oyun where gelenBirinci ", con);
                sil.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Sunucuya Bağlanılamıyor....", "HATA: 001");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true && pictureBox2.Visible == true && pictureBox3.Visible == true)
            {
                label2.Text = "Seçiminizi Yapınız ...";
            }
            button1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // 1
            button1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            label2.Text = "Seçiminiz 'Kağıt' dır ...";
            giden = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // 2
            button1.Visible = true;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            label2.Text = "Seçiminiz 'Makas' dır ...";
            giden = 2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // 3
            button1.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            label2.Text = "Seçiminiz 'Taş' dır ...";
            giden = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == false || pictureBox2.Visible == false || pictureBox3.Visible == false)
            {


                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from oyun where gelenBirinci >  0", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "oyun");
                dataGridView1.DataSource = ds.Tables["oyun"];
                string gelenstring = "";


                
                try
                {
                    MySqlCommand command = new MySqlCommand("insert into oyun(gelenIkinci)values('" + giden + "')", con);
                    command.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Sunucuya Aktarılamadı", "HATA 002");
                }
                

                try
                {
                    gelenstring = dataGridView1[0, 0].Value.ToString();
                    gelen = Convert.ToInt16(gelenstring);
                    label3.Text = gelen.ToString();
                    label4.Text = giden.ToString();

                    if (label3.Text == label4.Text)
                    {
                        label2.Text = "Berabere";
                    }
                    else if (label3.Text == 3.ToString() && label4.Text == 2.ToString())
                    {
                        label2.Text = "Kaybettiniz ... Karşının Seçimi : TAŞ";
                    }
                    else if (label3.Text == 2.ToString() && label4.Text == 1.ToString())
                    {
                        label2.Text = "Kaybettiniz ... Karşının Seçimi : MAKAS";
                    }
                    else if (label3.Text == 1.ToString() && label4.Text == 3.ToString())
                    {
                        label2.Text = "Kaybettiniz ... Karşının Seçimi : KAĞIT";
                    }
                    else
                    {
                        label2.Text = "KAZANDINIZ !! ... TEBRİKLER !!!";
                    }
                }
                catch
                {
                    MessageBox.Show("Karşıdaki Hamlesini Yapmadı ... Lütfen Daha Sonra Tekrar Deneyiniz ", "HATA 003");
                    hata = 1;
                }            
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yapınız ...", "HATA 005");
                hata = 0;
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}

