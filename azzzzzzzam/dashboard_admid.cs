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
    public partial class dashboard_admid : Form
    {
        public dashboard_admid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();   
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Jadwal_Pelajaran form = new Jadwal_Pelajaran();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anggota_Bimbel form = new Anggota_Bimbel();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Data_Angsuran form = new Data_Angsuran();
            form.Show();
        }

        private void dashboard_admid_Load(object sender, EventArgs e)
        {

        }
    }
}
