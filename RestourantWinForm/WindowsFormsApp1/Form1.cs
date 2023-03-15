using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Child Form
        private Form active = null;
        private void OpenChildForm(Form child)
        {
            if (ActiveForm == null)
            {
                ActiveForm.Close();
            }
            else
            {
                active = child;
                child.TopLevel = false; // Form ekranının border kısımlarını gizler
                child.FormBorderStyle = FormBorderStyle.None;
                child.Dock = DockStyle.Fill;
                pnlOrta.Controls.Add(child);
                pnlOrta.Tag = child;
                child.BringToFront();
                child.Show();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            OpenChildForm(u);
        }

        private void btnCalisanlar_Click(object sender, EventArgs e)
        {
            Calisan c = new Calisan();
            OpenChildForm(c);
        }

        private void btnTedarikciler_Click(object sender, EventArgs e)
        {
            Tedarik t = new Tedarik();
            OpenChildForm(t);
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            OpenChildForm(m);
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            Siparis sip = new Siparis();
            OpenChildForm(sip);
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            Rezervasyon rezervasyon = new Rezervasyon();
            OpenChildForm(rezervasyon);
        }

        private void btnOdemeYontemleri_Click(object sender, EventArgs e)
        {
            SiparisKanalOdemeYontem f2 = new SiparisKanalOdemeYontem();
            OpenChildForm(f2);
        }

        private void btnMasa_Click(object sender, EventArgs e)
        {
            YeniSiparis ys = new YeniSiparis();
            OpenChildForm (ys);
        }
    }
}
