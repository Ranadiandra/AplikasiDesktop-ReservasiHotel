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
    public partial class pembayaran : Form
    {
        resepsioniss mainForm;
        private string idCustomer;
        private string idReservasi; 
        public pembayaran(string idReservasi, string idCustomer, resepsioniss mainForm)
        {
            InitializeComponent();
            txt_idreservasi.Enabled = false;
            txt_idcustomer.Enabled = false;
            txt_totalbayar.Enabled = false;
            txt_kembalian.Enabled = false;
            
            this.idCustomer = idCustomer;
            this.idReservasi = idReservasi;
            txt_idreservasi.Text = idReservasi;
            txt_idcustomer.Text = idCustomer;
            this.mainForm = mainForm;
        }
        private decimal TotalHargaKamar()
        {
            decimal HargaKamar = 0;
            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjekAkhir_AplikasiHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                string query = "SELECT Total_Harga from Reservasi WHERE Id_Reservasi = @Id_Reservasi";
                SqlCommand  cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id_Reservasi", txt_idreservasi.Text);
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null) HargaKamar = Convert.ToDecimal(result);
            }
            return HargaKamar;
        }

        private decimal TotalHargaRestoran()
        {
            decimal HargaRestoran = 0;
            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ReservasiHotel;Integrated Security=True;"))

            {
                string query = "SELECT SUM (Total_Bayar) FROM Pesanan WHERE Id_Customer = @Id_Customer";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id_Customer", idCustomer);
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value) HargaRestoran = Convert.ToDecimal(result);
            }
            return HargaRestoran;
        }
        
        private void pembayaran_Load(object sender, EventArgs e)
        {
            decimal total = TotalHargaKamar() + TotalHargaRestoran();
            txt_totalbayar.Text = total.ToString(); 
        }


        private void id_fasilitas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            mainForm.loadform(new Resto(idCustomer, txt_idreservasi.Text, mainForm));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_no_Click(object sender, EventArgs e)
        {

        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            decimal TotalBayar = decimal.Parse(txt_totalbayar.Text);
            decimal UangBayar = decimal.Parse(txt_uangbayar.Text);

            if (UangBayar < TotalBayar)
            {
                MessageBox.Show("Maaf Uang Anda Tidak Cukup, Transaksi Gagal!!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                decimal Kembalian = UangBayar - TotalBayar;
                txt_kembalian.Text = Kembalian.ToString();

                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjekAkhir_AplikasiHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))

                {

                    SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Transaksi (Id_Customer, Id_Reservasi, Metode_Pembayaran, Total_Bayar, Uang_Bayar, Kembalian) 
                    VALUES (@Id_Customer, @Id_reservasi, @Metode_Pembayaran, @Total_Bayar, @Uang_Bayar, @Kembalian);
                    SELECT SCOPE_IDENTITY();", conn);
                    cmd.Parameters.AddWithValue("@Id_Customer", txt_idcustomer.Text);
                    cmd.Parameters.AddWithValue("@Id_Reservasi", txt_idreservasi.Text);
                    cmd.Parameters.AddWithValue("@Metode_Pembayaran", MetodePembayaran()); 
                    cmd.Parameters.AddWithValue("@Total_Bayar", TotalBayar);
                    cmd.Parameters.AddWithValue("@Uang_Bayar", UangBayar);
                    cmd.Parameters.AddWithValue("@Kembalian", Kembalian);

                    try
                    {
                        conn.Open();
                        var idTransaksiBaru = cmd.ExecuteScalar()?.ToString();

                        conn.Close();
                       

                        MessageBox.Show("Pembayaran Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainForm.loadform(new DetailTransaksi(idTransaksiBaru));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi Kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    
         private string MetodePembayaran()
        {
            if (tunai.Checked)
                return "TUNAI";
            else if (nontunai.Checked)
                return "NON TUNAI";
            else
                return "TIDAK DIKETAHUI";
        }
        private void txt_kembalian_TextChanged(object sender, EventArgs e)
        {

        }

        private void tunai_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void nontunai_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_uangbayar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_totalbayar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_no_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
