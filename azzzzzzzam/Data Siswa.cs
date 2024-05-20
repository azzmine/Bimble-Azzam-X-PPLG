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
    public partial class Data_Siswa : Form
    {
        public Data_Siswa()
        {
            InitializeComponent();
        }

        private void Data_Siswa_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("-", "Muhammad Sya`ban Hidayatullah", "Jln. Jendral Soedirman RT/004 RW/006", "6 Agustus 2008", "Laki - laki");
            dataGridView1.Rows.Add("-", "Muhammad Ivan Rifansyah", "Jln. Bendosulung RT/004 RW/005", "5 November 2008", "Laki - laki");
            dataGridView1.Rows.Add("-", "Nikmatul Khoiroh", "Kedung Pandan RT/011 RW/004", "24 Mei 2007", "Perempuan");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
