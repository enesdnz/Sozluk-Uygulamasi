namespace yazilim_yapimi
{
    partial class istatistik_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(istatistik_form));
            this.istatistik_panel = new System.Windows.Forms.Panel();
            this.istatistikResmi = new System.Windows.Forms.PictureBox();
            this.istatistikbaslık_lbl = new System.Windows.Forms.Label();
            this.geri_button = new System.Windows.Forms.Button();
            this.ogrenmekte_lbl = new System.Windows.Forms.Label();
            this.ogrendigim_lbl = new System.Windows.Forms.Label();
            this.ogrenmekte_datagrid = new System.Windows.Forms.DataGridView();
            this.ogrendigim_datagrid = new System.Windows.Forms.DataGridView();
            this.istatistik_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.istatistikResmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenmekte_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrendigim_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // istatistik_panel
            // 
            this.istatistik_panel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.istatistik_panel.Controls.Add(this.istatistikResmi);
            this.istatistik_panel.Controls.Add(this.istatistikbaslık_lbl);
            this.istatistik_panel.Controls.Add(this.geri_button);
            this.istatistik_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.istatistik_panel.Location = new System.Drawing.Point(0, 0);
            this.istatistik_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.istatistik_panel.Name = "istatistik_panel";
            this.istatistik_panel.Size = new System.Drawing.Size(818, 108);
            this.istatistik_panel.TabIndex = 0;
            // 
            // istatistikResmi
            // 
            this.istatistikResmi.Image = ((System.Drawing.Image)(resources.GetObject("istatistikResmi.Image")));
            this.istatistikResmi.Location = new System.Drawing.Point(69, 12);
            this.istatistikResmi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.istatistikResmi.Name = "istatistikResmi";
            this.istatistikResmi.Size = new System.Drawing.Size(140, 88);
            this.istatistikResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.istatistikResmi.TabIndex = 1;
            this.istatistikResmi.TabStop = false;
            // 
            // istatistikbaslık_lbl
            // 
            this.istatistikbaslık_lbl.AutoSize = true;
            this.istatistikbaslık_lbl.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.istatistikbaslık_lbl.Location = new System.Drawing.Point(244, 12);
            this.istatistikbaslık_lbl.Name = "istatistikbaslık_lbl";
            this.istatistikbaslık_lbl.Size = new System.Drawing.Size(343, 57);
            this.istatistikbaslık_lbl.TabIndex = 1;
            this.istatistikbaslık_lbl.Text = "İSTATİSTİKLERİNİZ";
            // 
            // geri_button
            // 
            this.geri_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri_button.Location = new System.Drawing.Point(685, 12);
            this.geri_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.geri_button.Name = "geri_button";
            this.geri_button.Size = new System.Drawing.Size(122, 54);
            this.geri_button.TabIndex = 1;
            this.geri_button.Text = "GERİ DÖN";
            this.geri_button.UseVisualStyleBackColor = true;
            this.geri_button.Click += new System.EventHandler(this.geri_button_Click);
            // 
            // ogrenmekte_lbl
            // 
            this.ogrenmekte_lbl.AutoSize = true;
            this.ogrenmekte_lbl.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenmekte_lbl.Location = new System.Drawing.Point(24, 142);
            this.ogrenmekte_lbl.Name = "ogrenmekte_lbl";
            this.ogrenmekte_lbl.Size = new System.Drawing.Size(367, 31);
            this.ogrenmekte_lbl.TabIndex = 4;
            this.ogrenmekte_lbl.Text = "ÖĞRENMEKTE OLDUĞUM KELİMELER";
            // 
            // ogrendigim_lbl
            // 
            this.ogrendigim_lbl.AutoSize = true;
            this.ogrendigim_lbl.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrendigim_lbl.Location = new System.Drawing.Point(494, 142);
            this.ogrendigim_lbl.Name = "ogrendigim_lbl";
            this.ogrendigim_lbl.Size = new System.Drawing.Size(253, 31);
            this.ogrendigim_lbl.TabIndex = 5;
            this.ogrendigim_lbl.Text = "ÖĞRENDİĞİM KELİMELER";
            // 
            // ogrenmekte_datagrid
            // 
            this.ogrenmekte_datagrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ogrenmekte_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrenmekte_datagrid.Location = new System.Drawing.Point(12, 187);
            this.ogrenmekte_datagrid.Name = "ogrenmekte_datagrid";
            this.ogrenmekte_datagrid.RowTemplate.Height = 28;
            this.ogrenmekte_datagrid.Size = new System.Drawing.Size(389, 418);
            this.ogrenmekte_datagrid.TabIndex = 6;
            // 
            // ogrendigim_datagrid
            // 
            this.ogrendigim_datagrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ogrendigim_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrendigim_datagrid.Location = new System.Drawing.Point(418, 187);
            this.ogrendigim_datagrid.Name = "ogrendigim_datagrid";
            this.ogrendigim_datagrid.RowTemplate.Height = 28;
            this.ogrendigim_datagrid.Size = new System.Drawing.Size(389, 418);
            this.ogrendigim_datagrid.TabIndex = 7;
            // 
            // istatistik_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(818, 644);
            this.Controls.Add(this.ogrendigim_datagrid);
            this.Controls.Add(this.ogrenmekte_datagrid);
            this.Controls.Add(this.ogrendigim_lbl);
            this.Controls.Add(this.ogrenmekte_lbl);
            this.Controls.Add(this.istatistik_panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "istatistik_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KELİME ÖĞREN";
            this.Load += new System.EventHandler(this.istatistik_form_Load);
            this.istatistik_panel.ResumeLayout(false);
            this.istatistik_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.istatistikResmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenmekte_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrendigim_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel istatistik_panel;
        private System.Windows.Forms.Button geri_button;
        private System.Windows.Forms.PictureBox istatistikResmi;
        private System.Windows.Forms.Label istatistikbaslık_lbl;
        private System.Windows.Forms.Label ogrenmekte_lbl;
        private System.Windows.Forms.Label ogrendigim_lbl;
        private System.Windows.Forms.DataGridView ogrenmekte_datagrid;
        private System.Windows.Forms.DataGridView ogrendigim_datagrid;
    }
}