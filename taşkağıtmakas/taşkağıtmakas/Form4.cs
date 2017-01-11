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
        public Form4()
        {
            con = new MySqlConnection(MySQL.conString);
            con.Open();
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        string gKullanici, gPass, kKullanici, kPass, kPosta;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from kayitlar ", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "kayitlar");
            dataGridView1.DataSource = ds.Tables["kayitlar"];

            gKullanici = dataGridView1[0, 0].Value.ToString();
            gPass = dataGridView1[1, 0].Value.ToString();

            kKullanici = textBox1.Text;
            kPass = textBox2.Text;

            if(kKullanici == gKullanici && gPass == kPass)
            {
                MessageBox.Show("Giriş Başarılı ..");
                this.Hide();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız ..");
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
    }
}
