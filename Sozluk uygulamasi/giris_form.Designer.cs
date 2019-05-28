namespace yazilim_yapimi
{
    partial class giris_form
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris_form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hAKKIMIZDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muhammetEnesDeniz172803035ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.berkinErgürbüz1728030ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giris_groupbox = new System.Windows.Forms.GroupBox();
            this.giris_button = new System.Windows.Forms.Button();
            this.sifre_textbox = new System.Windows.Forms.TextBox();
            this.eposta_textbox = new System.Windows.Forms.TextBox();
            this.giriseposta_label = new System.Windows.Forms.Label();
            this.girissifre_label = new System.Windows.Forms.Label();
            this.hosgeldiniz_label = new System.Windows.Forms.Label();
            this.giris_picturebox = new System.Windows.Forms.PictureBox();
            this.giris_panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.giris_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giris_picturebox)).BeginInit();
            this.giris_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hAKKIMIZDAToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "giris_menustrip";
            // 
            // hAKKIMIZDAToolStripMenuItem
            // 
            this.hAKKIMIZDAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muhammetEnesDeniz172803035ToolStripMenuItem,
            this.berkinErgürbüz1728030ToolStripMenuItem});
            this.hAKKIMIZDAToolStripMenuItem.Name = "hAKKIMIZDAToolStripMenuItem";
            this.hAKKIMIZDAToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.hAKKIMIZDAToolStripMenuItem.Text = "HAKKIMIZDA";
            // 
            // muhammetEnesDeniz172803035ToolStripMenuItem
            // 
            this.muhammetEnesDeniz172803035ToolStripMenuItem.Name = "muhammetEnesDeniz172803035ToolStripMenuItem";
            this.muhammetEnesDeniz172803035ToolStripMenuItem.Size = new System.Drawing.Size(375, 30);
            this.muhammetEnesDeniz172803035ToolStripMenuItem.Text = "Muhammet Enes Deniz-172803035";
            // 
            // berkinErgürbüz1728030ToolStripMenuItem
            // 
            this.berkinErgürbüz1728030ToolStripMenuItem.Name = "berkinErgürbüz1728030ToolStripMenuItem";
            this.berkinErgürbüz1728030ToolStripMenuItem.Size = new System.Drawing.Size(375, 30);
            this.berkinErgürbüz1728030ToolStripMenuItem.Text = "Berkin Ergürbüz-172803013";
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // giris_groupbox
            // 
            this.giris_groupbox.Controls.Add(this.giris_button);
            this.giris_groupbox.Controls.Add(this.sifre_textbox);
            this.giris_groupbox.Controls.Add(this.eposta_textbox);
            this.giris_groupbox.Controls.Add(this.giriseposta_label);
            this.giris_groupbox.Controls.Add(this.girissifre_label);
            this.giris_groupbox.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_groupbox.Location = new System.Drawing.Point(12, 198);
            this.giris_groupbox.Name = "giris_groupbox";
            this.giris_groupbox.Size = new System.Drawing.Size(547, 290);
            this.giris_groupbox.TabIndex = 4;
            this.giris_groupbox.TabStop = false;
            this.giris_groupbox.Text = "LÜTFEN GİRİŞ YAPINIZ";
            // 
            // giris_button
            // 
            this.giris_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.giris_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.giris_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giris_button.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_button.Image = ((System.Drawing.Image)(resources.GetObject("giris_button.Image")));
            this.giris_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.giris_button.Location = new System.Drawing.Point(318, 204);
            this.giris_button.Name = "giris_button";
            this.giris_button.Size = new System.Drawing.Size(137, 74);
            this.giris_button.TabIndex = 9;
            this.giris_button.Text = "GİRİŞ";
            this.giris_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.giris_button.UseVisualStyleBackColor = false;
            this.giris_button.Click += new System.EventHandler(this.giris_button_Click);
            // 
            // sifre_textbox
            // 
            this.sifre_textbox.Location = new System.Drawing.Point(208, 160);
            this.sifre_textbox.MaxLength = 11;
            this.sifre_textbox.Name = "sifre_textbox";
            this.sifre_textbox.Size = new System.Drawing.Size(247, 30);
            this.sifre_textbox.TabIndex = 8;
            this.sifre_textbox.UseSystemPasswordChar = true;
            // 
            // eposta_textbox
            // 
            this.eposta_textbox.Location = new System.Drawing.Point(208, 75);
            this.eposta_textbox.MaxLength = 11;
            this.eposta_textbox.Name = "eposta_textbox";
            this.eposta_textbox.Size = new System.Drawing.Size(247, 30);
            this.eposta_textbox.TabIndex = 7;
            // 
            // giriseposta_label
            // 
            this.giriseposta_label.AutoSize = true;
            this.giriseposta_label.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giriseposta_label.Location = new System.Drawing.Point(6, 77);
            this.giriseposta_label.Name = "giriseposta_label";
            this.giriseposta_label.Size = new System.Drawing.Size(171, 28);
            this.giriseposta_label.TabIndex = 5;
            this.giriseposta_label.Text = "Kullanıcı Adı :";
            // 
            // girissifre_label
            // 
            this.girissifre_label.AutoSize = true;
            this.girissifre_label.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girissifre_label.Location = new System.Drawing.Point(97, 160);
            this.girissifre_label.Name = "girissifre_label";
            this.girissifre_label.Size = new System.Drawing.Size(80, 28);
            this.girissifre_label.TabIndex = 6;
            this.girissifre_label.Text = "Şifre :";
            // 
            // hosgeldiniz_label
            // 
            this.hosgeldiniz_label.AutoSize = true;
            this.hosgeldiniz_label.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hosgeldiniz_label.Location = new System.Drawing.Point(236, 17);
            this.hosgeldiniz_label.Name = "hosgeldiniz_label";
            this.hosgeldiniz_label.Size = new System.Drawing.Size(323, 71);
            this.hosgeldiniz_label.TabIndex = 6;
            this.hosgeldiniz_label.Text = "HOŞGELDİNİZ";
            // 
            // giris_picturebox
            // 
            this.giris_picturebox.Image = ((System.Drawing.Image)(resources.GetObject("giris_picturebox.Image")));
            this.giris_picturebox.Location = new System.Drawing.Point(561, 169);
            this.giris_picturebox.Name = "giris_picturebox";
            this.giris_picturebox.Size = new System.Drawing.Size(258, 449);
            this.giris_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.giris_picturebox.TabIndex = 5;
            this.giris_picturebox.TabStop = false;
            // 
            // giris_panel
            // 
            this.giris_panel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.giris_panel.Controls.Add(this.hosgeldiniz_label);
            this.giris_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.giris_panel.Location = new System.Drawing.Point(0, 33);
            this.giris_panel.Name = "giris_panel";
            this.giris_panel.Size = new System.Drawing.Size(840, 100);
            this.giris_panel.TabIndex = 7;
            // 
            // giris_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(840, 700);
            this.Controls.Add(this.giris_panel);
            this.Controls.Add(this.giris_picturebox);
            this.Controls.Add(this.giris_groupbox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "giris_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KELİME ÖĞREN";
            this.Load += new System.EventHandler(this.giris_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.giris_groupbox.ResumeLayout(false);
            this.giris_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giris_picturebox)).EndInit();
            this.giris_panel.ResumeLayout(false);
            this.giris_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hAKKIMIZDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muhammetEnesDeniz172803035ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem berkinErgürbüz1728030ToolStripMenuItem;
        private System.Windows.Forms.GroupBox giris_groupbox;
        private System.Windows.Forms.TextBox sifre_textbox;
        private System.Windows.Forms.TextBox eposta_textbox;
        private System.Windows.Forms.Label giriseposta_label;
        private System.Windows.Forms.Label girissifre_label;
        private System.Windows.Forms.Button giris_button;
        private System.Windows.Forms.PictureBox giris_picturebox;
        private System.Windows.Forms.Label hosgeldiniz_label;
        private System.Windows.Forms.Panel giris_panel;
    }
}

