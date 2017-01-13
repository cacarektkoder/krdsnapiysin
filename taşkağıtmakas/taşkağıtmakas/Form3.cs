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
using System.Data.OleDb;

namespace taşkağıtmakas
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con;
        public Form3()
        {
            InitializeComponent();

            try
            {
                con = new MySqlConnection(MySQL.conString);
                con.Open();
            }
            catch
            {
                MessageBox.Show("Sunucuya Bağlanılamıyor...");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            metroLabel2.Text = Form4.gKullanici;
            dataGridView1.Visible = true;
            listBox1.Visible = false;
        }

        Form form1 = new Form1();
        Form form2 = new Form2();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void Form3_FormClosing(object sender, FormClosedEventArgs e)
        {
            MySqlCommand online = new MySqlCommand("UPDATE kayitlar SET gOnline = 0 WHERE gKullanici = '" + Form4.gKullanici + "'", con);
            online.ExecuteNonQuery();
            MySqlCommand oda = new MySqlCommand("UPDATE kayitlar SET gOda = 0 WHERE gKullanici = '" + Form4.gKullanici + "'", con);
            oda.ExecuteNonQuery();
            this.Close();
            con.Close();
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from kayitlar ", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "kayitlar");
                dataGridView1.DataSource = ds.Tables["kayitlar"]; 
                MySqlCommand myCommand = new MySqlCommand("select * from kayitlar", con);
                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    listBox1.Items.Add(myReader.GetString(0));
                }
                myReader.Close();

                listBox1.Visible = true;
            }
            catch
            {
                MessageBox.Show("Üye Listesi Çıkarılırken Bir Hata Oluştu ", "HATA 003-1");
            }

        }
        int sayi = 0;
        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {

                groupBox1.Visible = true;
                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from kayitlar where gOda > 0", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "kayitlar");
                dataGridView1.DataSource = ds.Tables["kayitlar"];
                
                string say = dataGridView1[5, sayi].Value.ToString();
                if (say != 0.ToString())
                {
                    for (sayi = 0; sayi == 0; sayi++)
                    {
                        MessageBox.Show(Convert.ToString(sayi));
                        say = dataGridView1[5, sayi].Value.ToString();
                        if (say == 1.ToString())
                        {
                            if (label2.Text == 1.ToString())
                            {
                                label2.Text = 2.ToString();
                            }
                            else
                            {
                                label2.Text = 1.ToString();
                            }
                        }
                        else if (say == 2.ToString())
                        {
                            if (label5.Text == 1.ToString())
                            {
                                label5.Text = 2.ToString();
                            }
                            else
                            {
                                label5.Text = 1.ToString();
                            }
                        }
                        else if (say == 3.ToString())
                        {
                            if (label8.Text == 1.ToString())
                            {
                                label8.Text = 2.ToString();
                            }
                            else
                            {
                                label8.Text = 1.ToString();
                            }
                        }
                        else if (say == 4.ToString())
                        {
                            if (label11.Text == 1.ToString())
                            {
                                label11.Text = 2.ToString();
                            }
                            else
                            {
                                label11.Text = 1.ToString();
                            }
                        }
                        else if (say == 5.ToString())
                        {
                            if (label14.Text == 1.ToString())
                            {
                                label14.Text = 2.ToString();
                            }
                            else
                            {
                                label14.Text = 1.ToString();
                            }
                        }
                        else if (say == 6.ToString())
                        {
                            if (label17.Text == 1.ToString())
                            {
                                label17.Text = 2.ToString();
                            }
                            else
                            {
                                label17.Text = 1.ToString();
                            }
                        }
                        else if (say == 7.ToString())
                        {
                            if (label20.Text == 1.ToString())
                            {
                                label20.Text = 2.ToString();
                            }
                            else
                            {
                                label20.Text = 1.ToString();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kimse Açık Değil....", "Yanlızlık...");
                }
            }
            catch
            {
                MessageBox.Show("Bir Hata Yaklaşıyor Efendim...", "HATA 3131");
            }
        }
    }
}
