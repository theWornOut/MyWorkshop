namespace ClassExpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSunucu = new System.Windows.Forms.TextBox();
            this.txtVeritabani = new System.Windows.Forms.TextBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.btnAc = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sunucu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veritabanı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parola";
            // 
            // txtSunucu
            // 
            this.txtSunucu.Location = new System.Drawing.Point(172, 44);
            this.txtSunucu.Name = "txtSunucu";
            this.txtSunucu.Size = new System.Drawing.Size(100, 20);
            this.txtSunucu.TabIndex = 4;
            // 
            // txtVeritabani
            // 
            this.txtVeritabani.Location = new System.Drawing.Point(172, 70);
            this.txtVeritabani.Name = "txtVeritabani";
            this.txtVeritabani.Size = new System.Drawing.Size(100, 20);
            this.txtVeritabani.TabIndex = 5;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(172, 96);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(100, 20);
            this.txtKullanici.TabIndex = 6;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(172, 122);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(100, 20);
            this.txtParola.TabIndex = 7;
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(27, 167);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(75, 23);
            this.btnBaglan.TabIndex = 8;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(197, 167);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(75, 23);
            this.btnAc.TabIndex = 9;
            this.btnAc.Text = "Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(197, 196);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 10;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(8, 239);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(13, 13);
            this.lblDurum.TabIndex = 11;
            this.lblDurum.Text = "_";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.txtVeritabani);
            this.Controls.Add(this.txtSunucu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSunucu;
        private System.Windows.Forms.TextBox txtVeritabani;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label lblDurum;
    }
}

