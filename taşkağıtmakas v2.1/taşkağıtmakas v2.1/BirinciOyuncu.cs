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
    public partial class BirinciOyuncu : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con;
        public static int hamle = 0, rakiphamle = 0, haraket = 0, rakipharaket = 0;
        
        public BirinciOyuncu()
        {
            
            InitializeComponent();
        }

        private void BirinciOyuncu_Load(object sender, EventArgs e) // Load
        {
            con = new MySqlConnection(MySQL.conString);
            con.Open();


            
        }

        private void pictureBox2_Click(object sender, EventArgs e) // Kağıt
        {
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            hamle = 2;
            MySqlCommand komut = new MySqlCommand("insert into chat(gSecimBirinci,gHamleBirinci)values('1','" + hamle + "')", con);
            komut.ExecuteNonQuery();


        }
        private void pictureBox3_Click(object sender, EventArgs e) // Makas
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            hamle = 3;
            MySqlCommand komut = new MySqlCommand("insert into chat(gSecimBirinci,gHamleBirinci)values('1','" + hamle + "')", con);
            komut.ExecuteNonQuery();
        }
        private void pictureBox1_Click(object sender, EventArgs e) // Taş
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            hamle = 1;
            MySqlCommand komut = new MySqlCommand("insert into chat(gSecimBirinci,gHamleBirinci)values('1','" + hamle + "')", con);
            komut.ExecuteNonQuery();
        }
        private void pictureBox4_Click(object sender, EventArgs e) // Yenile
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from chat", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "chat");
            dataGridView1.DataSource = ds.Tables["chat"];

            haraket = Convert.ToInt16(dataGridView1[0, 0].Value);
            rakipharaket = Convert.ToInt16(dataGridView1[1, 0].Value);

            hamle = Convert.ToInt16(dataGridView1[2, 0].Value);
            rakiphamle = Convert.ToInt16(dataGridView1[3, 0].Value);

            if(rakipharaket == 1)
            {
                listBox1.Items.Add("Server : " + Form2.rakip + " adlı oyuncu seçimini yaptı!.");
            }
            if(haraket == 1)
            {
                listBox1.Items.Add("Server" + Form2.ben + "adlı oyuncu seçimini yaptı!.");
            }
        }


    }
}
