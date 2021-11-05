
namespace spor_kayit_sistemi
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.button_kisisel = new System.Windows.Forms.Button();
            this.button_iletisim = new System.Windows.Forms.Button();
            this.button_ödeme = new System.Windows.Forms.Button();
            this.button_kayitson = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.button_kayitson);
            this.panelMenu.Controls.Add(this.button_ödeme);
            this.panelMenu.Controls.Add(this.button_iletisim);
            this.panelMenu.Controls.Add(this.button_kisisel);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(177, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(177, 92);
            this.panelLogo.TabIndex = 1;
            // 
            // button_kisisel
            // 
            this.button_kisisel.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_kisisel.FlatAppearance.BorderSize = 0;
            this.button_kisisel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kisisel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kisisel.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_kisisel.Location = new System.Drawing.Point(0, 92);
            this.button_kisisel.Name = "button_kisisel";
            this.button_kisisel.Size = new System.Drawing.Size(177, 46);
            this.button_kisisel.TabIndex = 1;
            this.button_kisisel.Text = "Kişisel Bilgiler";
            this.button_kisisel.UseVisualStyleBackColor = true;
            this.button_kisisel.Click += new System.EventHandler(this.button_kisisel_Click);
            // 
            // button_iletisim
            // 
            this.button_iletisim.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_iletisim.FlatAppearance.BorderSize = 0;
            this.button_iletisim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_iletisim.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_iletisim.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_iletisim.Location = new System.Drawing.Point(0, 138);
            this.button_iletisim.Name = "button_iletisim";
            this.button_iletisim.Size = new System.Drawing.Size(177, 46);
            this.button_iletisim.TabIndex = 2;
            this.button_iletisim.Text = "İletişim Bilgileri";
            this.button_iletisim.UseVisualStyleBackColor = true;
            this.button_iletisim.Click += new System.EventHandler(this.button_iletisim_Click);
            // 
            // button_ödeme
            // 
            this.button_ödeme.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ödeme.FlatAppearance.BorderSize = 0;
            this.button_ödeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ödeme.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ödeme.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_ödeme.Location = new System.Drawing.Point(0, 184);
            this.button_ödeme.Name = "button_ödeme";
            this.button_ödeme.Size = new System.Drawing.Size(177, 46);
            this.button_ödeme.TabIndex = 3;
            this.button_ödeme.Text = "Ödeme İşlemleri";
            this.button_ödeme.UseVisualStyleBackColor = true;
            this.button_ödeme.Click += new System.EventHandler(this.button_ödeme_Click);
            // 
            // button_kayitson
            // 
            this.button_kayitson.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_kayitson.FlatAppearance.BorderSize = 0;
            this.button_kayitson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kayitson.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kayitson.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_kayitson.Location = new System.Drawing.Point(0, 230);
            this.button_kayitson.Name = "button_kayitson";
            this.button_kayitson.Size = new System.Drawing.Size(177, 46);
            this.button_kayitson.TabIndex = 4;
            this.button_kayitson.Text = "Kayıt Tamamla";
            this.button_kayitson.UseVisualStyleBackColor = true;
            this.button_kayitson.Click += new System.EventHandler(this.button_kayitson_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(177, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(623, 54);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(177, 54);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(623, 15);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(177, 69);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(623, 381);
            this.panelDesktop.TabIndex = 3;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::spor_kayit_sistemi.Properties.Resources.logo;
            this.btnHome.Location = new System.Drawing.Point(34, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(112, 64);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::spor_kayit_sistemi.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(252, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Location = new System.Drawing.Point(594, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button_kayitson;
        private System.Windows.Forms.Button button_ödeme;
        private System.Windows.Forms.Button button_iletisim;
        private System.Windows.Forms.Button button_kisisel;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
    }
}

