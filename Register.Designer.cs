namespace AplikasiHotel_CodeStay
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panelregis = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.cmbrole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.CheckBox();
            this.ipw = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.regis = new System.Windows.Forms.Label();
            this.inamalengkap = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nohp = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelregis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelregis
            // 
            this.panelregis.Controls.Add(this.txt_nohp);
            this.panelregis.Controls.Add(this.label6);
            this.panelregis.Controls.Add(this.btn_cancel);
            this.panelregis.Controls.Add(this.cmbrole);
            this.panelregis.Controls.Add(this.label4);
            this.panelregis.Controls.Add(this.password);
            this.panelregis.Controls.Add(this.ipw);
            this.panelregis.Controls.Add(this.label3);
            this.panelregis.Controls.Add(this.iusername);
            this.panelregis.Controls.Add(this.label2);
            this.panelregis.Controls.Add(this.btn_save);
            this.panelregis.Controls.Add(this.regis);
            this.panelregis.Controls.Add(this.inamalengkap);
            this.panelregis.Controls.Add(this.label1);
            this.panelregis.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelregis.FillColor = System.Drawing.Color.PowderBlue;
            this.panelregis.FillColor2 = System.Drawing.Color.Pink;
            this.panelregis.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.panelregis.Location = new System.Drawing.Point(0, 0);
            this.panelregis.Name = "panelregis";
            this.panelregis.Size = new System.Drawing.Size(415, 521);
            this.panelregis.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.BorderRadius = 10;
            this.btn_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(196, 459);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(145, 45);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // cmbrole
            // 
            this.cmbrole.BackColor = System.Drawing.Color.Transparent;
            this.cmbrole.BorderColor = System.Drawing.Color.Black;
            this.cmbrole.BorderRadius = 10;
            this.cmbrole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbrole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbrole.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbrole.ForeColor = System.Drawing.Color.Black;
            this.cmbrole.ItemHeight = 30;
            this.cmbrole.Items.AddRange(new object[] {
            "RESEPSIONIS"});
            this.cmbrole.Location = new System.Drawing.Point(26, 325);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(352, 36);
            this.cmbrole.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Role:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(249, 287);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(129, 24);
            this.password.TabIndex = 10;
            this.password.Text = "Show Password";
            this.password.UseVisualStyleBackColor = false;
            this.password.CheckedChanged += new System.EventHandler(this.password_CheckedChanged);
            // 
            // ipw
            // 
            this.ipw.BackColor = System.Drawing.Color.Transparent;
            this.ipw.BorderColor = System.Drawing.Color.Black;
            this.ipw.BorderRadius = 10;
            this.ipw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipw.DefaultText = "";
            this.ipw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ipw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ipw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ipw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ipw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ipw.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipw.ForeColor = System.Drawing.Color.Black;
            this.ipw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ipw.Location = new System.Drawing.Point(21, 246);
            this.ipw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ipw.Name = "ipw";
            this.ipw.PasswordChar = '*';
            this.ipw.PlaceholderText = "";
            this.ipw.SelectedText = "";
            this.ipw.Size = new System.Drawing.Size(357, 34);
            this.ipw.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // iusername
            // 
            this.iusername.BackColor = System.Drawing.Color.Transparent;
            this.iusername.BorderColor = System.Drawing.Color.Black;
            this.iusername.BorderRadius = 10;
            this.iusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iusername.DefaultText = "";
            this.iusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.iusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.iusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.iusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.iusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.iusername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iusername.ForeColor = System.Drawing.Color.Black;
            this.iusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.iusername.Location = new System.Drawing.Point(21, 179);
            this.iusername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iusername.Name = "iusername";
            this.iusername.PlaceholderText = "";
            this.iusername.SelectedText = "";
            this.iusername.Size = new System.Drawing.Size(357, 34);
            this.iusername.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username:";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BorderRadius = 10;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(23, 459);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(145, 45);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "SAVE";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // regis
            // 
            this.regis.AutoSize = true;
            this.regis.BackColor = System.Drawing.Color.Transparent;
            this.regis.Font = new System.Drawing.Font("Mongolian Baiti", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regis.ForeColor = System.Drawing.Color.White;
            this.regis.Location = new System.Drawing.Point(3, 25);
            this.regis.Name = "regis";
            this.regis.Size = new System.Drawing.Size(417, 56);
            this.regis.TabIndex = 1;
            this.regis.Text = "REGISTRATION";
            // 
            // inamalengkap
            // 
            this.inamalengkap.BackColor = System.Drawing.Color.Transparent;
            this.inamalengkap.BorderColor = System.Drawing.Color.Black;
            this.inamalengkap.BorderRadius = 10;
            this.inamalengkap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inamalengkap.DefaultText = "";
            this.inamalengkap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inamalengkap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inamalengkap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inamalengkap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inamalengkap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inamalengkap.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inamalengkap.ForeColor = System.Drawing.Color.Black;
            this.inamalengkap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inamalengkap.Location = new System.Drawing.Point(21, 110);
            this.inamalengkap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inamalengkap.Name = "inamalengkap";
            this.inamalengkap.PlaceholderText = "";
            this.inamalengkap.SelectedText = "";
            this.inamalengkap.Size = new System.Drawing.Size(357, 36);
            this.inamalengkap.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nama Lengkap:";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(473, 130);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(259, 231);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "No HP";
            // 
            // txt_nohp
            // 
            this.txt_nohp.BackColor = System.Drawing.Color.Transparent;
            this.txt_nohp.BorderColor = System.Drawing.Color.Black;
            this.txt_nohp.BorderRadius = 10;
            this.txt_nohp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nohp.DefaultText = "";
            this.txt_nohp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nohp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nohp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nohp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nohp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nohp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nohp.ForeColor = System.Drawing.Color.Black;
            this.txt_nohp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nohp.Location = new System.Drawing.Point(21, 393);
            this.txt_nohp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nohp.Name = "txt_nohp";
            this.txt_nohp.PlaceholderText = "";
            this.txt_nohp.SelectedText = "";
            this.txt_nohp.Size = new System.Drawing.Size(357, 34);
            this.txt_nohp.TabIndex = 17;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 521);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.panelregis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panelregis.ResumeLayout(false);
            this.panelregis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelregis;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label regis;
        private Guna.UI2.WinForms.Guna2TextBox inamalengkap;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbrole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox password;
        private Guna.UI2.WinForms.Guna2TextBox ipw;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox iusername;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_cancel;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_nohp;
    }
}