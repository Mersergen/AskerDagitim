namespace AskerDagıtım
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
            this.lbxAsker = new System.Windows.Forms.ListBox();
            this.lbxSehir = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDagıtımYap = new System.Windows.Forms.Button();
            this.lbxEslesme = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAsker = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAskerEkle = new System.Windows.Forms.Button();
            this.btnSehirEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asker Liste:";
            // 
            // lbxAsker
            // 
            this.lbxAsker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxAsker.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbxAsker.FormattingEnabled = true;
            this.lbxAsker.ItemHeight = 20;
            this.lbxAsker.Location = new System.Drawing.Point(16, 32);
            this.lbxAsker.Name = "lbxAsker";
            this.lbxAsker.Size = new System.Drawing.Size(147, 264);
            this.lbxAsker.TabIndex = 1;
            // 
            // lbxSehir
            // 
            this.lbxSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxSehir.ForeColor = System.Drawing.Color.IndianRed;
            this.lbxSehir.FormattingEnabled = true;
            this.lbxSehir.ItemHeight = 20;
            this.lbxSehir.Location = new System.Drawing.Point(220, 32);
            this.lbxSehir.Name = "lbxSehir";
            this.lbxSehir.Size = new System.Drawing.Size(147, 264);
            this.lbxSehir.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(216, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şehir Liste:";
            // 
            // btnDagıtımYap
            // 
            this.btnDagıtımYap.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDagıtımYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDagıtımYap.ForeColor = System.Drawing.Color.White;
            this.btnDagıtımYap.Location = new System.Drawing.Point(16, 325);
            this.btnDagıtımYap.Name = "btnDagıtımYap";
            this.btnDagıtımYap.Size = new System.Drawing.Size(351, 43);
            this.btnDagıtımYap.TabIndex = 4;
            this.btnDagıtımYap.Text = "Dağıtım Yap!";
            this.btnDagıtımYap.UseVisualStyleBackColor = false;
            this.btnDagıtımYap.Click += new System.EventHandler(this.btnDagıtımYap_Click);
            // 
            // lbxEslesme
            // 
            this.lbxEslesme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxEslesme.ForeColor = System.Drawing.Color.Green;
            this.lbxEslesme.FormattingEnabled = true;
            this.lbxEslesme.ItemHeight = 20;
            this.lbxEslesme.Location = new System.Drawing.Point(452, 32);
            this.lbxEslesme.Name = "lbxEslesme";
            this.lbxEslesme.Size = new System.Drawing.Size(323, 264);
            this.lbxEslesme.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(448, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Eşleşme:";
            // 
            // txtAsker
            // 
            this.txtAsker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAsker.Location = new System.Drawing.Point(141, 397);
            this.txtAsker.Name = "txtAsker";
            this.txtAsker.Size = new System.Drawing.Size(147, 26);
            this.txtAsker.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Asker Ekle:";
            // 
            // btnAskerEkle
            // 
            this.btnAskerEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAskerEkle.Location = new System.Drawing.Point(326, 393);
            this.btnAskerEkle.Name = "btnAskerEkle";
            this.btnAskerEkle.Size = new System.Drawing.Size(115, 35);
            this.btnAskerEkle.TabIndex = 9;
            this.btnAskerEkle.Text = "Asker Ekle";
            this.btnAskerEkle.UseVisualStyleBackColor = true;
            this.btnAskerEkle.Click += new System.EventHandler(this.btnAskerEkle_Click);
            // 
            // btnSehirEkle
            // 
            this.btnSehirEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSehirEkle.Location = new System.Drawing.Point(326, 443);
            this.btnSehirEkle.Name = "btnSehirEkle";
            this.btnSehirEkle.Size = new System.Drawing.Size(115, 35);
            this.btnSehirEkle.TabIndex = 12;
            this.btnSehirEkle.Text = "Şehir Ekle";
            this.btnSehirEkle.UseVisualStyleBackColor = true;
            this.btnSehirEkle.Click += new System.EventHandler(this.btnSehirEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Şehir Ekle:";
            // 
            // txtSehir
            // 
            this.txtSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSehir.Location = new System.Drawing.Point(141, 447);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(147, 26);
            this.txtSehir.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 506);
            this.Controls.Add(this.btnSehirEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.btnAskerEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAsker);
            this.Controls.Add(this.lbxEslesme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDagıtımYap);
            this.Controls.Add(this.lbxSehir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxAsker);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxAsker;
        private System.Windows.Forms.ListBox lbxSehir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDagıtımYap;
        private System.Windows.Forms.ListBox lbxEslesme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAsker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAskerEkle;
        private System.Windows.Forms.Button btnSehirEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSehir;
    }
}

