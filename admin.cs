using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiHotel_CodeStay
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void btn_kelolakamar_Click(object sender, EventArgs e)
        {
            loadform(new KelolaKamar());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            login Login = new login();
            Login.Show();
            this.Hide();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new KelolaDataCostumer());
        }

        private void btn_kelolareservasi_Click(object sender, EventArgs e)
        {
            loadform(new LihatReservasi());
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_kelolaakun_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadform(new KelolaAkun());
        }
    }
}
