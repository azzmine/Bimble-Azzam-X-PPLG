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
    public partial class Data_Angsuran : Form
    {
        public Data_Angsuran()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tambah_Angsuran tambah_Angsuran = new Tambah_Angsuran();
            tambah_Angsuran.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Katedori_Angsuran katedori_Angsuran = new Katedori_Angsuran();
            katedori_Angsuran.Show();
        }

        private void Data_Angsuran_Load(object sender, EventArgs e)
        {

        }
    }
}
