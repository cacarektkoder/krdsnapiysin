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

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            label21.Visible = false;
            comboBox1.Visible = false;

            if(comboBox1.Text == "3")
            {
                groupBox2.Height = 113;
            }else if(comboBox1.Text == "4")
            {
                groupBox2.Height = 147;
            }else if(comboBox1.Text == "5")
            {
                groupBox2.Height = 175;
            }else if(comboBox1.Text == "6")
            {
                groupBox2.Height = 206;
            }else if(comboBox1.Text == "7")
            {

            }else
            {
                MessageBox.Show("Sen Kendini Akıllımı Zannettin ?");
            }
            
        }
    }
}
