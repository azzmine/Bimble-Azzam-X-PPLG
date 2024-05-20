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
    public partial class login_pengguna : Form
    {
        public login_pengguna()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            dashboard_admid form = new dashboard_admid();
            form.Show();
            Hide();


        }

        private void login_pengguna_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard_siswa dashboard_Siswa = new dashboard_siswa();
            dashboard_Siswa.Show();
            Hide();
        }
    }
}
