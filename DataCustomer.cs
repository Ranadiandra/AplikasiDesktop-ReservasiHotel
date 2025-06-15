using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiHotel_CodeStay
{
    public partial class DataCustomer : Form
    {
        resepsioniss mainForm;
        public DataCustomer(resepsioniss form)
        {
            InitializeComponent();
            txt_idcustomer.Enabled = false;
            this.mainForm = form;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjekAkhir_AplikasiHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;

        private void DataCostumer_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("INSERT INTO DataCustomer (NIK, Nama, Alamat, No_HP) VALUES (@NIK, @Nama, @Alamat, @No_HP); SELECT CAST(SCOPE_IDENTITY() AS int);", conn);
            cmd.Parameters.AddWithValue("NIK", txt_nik.Text);
            cmd.Parameters.AddWithValue("Nama", txt_nama.Text);
            cmd.Parameters.AddWithValue("Alamat", txt_alamat.Text);
            cmd.Parameters.AddWithValue("No_HP", txt_nohp.Text);
            conn.Open();
            int newId = (int)cmd.ExecuteScalar();
            conn.Close();
            DialogResult result = MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                mainForm.loadform(new reservasi(newId.ToString(), mainForm));

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_idcustomer.Clear();
            txt_nama.Clear();
            txt_alamat.Clear();
            txt_nohp.Clear();
        }

        private void txt_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nohp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
