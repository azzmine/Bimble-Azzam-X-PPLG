﻿using System;
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
    public partial class dashboard_siswa : Form
    {
        public dashboard_siswa()
        {
            InitializeComponent();
        }

        private void dashboard_siswa_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Jadwal_Pelajaran jadwal_Pelajaran = new Jadwal_Pelajaran();
            jadwal_Pelajaran.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Histori_Angsuran histori_ = new Histori_Angsuran(); 
            histori_.Show();
        }
    }
}
