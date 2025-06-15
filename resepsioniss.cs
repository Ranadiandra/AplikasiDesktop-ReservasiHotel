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
    public partial class resepsioniss : Form
    {   
        private string idCustomer;
        private string idReservasi;

        public resepsioniss()
        {
            InitializeComponent();
        }
        public void SetIdCustomer(string id)
        {
            idCustomer = id;
        }
        
        public void SetIdReservasi(string id)
        {
            idReservasi = id;
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

        private void btn_datacostume_Click(object sender, EventArgs e)
        {
            loadform(new InputDataCustomer(this));
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainpanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_lihatkamar_Click(object sender, EventArgs e)
        {
            loadform(new LihatKamar());
        }

        private void btn_kelolareservasi_Click(object sender, EventArgs e)
        {
            loadform(new LihatReservasi());

        }

        private void panelheader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_fasilitas_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            login Login = new login();
            Login.Show();
            this.Hide();
        }

        private void btn_lihatdatacostumer_Click(object sender, EventArgs e)
        {
            loadform(new KelolaDataCostumer(this));

        }

        private void resepsioniss_Load(object sender, EventArgs e)
        {

        }
    }
}
