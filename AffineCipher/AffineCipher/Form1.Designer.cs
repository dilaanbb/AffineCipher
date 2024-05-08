namespace AffineCipher
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtDeSifrelenmis = new System.Windows.Forms.TextBox();
            this.txtSifrelenmis = new System.Windows.Forms.TextBox();
            this.txtKckSifrelenecek = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtSifrelenecek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.btnDeSifrele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(166, 142);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 0;
            // 
            // txtDeSifrelenmis
            // 
            this.txtDeSifrelenmis.Location = new System.Drawing.Point(492, 215);
            this.txtDeSifrelenmis.Name = "txtDeSifrelenmis";
            this.txtDeSifrelenmis.Size = new System.Drawing.Size(100, 22);
            this.txtDeSifrelenmis.TabIndex = 1;
            // 
            // txtSifrelenmis
            // 
            this.txtSifrelenmis.Location = new System.Drawing.Point(492, 148);
            this.txtSifrelenmis.Name = "txtSifrelenmis";
            this.txtSifrelenmis.Size = new System.Drawing.Size(100, 22);
            this.txtSifrelenmis.TabIndex = 2;
            // 
            // txtKckSifrelenecek
            // 
            this.txtKckSifrelenecek.Location = new System.Drawing.Point(492, 78);
            this.txtKckSifrelenecek.Name = "txtKckSifrelenecek";
            this.txtKckSifrelenecek.Size = new System.Drawing.Size(100, 22);
            this.txtKckSifrelenecek.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(166, 209);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 4;
            // 
            // txtSifrelenecek
            // 
            this.txtSifrelenecek.Location = new System.Drawing.Point(166, 81);
            this.txtSifrelenecek.Name = "txtSifrelenecek";
            this.txtSifrelenecek.Size = new System.Drawing.Size(100, 22);
            this.txtSifrelenecek.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Şifrelenmiş Metin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Deşifrelenmiş Metin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şifrelenecek Metin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "b = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "a = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Şifrelenecek Metin";
            // 
            // btnSifrele
            // 
            this.btnSifrele.Location = new System.Drawing.Point(191, 29);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(75, 23);
            this.btnSifrele.TabIndex = 12;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // btnDeSifrele
            // 
            this.btnDeSifrele.Location = new System.Drawing.Point(517, 276);
            this.btnDeSifrele.Name = "btnDeSifrele";
            this.btnDeSifrele.Size = new System.Drawing.Size(75, 23);
            this.btnDeSifrele.TabIndex = 13;
            this.btnDeSifrele.Text = "Deşifrele";
            this.btnDeSifrele.UseVisualStyleBackColor = true;
            this.btnDeSifrele.Click += new System.EventHandler(this.btnDeSifrele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 368);
            this.Controls.Add(this.btnDeSifrele);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifrelenecek);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtKckSifrelenecek);
            this.Controls.Add(this.txtSifrelenmis);
            this.Controls.Add(this.txtDeSifrelenmis);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtDeSifrelenmis;
        private System.Windows.Forms.TextBox txtSifrelenmis;
        private System.Windows.Forms.TextBox txtKckSifrelenecek;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtSifrelenecek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.Button btnDeSifrele;
    }
}

