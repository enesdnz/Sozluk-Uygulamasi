namespace yazilim_yapimi
{
    partial class test_form
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
            this.components = new System.ComponentModel.Container();
            this.testgeri_button = new System.Windows.Forms.Button();
            this.basla_button = new System.Windows.Forms.Button();
            this.bitir_button = new System.Windows.Forms.Button();
            this.lblsüre = new System.Windows.Forms.Label();
            this.timer_label = new System.Windows.Forms.Label();
            this.cevapGroupBox = new System.Windows.Forms.GroupBox();
            this.b_button = new System.Windows.Forms.Button();
            this.d_button = new System.Windows.Forms.Button();
            this.dSıkkı = new System.Windows.Forms.Label();
            this.bSıkkı = new System.Windows.Forms.Label();
            this.cSıkkı = new System.Windows.Forms.Label();
            this.c_button = new System.Windows.Forms.Button();
            this.a_button = new System.Windows.Forms.Button();
            this.aSıkkı = new System.Windows.Forms.Label();
            this.testkelime_label = new System.Windows.Forms.Label();
            this.test_timer = new System.Windows.Forms.Timer(this.components);
            this.lblDogru = new System.Windows.Forms.Label();
            this.lblYanlis = new System.Windows.Forms.Label();
            this.göstergepaneli = new System.Windows.Forms.Panel();
            this.cevapGroupBox.SuspendLayout();
            this.göstergepaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // testgeri_button
            // 
            this.testgeri_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.testgeri_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testgeri_button.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.testgeri_button.Location = new System.Drawing.Point(754, 12);
            this.testgeri_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testgeri_button.Name = "testgeri_button";
            this.testgeri_button.Size = new System.Drawing.Size(112, 49);
            this.testgeri_button.TabIndex = 0;
            this.testgeri_button.Text = "GERİ DÖN";
            this.testgeri_button.UseVisualStyleBackColor = false;
            this.testgeri_button.Click += new System.EventHandler(this.testgeri_button_Click);
            // 
            // basla_button
            // 
            this.basla_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.basla_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basla_button.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basla_button.Location = new System.Drawing.Point(712, 124);
            this.basla_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.basla_button.Name = "basla_button";
            this.basla_button.Size = new System.Drawing.Size(154, 78);
            this.basla_button.TabIndex = 1;
            this.basla_button.Text = "TESTE BAŞLA";
            this.basla_button.UseVisualStyleBackColor = false;
            this.basla_button.Click += new System.EventHandler(this.başla_button_Click);
            // 
            // bitir_button
            // 
            this.bitir_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bitir_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bitir_button.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitir_button.Location = new System.Drawing.Point(712, 124);
            this.bitir_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bitir_button.Name = "bitir_button";
            this.bitir_button.Size = new System.Drawing.Size(154, 78);
            this.bitir_button.TabIndex = 3;
            this.bitir_button.Text = "TESTİ BİTİR";
            this.bitir_button.UseVisualStyleBackColor = false;
            this.bitir_button.Click += new System.EventHandler(this.bitir_button_Click);
            // 
            // lblsüre
            // 
            this.lblsüre.AutoSize = true;
            this.lblsüre.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsüre.Location = new System.Drawing.Point(100, 22);
            this.lblsüre.Name = "lblsüre";
            this.lblsüre.Size = new System.Drawing.Size(87, 26);
            this.lblsüre.TabIndex = 4;
            this.lblsüre.Text = "SÜRE :";
            // 
            // timer_label
            // 
            this.timer_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timer_label.ForeColor = System.Drawing.Color.Red;
            this.timer_label.Location = new System.Drawing.Point(194, 22);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(58, 29);
            this.timer_label.TabIndex = 5;
            this.timer_label.Text = "0";
            // 
            // cevapGroupBox
            // 
            this.cevapGroupBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cevapGroupBox.Controls.Add(this.b_button);
            this.cevapGroupBox.Controls.Add(this.d_button);
            this.cevapGroupBox.Controls.Add(this.dSıkkı);
            this.cevapGroupBox.Controls.Add(this.bSıkkı);
            this.cevapGroupBox.Controls.Add(this.cSıkkı);
            this.cevapGroupBox.Controls.Add(this.c_button);
            this.cevapGroupBox.Controls.Add(this.a_button);
            this.cevapGroupBox.Controls.Add(this.aSıkkı);
            this.cevapGroupBox.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevapGroupBox.Location = new System.Drawing.Point(183, 351);
            this.cevapGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cevapGroupBox.Name = "cevapGroupBox";
            this.cevapGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cevapGroupBox.Size = new System.Drawing.Size(480, 315);
            this.cevapGroupBox.TabIndex = 7;
            this.cevapGroupBox.TabStop = false;
            this.cevapGroupBox.Text = "CEVAP ŞIKLARI";
            // 
            // b_button
            // 
            this.b_button.Location = new System.Drawing.Point(282, 82);
            this.b_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_button.Name = "b_button";
            this.b_button.Size = new System.Drawing.Size(166, 62);
            this.b_button.TabIndex = 1;
            this.b_button.UseVisualStyleBackColor = true;
            this.b_button.Click += new System.EventHandler(this.B_button_Click);
            // 
            // d_button
            // 
            this.d_button.Location = new System.Drawing.Point(282, 182);
            this.d_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.d_button.Name = "d_button";
            this.d_button.Size = new System.Drawing.Size(166, 62);
            this.d_button.TabIndex = 3;
            this.d_button.UseVisualStyleBackColor = true;
            this.d_button.Click += new System.EventHandler(this.D_button_Click);
            // 
            // dSıkkı
            // 
            this.dSıkkı.AutoSize = true;
            this.dSıkkı.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dSıkkı.Location = new System.Drawing.Point(240, 194);
            this.dSıkkı.Name = "dSıkkı";
            this.dSıkkı.Size = new System.Drawing.Size(43, 32);
            this.dSıkkı.TabIndex = 15;
            this.dSıkkı.Text = "D.";
            // 
            // bSıkkı
            // 
            this.bSıkkı.AutoSize = true;
            this.bSıkkı.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSıkkı.Location = new System.Drawing.Point(240, 92);
            this.bSıkkı.Name = "bSıkkı";
            this.bSıkkı.Size = new System.Drawing.Size(43, 32);
            this.bSıkkı.TabIndex = 14;
            this.bSıkkı.Text = "B.";
            // 
            // cSıkkı
            // 
            this.cSıkkı.AutoSize = true;
            this.cSıkkı.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cSıkkı.Location = new System.Drawing.Point(3, 211);
            this.cSıkkı.Name = "cSıkkı";
            this.cSıkkı.Size = new System.Drawing.Size(43, 32);
            this.cSıkkı.TabIndex = 13;
            this.cSıkkı.Text = "C.";
            // 
            // c_button
            // 
            this.c_button.Location = new System.Drawing.Point(52, 182);
            this.c_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.c_button.Name = "c_button";
            this.c_button.Size = new System.Drawing.Size(160, 62);
            this.c_button.TabIndex = 2;
            this.c_button.UseVisualStyleBackColor = true;
            this.c_button.Click += new System.EventHandler(this.C_button_Click);
            // 
            // a_button
            // 
            this.a_button.Location = new System.Drawing.Point(52, 80);
            this.a_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.a_button.Name = "a_button";
            this.a_button.Size = new System.Drawing.Size(160, 62);
            this.a_button.TabIndex = 0;
            this.a_button.UseVisualStyleBackColor = true;
            this.a_button.Click += new System.EventHandler(this.a_button_Click);
            // 
            // aSıkkı
            // 
            this.aSıkkı.AutoSize = true;
            this.aSıkkı.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aSıkkı.Location = new System.Drawing.Point(2, 92);
            this.aSıkkı.Name = "aSıkkı";
            this.aSıkkı.Size = new System.Drawing.Size(43, 32);
            this.aSıkkı.TabIndex = 12;
            this.aSıkkı.Text = "A.";
            // 
            // testkelime_label
            // 
            this.testkelime_label.BackColor = System.Drawing.Color.Silver;
            this.testkelime_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testkelime_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.testkelime_label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.testkelime_label.Location = new System.Drawing.Point(161, 236);
            this.testkelime_label.Name = "testkelime_label";
            this.testkelime_label.Size = new System.Drawing.Size(524, 52);
            this.testkelime_label.TabIndex = 11;
            this.testkelime_label.Click += new System.EventHandler(this.testkelime_label_Click);
            // 
            // test_timer
            // 
            this.test_timer.Tick += new System.EventHandler(this.test_timer_Tick);
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogru.Location = new System.Drawing.Point(4, 52);
            this.lblDogru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(187, 26);
            this.lblDogru.TabIndex = 16;
            this.lblDogru.Text = "DOĞRU SAYISI : ";
            // 
            // lblYanlis
            // 
            this.lblYanlis.AutoSize = true;
            this.lblYanlis.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYanlis.Location = new System.Drawing.Point(11, 78);
            this.lblYanlis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(176, 26);
            this.lblYanlis.TabIndex = 13;
            this.lblYanlis.Text = "YANLIŞ SAYISI :";
            // 
            // göstergepaneli
            // 
            this.göstergepaneli.BackColor = System.Drawing.Color.AliceBlue;
            this.göstergepaneli.Controls.Add(this.lblsüre);
            this.göstergepaneli.Controls.Add(this.lblDogru);
            this.göstergepaneli.Controls.Add(this.timer_label);
            this.göstergepaneli.Controls.Add(this.lblYanlis);
            this.göstergepaneli.Location = new System.Drawing.Point(12, 12);
            this.göstergepaneli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.göstergepaneli.Name = "göstergepaneli";
            this.göstergepaneli.Size = new System.Drawing.Size(255, 128);
            this.göstergepaneli.TabIndex = 17;
            // 
            // test_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(878, 694);
            this.Controls.Add(this.göstergepaneli);
            this.Controls.Add(this.testkelime_label);
            this.Controls.Add(this.cevapGroupBox);
            this.Controls.Add(this.bitir_button);
            this.Controls.Add(this.basla_button);
            this.Controls.Add(this.testgeri_button);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "test_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KELİME ÖĞREN";
            this.Load += new System.EventHandler(this.test_form_Load);
            this.cevapGroupBox.ResumeLayout(false);
            this.cevapGroupBox.PerformLayout();
            this.göstergepaneli.ResumeLayout(false);
            this.göstergepaneli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testgeri_button;
        private System.Windows.Forms.Button basla_button;
        private System.Windows.Forms.Button bitir_button;
        private System.Windows.Forms.Label lblsüre;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.GroupBox cevapGroupBox;
        private System.Windows.Forms.Button d_button;
        private System.Windows.Forms.Button c_button;
        private System.Windows.Forms.Button b_button;
        private System.Windows.Forms.Button a_button;
        private System.Windows.Forms.Label testkelime_label;
        private System.Windows.Forms.Label dSıkkı;
        private System.Windows.Forms.Label bSıkkı;
        private System.Windows.Forms.Label cSıkkı;
        private System.Windows.Forms.Label aSıkkı;
        private System.Windows.Forms.Timer test_timer;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label lblYanlis;
        private System.Windows.Forms.Panel göstergepaneli;
    }
}