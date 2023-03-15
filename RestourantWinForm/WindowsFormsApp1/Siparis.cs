using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
        }
        RestaurantEntities1 db = new RestaurantEntities1();
        private void Siparis_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void Yenile()
        {
            var result = from s in db.Siparisler
                         where s.Durum.ToString().Contains("True")
                         select new
                         {
                             s.SiparisID,
                             AdıSoyadı = s.Musteriler.MusteriAdi + " " + s.Musteriler.MusteriSoyAdi,
                             TeslimatAdresi = s.GonderilenAdres,
                             SiparisKanalı = s.SiparisKanallari.SiparisKanaliAdi,
                             ÖdemeYöntemi = s.OdemeYontemleri.YontemAdi,
                             s.SiparişZamani,
                             SorumluCalışan = s.Calisanlar.CalisanAdi + " " + s.Calisanlar.CalisanSoyAdi,
                             s.Durum

                         };
            dataGridView1.DataSource = result.ToList();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAcikSiparisler_Click(object sender, EventArgs e)
        {
            Yenile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YenileKapaliSiparisler();
        }

        private void YenileKapaliSiparisler()
        {
            var result = from s in db.Siparisler
                         where s.Durum.ToString().Contains("False")
                         select new
                         {
                             s.SiparisID,
                             AdıSoyadı = s.Musteriler.MusteriAdi + " " + s.Musteriler.MusteriSoyAdi,
                             TeslimatAdresi = s.GonderilenAdres,
                             SiparisKanalı = s.SiparisKanallari.SiparisKanaliAdi,
                             ÖdemeYöntemi = s.OdemeYontemleri.YontemAdi,
                             s.SiparişZamani,
                             SorumluCalışan = s.Calisanlar.CalisanAdi + " " + s.Calisanlar.CalisanSoyAdi,
                             s.Durum

                         };
            dataGridView1.DataSource = result.ToList();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        Siparisler secili;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            secili = db.Siparisler.Find(id);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secili.Durum = false;
            db.SaveChanges();
            Yenile();
        }
    }
}
