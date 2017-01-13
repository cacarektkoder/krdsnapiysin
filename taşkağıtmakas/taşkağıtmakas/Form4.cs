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
    public partial class Form4 : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con;
        Form form3 = new Form3();
        Form bu = new Form4();
        public Form4()
        {
            con = new MySqlConnection(MySQL.conString);
            con.Open();
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        public static string gKullanici, gPass, kKullanici, kPass, kPosta, gOnline, gPuan;
        
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            kKullanici = textBox1.Text;
            kPass = textBox2.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from kayitlar where gKullanici = '" + kKullanici + "'", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "kayitlar");
            dataGridView1.DataSource = ds.Tables["kayitlar"];
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
                    MySqlCommand online = new MySqlCommand("UPDATE kayitlar SET gOnline = 1 WHERE gKullanici = '" + gKullanici + "'", con);
                    online.ExecuteNonQuery();
                    
                    form3.Show();
                    bu.Close();
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız ..");
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Kayıt Başarısız....","HATA 001");
            }
        }
        private void Form4_FormClosing(object sender, FormClosedEventArgs e)
        {
            MySqlCommand online = new MySqlCommand("UPDATE kayitlar SET gOnline = 0 WHERE gKullanici = '" + gKullanici + "'", con);
            online.ExecuteNonQuery();
            MySqlCommand oda = new MySqlCommand("UPDATE kayitlar SET gOda = 0 WHERE gKullanici = '" + Form4.gKullanici + "'", con);
            oda.ExecuteNonQuery();
            con.Close();
        }
    }
}
