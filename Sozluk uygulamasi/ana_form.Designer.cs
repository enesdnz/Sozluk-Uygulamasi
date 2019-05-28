namespace yazilim_yapimi
{
    partial class ana_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ana_form));
            this.test_button = new System.Windows.Forms.Button();
            this.kelimeogren_button = new System.Windows.Forms.Button();
            this.anaform_panel = new System.Windows.Forms.Panel();
            this.kelimeeklebtn = new System.Windows.Forms.Button();
            this.istatistikbtn = new System.Windows.Forms.Button();
            this.oturumukapat_button = new System.Windows.Forms.Button();
            this.baslıkLabel = new System.Windows.Forms.Label();
            this.testResmi = new System.Windows.Forms.PictureBox();
            this.kelimeOgrenResmi = new System.Windows.Forms.PictureBox();
            this.anaform_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testResmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeOgrenResmi)).BeginInit();
            this.SuspendLayout();
            // 
            // test_button
            // 
            this.test_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.test_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.test_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.test_button.Location = new System.Drawing.Point(297, 442);
            this.test_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(207, 72);
            this.test_button.TabIndex = 8;
            this.test_button.Text = "HEMEN TEST ET !";
            this.test_button.UseVisualStyleBackColor = false;
            this.test_button.Click += new System.EventHandler(this.test_button_Click);
            // 
            // kelimeogren_button
            // 
            this.kelimeogren_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.kelimeogren_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kelimeogren_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kelimeogren_button.Location = new System.Drawing.Point(297, 201);
            this.kelimeogren_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kelimeogren_button.Name = "kelimeogren_button";
            this.kelimeogren_button.Size = new System.Drawing.Size(207, 72);
            this.kelimeogren_button.TabIndex = 7;
            this.kelimeogren_button.Text = "KELİME ÖĞREN";
            this.kelimeogren_button.UseVisualStyleBackColor = false;
            this.kelimeogren_button.Click += new System.EventHandler(this.kelimeogren_button_Click);
            // 
            // anaform_panel
            // 
            this.anaform_panel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.anaform_panel.Controls.Add(this.kelimeeklebtn);
            this.anaform_panel.Controls.Add(this.istatistikbtn);
            this.anaform_panel.Controls.Add(this.oturumukapat_button);
            this.anaform_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.anaform_panel.Location = new System.Drawing.Point(0, 0);
            this.anaform_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.anaform_panel.Name = "anaform_panel";
            this.anaform_panel.Size = new System.Drawing.Size(200, 644);
            this.anaform_panel.TabIndex = 12;
            // 
            // kelimeeklebtn
            // 
            this.kelimeeklebtn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kelimeeklebtn.Image = ((System.Drawing.Image)(resources.GetObject("kelimeeklebtn.Image")));
            this.kelimeeklebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kelimeeklebtn.Location = new System.Drawing.Point(0, 162);
            this.kelimeeklebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kelimeeklebtn.Name = "kelimeeklebtn";
            this.kelimeeklebtn.Size = new System.Drawing.Size(200, 62);
            this.kelimeeklebtn.TabIndex = 14;
            this.kelimeeklebtn.Text = "KELİME EKLE";
            this.kelimeeklebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kelimeeklebtn.UseVisualStyleBackColor = true;
            this.kelimeeklebtn.Click += new System.EventHandler(this.kelimeeklebtn_Click);
            // 
            // istatistikbtn
            // 
            this.istatistikbtn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.istatistikbtn.Image = ((System.Drawing.Image)(resources.GetObject("istatistikbtn.Image")));
            this.istatistikbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.istatistikbtn.Location = new System.Drawing.Point(0, 250);
            this.istatistikbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.istatistikbtn.Name = "istatistikbtn";
            this.istatistikbtn.Size = new System.Drawing.Size(200, 62);
            this.istatistikbtn.TabIndex = 14;
            this.istatistikbtn.Text = "İSTATİSTİKLER";
            this.istatistikbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.istatistikbtn.UseVisualStyleBackColor = true;
            this.istatistikbtn.Click += new System.EventHandler(this.istatistik_button_Click);
            // 
            // oturumukapat_button
            // 
            this.oturumukapat_button.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oturumukapat_button.Image = ((System.Drawing.Image)(resources.GetObject("oturumukapat_button.Image")));
            this.oturumukapat_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oturumukapat_button.Location = new System.Drawing.Point(0, 544);
            this.oturumukapat_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oturumukapat_button.Name = "oturumukapat_button";
            this.oturumukapat_button.Size = new System.Drawing.Size(200, 66);
            this.oturumukapat_button.TabIndex = 11;
            this.oturumukapat_button.Text = "OTURUMU KAPAT";
            this.oturumukapat_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.oturumukapat_button.UseVisualStyleBackColor = true;
            this.oturumukapat_button.Click += new System.EventHandler(this.oturumukapat_button_Click);
            // 
            // baslıkLabel
            // 
            this.baslıkLabel.AutoSize = true;
            this.baslıkLabel.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslıkLabel.Location = new System.Drawing.Point(251, 55);
            this.baslıkLabel.Name = "baslıkLabel";
            this.baslıkLabel.Size = new System.Drawing.Size(519, 64);
            this.baslıkLabel.TabIndex = 13;
            this.baslıkLabel.Text = "NE YAPMAK İSTERSİNİZ ?";
            // 
            // testResmi
            // 
            this.testResmi.Image = ((System.Drawing.Image)(resources.GetObject("testResmi.Image")));
            this.testResmi.Location = new System.Drawing.Point(541, 392);
            this.testResmi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testResmi.Name = "testResmi";
            this.testResmi.Size = new System.Drawing.Size(170, 168);
            this.testResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.testResmi.TabIndex = 10;
            this.testResmi.TabStop = false;
            // 
            // kelimeOgrenResmi
            // 
            this.kelimeOgrenResmi.Image = ((System.Drawing.Image)(resources.GetObject("kelimeOgrenResmi.Image")));
            this.kelimeOgrenResmi.Location = new System.Drawing.Point(541, 146);
            this.kelimeOgrenResmi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kelimeOgrenResmi.Name = "kelimeOgrenResmi";
            this.kelimeOgrenResmi.Size = new System.Drawing.Size(170, 168);
            this.kelimeOgrenResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kelimeOgrenResmi.TabIndex = 9;
            this.kelimeOgrenResmi.TabStop = false;
            // 
            // ana_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(818, 644);
            this.Controls.Add(this.baslıkLabel);
            this.Controls.Add(this.anaform_panel);
            this.Controls.Add(this.testResmi);
            this.Controls.Add(this.kelimeOgrenResmi);
            this.Controls.Add(this.test_button);
            this.Controls.Add(this.kelimeogren_button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ana_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KELİME ÖĞREN";
            this.Load += new System.EventHandler(this.ana_form_Load);
            this.anaform_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testResmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeOgrenResmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oturumukapat_button;
        private System.Windows.Forms.PictureBox testResmi;
        private System.Windows.Forms.PictureBox kelimeOgrenResmi;
        private System.Windows.Forms.Button test_button;
        private System.Windows.Forms.Button kelimeogren_button;
        private System.Windows.Forms.Panel anaform_panel;
        private System.Windows.Forms.Label baslıkLabel;
        private System.Windows.Forms.Button istatistikbtn;
        private System.Windows.Forms.Button kelimeeklebtn;
    }
}