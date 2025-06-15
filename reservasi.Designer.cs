namespace AplikasiHotel_CodeStay
{
    partial class reservasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservasi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idcustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_idkamar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_checkin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dt_checkout = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_hargaperhari = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_totalharga = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ppn = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_idreservasi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(460, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(95, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 50);
            this.label1.TabIndex = 34;
            this.label1.Text = "RESERVASI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(-7, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 17);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(366, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 17);
            this.panel2.TabIndex = 36;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BorderRadius = 10;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(17, 505);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(122, 45);
            this.btn_save.TabIndex = 69;
            this.btn_save.Text = "SAVE";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 30);
            this.label2.TabIndex = 70;
            this.label2.Text = "Id Customer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_idcustomer
            // 
            this.txt_idcustomer.BackColor = System.Drawing.Color.Transparent;
            this.txt_idcustomer.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_idcustomer.BorderRadius = 10;
            this.txt_idcustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idcustomer.DefaultText = "";
            this.txt_idcustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_idcustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_idcustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idcustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idcustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idcustomer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idcustomer.ForeColor = System.Drawing.Color.Black;
            this.txt_idcustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idcustomer.Location = new System.Drawing.Point(195, 155);
            this.txt_idcustomer.Name = "txt_idcustomer";
            this.txt_idcustomer.PlaceholderText = "";
            this.txt_idcustomer.SelectedText = "";
            this.txt_idcustomer.Size = new System.Drawing.Size(259, 39);
            this.txt_idcustomer.TabIndex = 71;
            this.txt_idcustomer.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // txt_idkamar
            // 
            this.txt_idkamar.BackColor = System.Drawing.Color.Transparent;
            this.txt_idkamar.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_idkamar.BorderRadius = 10;
            this.txt_idkamar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idkamar.DefaultText = "";
            this.txt_idkamar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_idkamar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_idkamar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idkamar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idkamar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idkamar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idkamar.ForeColor = System.Drawing.Color.Black;
            this.txt_idkamar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idkamar.Location = new System.Drawing.Point(195, 206);
            this.txt_idkamar.Name = "txt_idkamar";
            this.txt_idkamar.PlaceholderText = "";
            this.txt_idkamar.SelectedText = "";
            this.txt_idkamar.Size = new System.Drawing.Size(259, 39);
            this.txt_idkamar.TabIndex = 72;
            this.txt_idkamar.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            this.txt_idkamar.Leave += new System.EventHandler(this.txt_idkamar_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 30);
            this.label3.TabIndex = 73;
            this.label3.Text = "Id Kamar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(12, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 30);
            this.label4.TabIndex = 74;
            this.label4.Text = "Tanggal Checkin";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(12, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 30);
            this.label5.TabIndex = 75;
            this.label5.Text = "Tanggal Checkout";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dt_checkin
            // 
            this.dt_checkin.BorderRadius = 10;
            this.dt_checkin.Checked = true;
            this.dt_checkin.FillColor = System.Drawing.Color.SteelBlue;
            this.dt_checkin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_checkin.ForeColor = System.Drawing.Color.White;
            this.dt_checkin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_checkin.Location = new System.Drawing.Point(195, 253);
            this.dt_checkin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_checkin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_checkin.Name = "dt_checkin";
            this.dt_checkin.Size = new System.Drawing.Size(259, 39);
            this.dt_checkin.TabIndex = 76;
            this.dt_checkin.Value = new System.DateTime(2025, 5, 21, 20, 27, 44, 225);
            this.dt_checkin.ValueChanged += new System.EventHandler(this.checkin_ValueChanged);
            // 
            // dt_checkout
            // 
            this.dt_checkout.BorderRadius = 10;
            this.dt_checkout.Checked = true;
            this.dt_checkout.FillColor = System.Drawing.Color.SteelBlue;
            this.dt_checkout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_checkout.ForeColor = System.Drawing.Color.White;
            this.dt_checkout.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_checkout.Location = new System.Drawing.Point(195, 301);
            this.dt_checkout.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_checkout.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_checkout.Name = "dt_checkout";
            this.dt_checkout.Size = new System.Drawing.Size(259, 39);
            this.dt_checkout.TabIndex = 77;
            this.dt_checkout.Value = new System.DateTime(2025, 5, 21, 20, 27, 44, 225);
            this.dt_checkout.ValueChanged += new System.EventHandler(this.checkout_ValueChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.BorderRadius = 10;
            this.btn_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(173, 505);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(122, 45);
            this.btn_cancel.TabIndex = 78;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(12, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 30);
            this.label7.TabIndex = 79;
            this.label7.Text = "Harga/Hari";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_hargaperhari
            // 
            this.txt_hargaperhari.BackColor = System.Drawing.Color.Transparent;
            this.txt_hargaperhari.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_hargaperhari.BorderRadius = 10;
            this.txt_hargaperhari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_hargaperhari.DefaultText = "";
            this.txt_hargaperhari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_hargaperhari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_hargaperhari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_hargaperhari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_hargaperhari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_hargaperhari.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hargaperhari.ForeColor = System.Drawing.Color.Black;
            this.txt_hargaperhari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_hargaperhari.Location = new System.Drawing.Point(195, 349);
            this.txt_hargaperhari.Name = "txt_hargaperhari";
            this.txt_hargaperhari.PlaceholderText = "";
            this.txt_hargaperhari.SelectedText = "";
            this.txt_hargaperhari.Size = new System.Drawing.Size(259, 39);
            this.txt_hargaperhari.TabIndex = 80;
            this.txt_hargaperhari.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // txt_totalharga
            // 
            this.txt_totalharga.BackColor = System.Drawing.Color.Transparent;
            this.txt_totalharga.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_totalharga.BorderRadius = 10;
            this.txt_totalharga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_totalharga.DefaultText = "";
            this.txt_totalharga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_totalharga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_totalharga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_totalharga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_totalharga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_totalharga.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalharga.ForeColor = System.Drawing.Color.Black;
            this.txt_totalharga.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_totalharga.Location = new System.Drawing.Point(195, 452);
            this.txt_totalharga.Name = "txt_totalharga";
            this.txt_totalharga.PlaceholderText = "";
            this.txt_totalharga.SelectedText = "";
            this.txt_totalharga.Size = new System.Drawing.Size(259, 39);
            this.txt_totalharga.TabIndex = 81;
            this.txt_totalharga.TextChanged += new System.EventHandler(this.guna2TextBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(12, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 30);
            this.label8.TabIndex = 82;
            this.label8.Text = "Total Harga";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_ppn
            // 
            this.txt_ppn.BackColor = System.Drawing.Color.Transparent;
            this.txt_ppn.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_ppn.BorderRadius = 10;
            this.txt_ppn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ppn.DefaultText = "";
            this.txt_ppn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ppn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ppn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ppn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ppn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ppn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ppn.ForeColor = System.Drawing.Color.Black;
            this.txt_ppn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ppn.Location = new System.Drawing.Point(195, 398);
            this.txt_ppn.Name = "txt_ppn";
            this.txt_ppn.PlaceholderText = "";
            this.txt_ppn.SelectedText = "";
            this.txt_ppn.Size = new System.Drawing.Size(259, 39);
            this.txt_ppn.TabIndex = 84;
            this.txt_ppn.TextChanged += new System.EventHandler(this.guna2TextBox6_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(12, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 30);
            this.label10.TabIndex = 83;
            this.label10.Text = "PPN 10%";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_idreservasi
            // 
            this.txt_idreservasi.BackColor = System.Drawing.Color.Transparent;
            this.txt_idreservasi.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_idreservasi.BorderRadius = 10;
            this.txt_idreservasi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idreservasi.DefaultText = "";
            this.txt_idreservasi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_idreservasi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_idreservasi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idreservasi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idreservasi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idreservasi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idreservasi.ForeColor = System.Drawing.Color.Black;
            this.txt_idreservasi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idreservasi.Location = new System.Drawing.Point(195, 108);
            this.txt_idreservasi.Name = "txt_idreservasi";
            this.txt_idreservasi.PlaceholderText = "";
            this.txt_idreservasi.SelectedText = "";
            this.txt_idreservasi.Size = new System.Drawing.Size(259, 39);
            this.txt_idreservasi.TabIndex = 68;
            this.txt_idreservasi.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(12, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 30);
            this.label6.TabIndex = 67;
            this.label6.Text = "Id Reservasi";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // reservasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 598);
            this.Controls.Add(this.txt_ppn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_totalharga);
            this.Controls.Add(this.txt_hargaperhari);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.dt_checkout);
            this.Controls.Add(this.dt_checkin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_idkamar);
            this.Controls.Add(this.txt_idcustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_idreservasi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reservasi";
            this.Text = "reservasi";
            this.Load += new System.EventHandler(this.reservasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_idcustomer;
        private Guna.UI2.WinForms.Guna2TextBox txt_idkamar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_checkin;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_checkout;
        private Guna.UI2.WinForms.Guna2Button btn_cancel;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_hargaperhari;
        private Guna.UI2.WinForms.Guna2TextBox txt_totalharga;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txt_ppn;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txt_idreservasi;
        private System.Windows.Forms.Label label6;
    }
}