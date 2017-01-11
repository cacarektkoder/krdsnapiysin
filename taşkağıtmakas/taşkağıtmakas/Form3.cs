using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taşkağıtmakas
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

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
    }
}
