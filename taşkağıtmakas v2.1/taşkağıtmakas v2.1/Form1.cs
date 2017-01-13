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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        // ##############################
        MySqlConnection con;
        public static string gKullanici, gPass, kKullanici, kPass, kPosta, gOnline, gPuan;



        Form f2;
        // ##############################
        public Form1()
        {
            // Bağlantı Açılır...
            try
            {
                con = new MySqlConnection(MySQL.conString);
                con.Open();
            }
            catch
            {
                MessageBox.Show("Sunucuya Bağlanılırken Bir Hata Oluştu...");
            }
            // 

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // Load
        {
            dataGridView1.Visible = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            // Kayıt Yapılır
            kKullanici = textBox4.Text;
            kPass = textBox3.Text;
            kPosta = textBox5.Text;
            try
            {
                MySqlCommand command = new MySqlCommand("insert into kayitlar(gKullanici,gPass,gPosta)values('" + kKullanici + "','" + kPass + "','" + kPosta + "')", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı ... Lütfen Giriş Yapınız ");
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            catch
            {
                MessageBox.Show("Kayıt Başarısız....", "HATA 001");
            }
            // 
        } // Kayıt
        private void metroButton1_Click(object sender, EventArgs e)
        {

            // Veriler Çekilir
            kKullanici = textBox1.Text;
            kPass = textBox2.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from kayitlar where gKullanici = '" + kKullanici + "'", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "kayitlar");
            dataGridView1.DataSource = ds.Tables["kayitlar"];
            //

            // Giriş İşlemi Yapılır
            if (dataGridView1.RowCount < 2)
            {
                MessageBox.Show("Böyle Bir Kayıt Yok ...");
            }
            else
            {
                gKullanici = dataGridView1[0, 0].Value.ToString();
                gPass = dataGridView1[1, 0].Value.ToString();



                if (kKullanici == gKullanici && gPass == kPass)
                {
                    MessageBox.Show("Giriş Başarılı ..");
                    MySqlCommand online = new MySqlCommand("UPDATE kayitlar SET gOnline = 1 WHERE gKullanici = '" + Form1.gKullanici + "'", con);
                    online.ExecuteNonQuery();
                    this.Hide();
                    f2 = new Form2();
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız ..");
                }
            }
            //


        } // Giriş
        private void pictureBox1_Click(object sender, EventArgs e) // Çıkış
        {
            MessageBox.Show("Kaydınız Güncelleniyor Lütfen Bekleyiniz...");
            MySqlCommand online = new MySqlCommand("UPDATE kayitlar SET gOnline = 0 WHERE gKullanici = '" + gKullanici + "'", con);
            online.ExecuteNonQuery();
            MySqlCommand oda = new MySqlCommand("UPDATE kayitlar SET gOda = 0 WHERE gKullanici = '" + Form1.gKullanici + "'", con);
            oda.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kaydınız Güncellendi İyi Günler Dileriz...");
            this.Close();
        }
    }
}
