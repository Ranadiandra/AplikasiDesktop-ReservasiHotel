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
    public partial class DetailTransaksi : Form
    {
        private string idTransaksi;
        public DetailTransaksi(string idTransaksi)
        {
            InitializeComponent();
            this.idTransaksi = idTransaksi;
        }
       
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DetailTransaksi_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjekAkhir_AplikasiHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                string query = @"
                    SELECT 
                    T.Id_Transaksi,
                    T.Metode_Pembayaran,
                    T.Total_Bayar AS Total_Transaksi,
                    T.Uang_Bayar,
                    T.Kembalian,

                    C.Id_Customer,
                    C.NIK,
                    C.Nama,
                    C.No_HP,
                    C.Alamat,

                    R.Id_Reservasi,
                    R.Tanggal_Checkin,
                    R.Tanggal_Checkout,
                    R.HargaPerHari,

                    K.nokamar,
                    K.tipekamar,
                    K.fasilitas,

                    P.Id_Pesanan,
                    M.Nama_Menu,
                    M.Kategori,
                    M.Harga AS Harga_Menu,
                    P.Total_harga AS Total_Harga_Menu,
                    P.PPN,
                    P.Total_Bayar AS Total_Pesanan

                FROM Transaksi T
                LEFT JOIN DataCustomer C ON T.Id_Customer = C.Id_Customer
                LEFT JOIN Reservasi R ON T.Id_Reservasi = R.Id_Reservasi
                LEFT JOIN KelolaKamar K ON R.Id_Kamar = K.Id_Kamar
                LEFT JOIN Pesanan P ON P.Id_Customer = C.Id_Customer -- <= Diperbaiki
                LEFT JOIN Menu M ON P.Id_Menu = M.Id_Menu
                WHERE T.Id_Transaksi = @Id_Transaksi";



                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id_Transaksi", idTransaksi); 
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //ID
                    txt_idcustomer.Text = reader["Id_Customer"]?.ToString();
                    txt_idreservasi.Text = reader["Id_Reservasi"]?.ToString();
                    txt_idpesanan.Text = reader["Id_Pesanan"]?.ToString();
                    txt_idtransaksi.Text = reader["Id_Transaksi"]?.ToString();

                    //DataCustomer
                    txt_nama.Text = reader["Nama"]?.ToString();
                    txt_nik.Text = reader["NIK"]?.ToString();
                    txt_nohp.Text = reader["No_HP"]?.ToString();
                    txt_alamat.Text = reader["Alamat"]?.ToString();

                    //Reservasi
                    DateTime checkin = reader.GetDateTime(reader.GetOrdinal("Tanggal_Checkin"));
                    txt_checkin.Text = checkin.ToString("dd/MM/yyyy");

                    DateTime checkout = reader.GetDateTime(reader.GetOrdinal("Tanggal_Checkout"));
                    txt_checkout.Text = checkout.ToString("dd/MM/yyyy");

                    txt_hargaperhari.Text = reader["HargaPerHari"]?.ToString();

                    //Kamar
                    txt_tipekamar.Text = reader["tipekamar"]?.ToString();
                    txt_nokamar.Text = reader["nokamar"]?.ToString();
                    txt_fasilitas.Text = reader["fasilitas"]?.ToString();
                    

                    //Resto
                    txt_namamenu.Text = reader["Nama_Menu"]?.ToString();
                    txt_kategori.Text = reader["Kategori"]?.ToString();
                    txt_totalhargamenu.Text = reader["Total_Harga_Menu"]?.ToString();
                    txt_ppn.Text = reader["PPN"]?.ToString();
                    txt_totalbayarmenu.Text = reader["Total_Pesanan"]?.ToString();

                    //Transaksi
                    txt_metodepembayaran.Text = reader["Metode_Pembayaran"]?.ToString();
                    txt_totalbayar.Text = reader["Total_Transaksi"]?.ToString();
                    txt_uangbayar.Text = reader["Uang_Bayar"]?.ToString();
                    txt_kembalian.Text = reader["Kembalian"]?.ToString();
                }
                reader.Close();
            }
        }

        private void txt_idkamar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_idtransaksi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_hargaperhari_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_idreservasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_totalharga_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_fasilitas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_hargafasilitas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_metodepembayaran_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_totalbayar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_uangbayar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_kembalian_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_totalharga_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
