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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            login form = new login();
            form.Show();
            this.Hide();

        }

        private void btn_regis_Click(object sender, EventArgs e)
        {
            //Register form = new Register();
            //form.Show();
            //this.Hide();
        }

        private void welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
