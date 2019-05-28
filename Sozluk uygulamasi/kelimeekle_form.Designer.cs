namespace yazilim_yapimi
{
    partial class kelimeekle_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kelimeekle_form));
            this.türkçeLabel = new System.Windows.Forms.Label();
            this.ingilizceLabel = new System.Windows.Forms.Label();
            this.turkceekle_textbox = new System.Windows.Forms.TextBox();
            this.ingekle_textbox = new System.Windows.Forms.TextBox();
            this.kelimeekle_panel = new System.Windows.Forms.Panel();
            this.kelimeEkleResmi = new System.Windows.Forms.PictureBox();
            this.kelimeeklegeribtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.eklemekGroupBox = new System.Windows.Forms.GroupBox();
            this.kelimeekle_button = new System.Windows.Forms.Button();
            this.kelimeekle_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeEkleResmi)).BeginInit();
            this.eklemekGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // türkçeLabel
            // 
            this.türkçeLabel.AutoSize = true;
            this.türkçeLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.türkçeLabel.Location = new System.Drawing.Point(18, 91);
            this.türkçeLabel.Name = "türkçeLabel";
            this.türkçeLabel.Size = new System.Drawing.Size(236, 24);
            this.türkçeLabel.TabIndex = 0;
            this.türkçeLabel.Text = "KELİMENİN TÜRKÇESİ :";
            
            // 
            // ingilizceLabel
            // 
            this.ingilizceLabel.AutoSize = true;
            this.ingilizceLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ingilizceLabel.Location = new System.Drawing.Point(18, 172);
            this.ingilizceLabel.Name = "ingilizceLabel";
            this.ingilizceLabel.Size = new System.Drawing.Size(249, 24);
            this.ingilizceLabel.TabIndex = 1;
            this.ingilizceLabel.Text = "KELİMENİN İNGİLİZCESİ :";
            // 
            // turkceekle_textbox
            // 
            this.turkceekle_textbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turkceekle_textbox.Location = new System.Drawing.Point(302, 80);
            this.turkceekle_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.turkceekle_textbox.Name = "turkceekle_textbox";
            this.turkceekle_textbox.Size = new System.Drawing.Size(182, 35);
            this.turkceekle_textbox.TabIndex = 2;
            // 
            // ingekle_textbox
            // 
            this.ingekle_textbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ingekle_textbox.Location = new System.Drawing.Point(302, 161);
            this.ingekle_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ingekle_textbox.Name = "ingekle_textbox";
            this.ingekle_textbox.Size = new System.Drawing.Size(182, 35);
            this.ingekle_textbox.TabIndex = 3;
            // 
            // kelimeekle_panel
            // 
            this.kelimeekle_panel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.kelimeekle_panel.Controls.Add(this.kelimeEkleResmi);
            this.kelimeekle_panel.Controls.Add(this.kelimeeklegeribtn);
            this.kelimeekle_panel.Controls.Add(this.label3);
            this.kelimeekle_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.kelimeekle_panel.Location = new System.Drawing.Point(0, 0);
            this.kelimeekle_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kelimeekle_panel.Name = "kelimeekle_panel";
            this.kelimeekle_panel.Size = new System.Drawing.Size(818, 115);
            this.kelimeekle_panel.TabIndex = 4;
            // 
            // kelimeEkleResmi
            // 
            this.kelimeEkleResmi.Image = ((System.Drawing.Image)(resources.GetObject("kelimeEkleResmi.Image")));
            this.kelimeEkleResmi.Location = new System.Drawing.Point(47, 12);
            this.kelimeEkleResmi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kelimeEkleResmi.Name = "kelimeEkleResmi";
            this.kelimeEkleResmi.Size = new System.Drawing.Size(100, 82);
            this.kelimeEkleResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kelimeEkleResmi.TabIndex = 6;
            this.kelimeEkleResmi.TabStop = false;
            // 
            // kelimeeklegeribtn
            // 
            this.kelimeeklegeribtn.Location = new System.Drawing.Point(698, 12);
            this.kelimeeklegeribtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kelimeeklegeribtn.Name = "kelimeeklegeribtn";
            this.kelimeeklegeribtn.Size = new System.Drawing.Size(111, 50);
            this.kelimeeklegeribtn.TabIndex = 6;
            this.kelimeeklegeribtn.Text = "GERİ DÖN";
            this.kelimeeklegeribtn.UseVisualStyleBackColor = true;
            this.kelimeeklegeribtn.Click += new System.EventHandler(this.kelimeeklegeri_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(269, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "KELİME EKLEME";
            
            // 
            // eklemekGroupBox
            // 
            this.eklemekGroupBox.Controls.Add(this.kelimeekle_button);
            this.eklemekGroupBox.Controls.Add(this.ingilizceLabel);
            this.eklemekGroupBox.Controls.Add(this.türkçeLabel);
            this.eklemekGroupBox.Controls.Add(this.ingekle_textbox);
            this.eklemekGroupBox.Controls.Add(this.turkceekle_textbox);
            this.eklemekGroupBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eklemekGroupBox.Location = new System.Drawing.Point(160, 208);
            this.eklemekGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eklemekGroupBox.Name = "eklemekGroupBox";
            this.eklemekGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eklemekGroupBox.Size = new System.Drawing.Size(518, 346);
            this.eklemekGroupBox.TabIndex = 5;
            this.eklemekGroupBox.TabStop = false;
            this.eklemekGroupBox.Text = "EKLENECEK";
            // 
            // kelimeekle_button
            // 
            this.kelimeekle_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.kelimeekle_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kelimeekle_button.Location = new System.Drawing.Point(364, 259);
            this.kelimeekle_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kelimeekle_button.Name = "kelimeekle_button";
            this.kelimeekle_button.Size = new System.Drawing.Size(118, 52);
            this.kelimeekle_button.TabIndex = 4;
            this.kelimeekle_button.Text = "EKLE";
            this.kelimeekle_button.UseVisualStyleBackColor = false;
            this.kelimeekle_button.Click += new System.EventHandler(this.kelimeekle_button_Click);
            // 
            // kelimeekle_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(818, 644);
            this.Controls.Add(this.eklemekGroupBox);
            this.Controls.Add(this.kelimeekle_panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "kelimeekle_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KELİME ÖĞREN";
            this.Load += new System.EventHandler(this.kelimeekle_form_Load);
            this.kelimeekle_panel.ResumeLayout(false);
            this.kelimeekle_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeEkleResmi)).EndInit();
            this.eklemekGroupBox.ResumeLayout(false);
            this.eklemekGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label türkçeLabel;
        private System.Windows.Forms.Label ingilizceLabel;
        private System.Windows.Forms.TextBox turkceekle_textbox;
        private System.Windows.Forms.TextBox ingekle_textbox;
        private System.Windows.Forms.Panel kelimeekle_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox eklemekGroupBox;
        private System.Windows.Forms.Button kelimeekle_button;
        private System.Windows.Forms.Button kelimeeklegeribtn;
        private System.Windows.Forms.PictureBox kelimeEkleResmi;
    }
}