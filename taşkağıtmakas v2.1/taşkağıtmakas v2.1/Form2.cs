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

namespace taşkağıtmakas_v2._1
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        // ##############################
        MySqlConnection con;
        public static int kOda;
        public static string rakip,ben;
        Form f1;
        int sayi = 0;
        int say;
        // ##############################
        public Form2()
        {
            try
            {
                con = new MySqlConnection(MySQL.conString);
                con.Open();
            }
            catch
            {
                MessageBox.Show("Sunucuya Bağlanılırken Bir Hata Oluştu...");
            }
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e) // Load
        {
            dataGridView1.Visible = false;
            // listBox1.Visible = false;
            groupBox2.Visible = false;
       
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


        }
        private void pictureBox1_Click(object sender, EventArgs e) // Çıkış
        {
            MessageBox.Show("Kaydınız Güncelleniyor Lütfen Bekleyiniz...");
            MySqlCommand online = new MySqlCommand("UPDATE kayitlar SET gOnline = 0 WHERE gKullanici = '" + Form1.gKullanici + "'", con);
            online.ExecuteNonQuery();
            MySqlCommand oda = new MySqlCommand("UPDATE kayitlar SET gOda = 0 WHERE gKullanici = '" + Form1.gKullanici + "'", con);
            oda.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kaydınız Güncellendi İyi Günler Dileriz...");
            this.Close();

        }
        private void pictureBox2_Click(object sender, EventArgs e) // Geri
        {
            DialogResult dialogResult = MessageBox.Show("Hesabınızdan Çıkış Yapmak İstediğinize Eminmisiniz ?", "Çıkış", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                f1 = new Form1();
                this.Hide();
                f1.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }

            
        }

        private void pictureBox3_Click(object sender, EventArgs e) // Lobiler Yenilenir
        {
            label8.Text = "0";
            label9.Text = "0";
            label10.Text = "0";
            label11.Text = "0";
            label12.Text = "0";
            label13.Text = "0";
            label14.Text = "0";
            // Read
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from kayitlar where gOda > 0", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "kayitlar");
            dataGridView1.DataSource = ds.Tables["kayitlar"];
            MySqlCommand myCommand = new MySqlCommand("select * from kayitlar where gOda > 0", con);
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                listBox1.Items.Add(myReader.GetString(5));
            }
            myReader.Close();
            // Read

            // Bul
            try
            {
                listBox1.SetSelected(0, false);
            }
            catch
            {
                MessageBox.Show("Bir Hata Oluştu..");
            }

            if (listBox1.FindString(1.ToString()) != -1) // Eğer değer listbox'ta var ise
            {
                if (listBox1.Items.Contains(1.ToString()) == false)
                {
                    label8.Text = 1.ToString();
                }
                else
                {
                    label8.Text = 2.ToString();
                }

            }
            if (listBox1.FindString(2.ToString()) != -1)
            {
                if (listBox1.Items.Contains(2.ToString()) == false)
                {
                    label9.Text = 1.ToString();
                }
                else
                {
                    label9.Text = 2.ToString();
                }

            }
            if (listBox1.FindString(3.ToString()) != -1)
            {
                if (listBox1.Items.Contains(3.ToString()) == false)
                {
                    label10.Text = 1.ToString();
                }
                else
                {
                    label10.Text = 2.ToString();
                }
            }
            if (listBox1.FindString(4.ToString()) != -1)
            {
                if (listBox1.Items.Contains(4.ToString()) == false)
                {
                    label11.Text = 1.ToString();
                }
                else
                {
                    label11.Text = 2.ToString();
                }
            }
            if (listBox1.FindString(5.ToString()) != -1)
            {
                if (listBox1.Items.Contains(5.ToString()) == false)
                {
                    label12.Text = 1.ToString();
                }
                else
                {
                    label12.Text = 2.ToString();
                }
            }
            if (listBox1.FindString(6.ToString()) != -1)
            {
                if (listBox1.Items.Contains(6.ToString()) == false)
                {
                    label13.Text = 1.ToString();
                }
                else
                {
                    label13.Text = 2.ToString();
                }
            }
            if (listBox1.FindString(7.ToString()) != -1)
            {
                if (listBox1.Items.Contains(1.ToString()) == false)
                {
                    label14.Text = 1.ToString();
                }
                else
                {
                    label14.Text = 2.ToString();
                }
            }
            // Bul
        }

        private void button1_Click(object sender, EventArgs e) // Lobi 1
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from kayitlar where gOda = 1", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "kayitlar");
            dataGridView1.DataSource = ds.Tables["kayitlar"];

            rakip = dataGridView1[0, 0].Value.ToString();

            groupBox2.Visible = true;
            groupBox2.Text = "Lobi 1";

            if(label8.Text == "0")
            {
                kBirinci.Text = Form1.gKullanici;
            }
            else if(label8.Text == "1")
            {
                kBirinci.Text = Form2.rakip;
                kIkinci.Text = Form1.gKullanici;
            }

        }
    }
}
