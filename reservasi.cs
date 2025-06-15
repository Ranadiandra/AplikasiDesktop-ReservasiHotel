using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiHotel_CodeStay
{
    public partial class reservasi : Form
    {
        private resepsioniss mainForm;
        public reservasi(string idcustomer, resepsioniss formUtama)
        {
            InitializeComponent();
            txt_idreservasi.Enabled = false;
            txt_idcustomer.Enabled = false;
            txt_idcustomer.Text = idcustomer;
            mainForm = formUtama;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjekAkhir_AplikasiHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;

        private void btn_save_Click(object sender, EventArgs e)
        {
            DateTime checkin = dt_checkin.Value;
            DateTime checkout = dt_checkout.Value;

            if (checkout <= checkin)
            {
                MessageBox.Show("Tanggal Checkout harus lebih besar dari Tanggal Checkin.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cmd = new SqlCommand("INSERT INTO Reservasi (Id_Customer, Id_Kamar, Tanggal_Checkin, Tanggal_Checkout, HargaPerHari, PPN, Total_Harga) VALUES (@Id_Customer, @Id_Kamar, @Tanggal_Checkin, @Tanggal_Checkout, @HargaPerHari, @PPN, @Total_Harga); SELECT CAST(SCOPE_IDENTITY() AS int);", conn);
            cmd.Parameters.AddWithValue("Id_Customer", txt_idcustomer.Text);
            cmd.Parameters.AddWithValue("Id_Kamar", txt_idkamar.Text);
            cmd.Parameters.AddWithValue("Tanggal_Checkin", dt_checkin.Text);
            cmd.Parameters.AddWithValue("Tanggal_Checkout", dt_checkout.Text);
            cmd.Parameters.AddWithValue("HargaPerHari", Convert.ToDecimal(txt_hargaperhari.Text));
            cmd.Parameters.AddWithValue("PPN", Convert.ToDecimal(txt_ppn.Text));
            cmd.Parameters.AddWithValue("Total_Harga", Convert.ToDecimal(txt_totalharga.Text));

            conn.Open();
            int newId = (int)cmd.ExecuteScalar();
            txt_idreservasi.Text = newId.ToString();
            cmd = new SqlCommand("UPDATE KelolaKamar SET status = 'TIDAK TERSEDIA' WHERE Id_Kamar = @Id_Kamar", conn);
            cmd.Parameters.AddWithValue("@Id_Kamar", txt_idkamar.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            DialogResult result = MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                mainForm.loadform(new pembayaran(newId.ToString(), txt_idcustomer.Text, mainForm));

            }

        }

        private void reservasi_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void HitungTotal()
        {
            if (txt_hargaperhari.Text == "")
                return;

            DateTime checkin = dt_checkin.Value;
            DateTime checkout = dt_checkout.Value;
            int totalHari = (checkout - checkin).Days;

            if (totalHari <= 0)
            {
                txt_totalharga.Clear();
                txt_ppn.Clear();
                return;
            }

            double hargaPerHari = Convert.ToDouble(txt_hargaperhari.Text);
            double subtotal = hargaPerHari * totalHari;
            double ppn = subtotal * 0.10;
            double total = subtotal + ppn;

            txt_ppn.Text = ppn.ToString("N2");
            txt_totalharga.Text = total.ToString("N2");
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_idkamar.Clear();
            txt_idreservasi.Clear();
            txt_hargaperhari.Clear();
            txt_ppn.Clear();
            txt_totalharga.Clear();
        }

        private void checkin_ValueChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void checkout_ValueChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void txt_idkamar_Leave(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT status, harga FROM KelolaKamar WHERE Id_Kamar = @Id_Kamar", conn);
            cmd.Parameters.AddWithValue("@Id_Kamar", txt_idkamar.Text);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string status = reader["status"].ToString().ToUpper();
                if (status == "TERSEDIA")
                {
                    txt_hargaperhari.Text = reader["harga"].ToString();
                    HitungTotal(); 
                }
                else
                {
                    MessageBox.Show("Kamar tidak tersedia, silakan pilih kamar lain!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_idkamar.Clear();
                    txt_hargaperhari.Clear();
                }
            }
            else
            {
                MessageBox.Show("ID Kamar tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_idkamar.Clear();
                txt_hargaperhari.Clear();
            }

            reader.Close();
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}