namespace WindowsFormsApp1
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
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.pnlSol = new System.Windows.Forms.Panel();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.btnUrun = new System.Windows.Forms.Button();
            this.btnMasa = new System.Windows.Forms.Button();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTedarikciler = new System.Windows.Forms.Button();
            this.btnCalisanlar = new System.Windows.Forms.Button();
            this.btnOdemeYontemleri = new System.Windows.Forms.Button();
            this.pnlSol.SuspendLayout();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrta
            // 
            this.pnlOrta.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlOrta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(200, 100);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(1282, 603);
            this.pnlOrta.TabIndex = 8;
            // 
            // pnlSol
            // 
            this.pnlSol.Controls.Add(this.btnRezervasyon);
            this.pnlSol.Controls.Add(this.btnSiparis);
            this.pnlSol.Controls.Add(this.btnMusteri);
            this.pnlSol.Controls.Add(this.btnUrun);
            this.pnlSol.Controls.Add(this.btnMasa);
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.Location = new System.Drawing.Point(0, 100);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(200, 603);
            this.pnlSol.TabIndex = 6;
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRezervasyon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRezervasyon.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyon.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyon.Location = new System.Drawing.Point(0, 480);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(200, 120);
            this.btnRezervasyon.TabIndex = 4;
            this.btnRezervasyon.Text = "Rezervasyon";
            this.btnRezervasyon.UseVisualStyleBackColor = false;
            this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click);
            // 
            // btnSiparis
            // 
            this.btnSiparis.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSiparis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSiparis.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparis.ForeColor = System.Drawing.Color.White;
            this.btnSiparis.Location = new System.Drawing.Point(0, 360);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(200, 120);
            this.btnSiparis.TabIndex = 3;
            this.btnSiparis.Text = "Siparisler";
            this.btnSiparis.UseVisualStyleBackColor = false;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMusteri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusteri.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteri.ForeColor = System.Drawing.Color.White;
            this.btnMusteri.Location = new System.Drawing.Point(0, 240);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(200, 120);
            this.btnMusteri.TabIndex = 2;
            this.btnMusteri.Text = "Musteriler";
            this.btnMusteri.UseVisualStyleBackColor = false;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnUrun
            // 
            this.btnUrun.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUrun.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrun.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrun.ForeColor = System.Drawing.Color.White;
            this.btnUrun.Location = new System.Drawing.Point(0, 120);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(200, 120);
            this.btnUrun.TabIndex = 1;
            this.btnUrun.Text = "Urunler";
            this.btnUrun.UseVisualStyleBackColor = false;
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // btnMasa
            // 
            this.btnMasa.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMasa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMasa.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasa.ForeColor = System.Drawing.Color.White;
            this.btnMasa.Location = new System.Drawing.Point(0, 0);
            this.btnMasa.Name = "btnMasa";
            this.btnMasa.Size = new System.Drawing.Size(200, 120);
            this.btnMasa.TabIndex = 0;
            this.btnMasa.Text = "Yeni Sipariş";
            this.btnMasa.UseVisualStyleBackColor = false;
            this.btnMasa.Click += new System.EventHandler(this.btnMasa_Click);
            // 
            // pnlUst
            // 
            this.pnlUst.Controls.Add(this.label5);
            this.pnlUst.Controls.Add(this.label3);
            this.pnlUst.Controls.Add(this.label2);
            this.pnlUst.Controls.Add(this.label1);
            this.pnlUst.Controls.Add(this.btnTedarikciler);
            this.pnlUst.Controls.Add(this.btnCalisanlar);
            this.pnlUst.Controls.Add(this.btnOdemeYontemleri);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1482, 100);
            this.pnlUst.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(240, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 97);
            this.label5.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(477, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "pasha@gmail.com";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(262, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "02122122222";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 88);
            this.label1.TabIndex = 4;
            this.label1.Text = "Davutpaşa Pide Lahmacun";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTedarikciler
            // 
            this.btnTedarikciler.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTedarikciler.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTedarikciler.ForeColor = System.Drawing.Color.White;
            this.btnTedarikciler.Location = new System.Drawing.Point(722, 0);
            this.btnTedarikciler.Name = "btnTedarikciler";
            this.btnTedarikciler.Size = new System.Drawing.Size(190, 100);
            this.btnTedarikciler.TabIndex = 3;
            this.btnTedarikciler.Text = "Tedarikçiler";
            this.btnTedarikciler.UseVisualStyleBackColor = false;
            this.btnTedarikciler.Click += new System.EventHandler(this.btnTedarikciler_Click);
            // 
            // btnCalisanlar
            // 
            this.btnCalisanlar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCalisanlar.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanlar.ForeColor = System.Drawing.Color.White;
            this.btnCalisanlar.Location = new System.Drawing.Point(912, 0);
            this.btnCalisanlar.Name = "btnCalisanlar";
            this.btnCalisanlar.Size = new System.Drawing.Size(190, 100);
            this.btnCalisanlar.TabIndex = 2;
            this.btnCalisanlar.Text = "Çalışanlar";
            this.btnCalisanlar.UseVisualStyleBackColor = false;
            this.btnCalisanlar.Click += new System.EventHandler(this.btnCalisanlar_Click);
            // 
            // btnOdemeYontemleri
            // 
            this.btnOdemeYontemleri.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOdemeYontemleri.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeYontemleri.ForeColor = System.Drawing.Color.White;
            this.btnOdemeYontemleri.Location = new System.Drawing.Point(1102, 0);
            this.btnOdemeYontemleri.Name = "btnOdemeYontemleri";
            this.btnOdemeYontemleri.Size = new System.Drawing.Size(377, 100);
            this.btnOdemeYontemleri.TabIndex = 1;
            this.btnOdemeYontemleri.Text = "Ödeme Yontemleri- Siparis Kanalları";
            this.btnOdemeYontemleri.UseVisualStyleBackColor = false;
            this.btnOdemeYontemleri.Click += new System.EventHandler(this.btnOdemeYontemleri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 703);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.pnlSol);
            this.Controls.Add(this.pnlUst);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSol.ResumeLayout(false);
            this.pnlUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.Panel pnlSol;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Button btnMasa;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTedarikciler;
        private System.Windows.Forms.Button btnCalisanlar;
        private System.Windows.Forms.Button btnOdemeYontemleri;
    }
}

