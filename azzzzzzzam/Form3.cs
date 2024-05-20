using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace azzzzzzzam
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data_Admin form = new Data_Admin();
            form.Show();
            Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data_Guru form = new Data_Guru();
            form.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data_Siswa form = new Data_Siswa();
            form.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Data_Kelas form =
                new Data_Kelas();
            form.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Paket_Bimbel form = new Paket_Bimbel();
            form.Show();
            Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
