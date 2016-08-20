namespace HashTableExpForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTumListe = new System.Windows.Forms.Button();
            this.btnCikart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stbDurum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 238);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(187, 74);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(324, 147);
            this.listBox2.TabIndex = 1;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(187, 25);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 20);
            this.txtKey.TabIndex = 2;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(296, 25);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(436, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTumListe
            // 
            this.btnTumListe.Location = new System.Drawing.Point(436, 41);
            this.btnTumListe.Name = "btnTumListe";
            this.btnTumListe.Size = new System.Drawing.Size(75, 23);
            this.btnTumListe.TabIndex = 5;
            this.btnTumListe.Text = "Tüm Liste";
            this.btnTumListe.UseVisualStyleBackColor = true;
            this.btnTumListe.Click += new System.EventHandler(this.btnTumListe_Click);
            // 
            // btnCikart
            // 
            this.btnCikart.Location = new System.Drawing.Point(436, 226);
            this.btnCikart.Name = "btnCikart";
            this.btnCikart.Size = new System.Drawing.Size(75, 23);
            this.btnCikart.TabIndex = 6;
            this.btnCikart.Text = "Çıkart";
            this.btnCikart.UseVisualStyleBackColor = true;
            this.btnCikart.Click += new System.EventHandler(this.btnCikart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Value";
            // 
            // stbDurum
            // 
            this.stbDurum.Location = new System.Drawing.Point(187, 227);
            this.stbDurum.Name = "stbDurum";
            this.stbDurum.Size = new System.Drawing.Size(243, 20);
            this.stbDurum.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 261);
            this.Controls.Add(this.stbDurum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikart);
            this.Controls.Add(this.btnTumListe);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTumListe;
        private System.Windows.Forms.Button btnCikart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stbDurum;
    }
}

