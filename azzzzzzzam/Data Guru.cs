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
    public partial class Data_Guru : Form
    {
        public Data_Guru()
        {
            InitializeComponent();
        }

        private void Data_Guru_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Ma'am Rahma", "Perempuan", "+62 897-7952-788", "-", "English");
            dataGridView1.Rows.Add("Moh. Shobirin", "Laki - laki", "+62 813-3255-8623","-", "PPLG (C#)");
            dataGridView1.Rows.Add("Halimatus Sa'diyah", "Perempuan", "+62 877-2377-9990","-", "PPLG (HTML)");
            dataGridView1.Rows.Add("Moh. Wildam", "Laki - laki", "+62 857-9156-4297","-", "PPLG (Java)");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            string jenis = comboBox1.Text;
            string telp = textBox3.Text;
            string lulus = comboBox2.Text;
            string mata = comboBox3.Text;

            dataGridView1.Rows.Add(nama, jenis, telp, lulus, mata);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
