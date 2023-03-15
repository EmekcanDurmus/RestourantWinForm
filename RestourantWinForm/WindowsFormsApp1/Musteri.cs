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
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }
        RestaurantEntities1 db = new RestaurantEntities1();
        private void Musteri_Load(object sender, EventArgs e)
        {
            Yenile();
        }
        private void Temizle()
        {
            textBox1.Text = "Müsteri Adı";
            textBox2.Text = "Müsteri Soyadı";
            textBox3.Text = "Telefon Numarası";
            textBox4.Text = "Adres";
        }
        private void Yenile()
        {
            var result = from m in db.Musteriler
                         select new
                         {
                             m.MusteriID,
                             AdıSoyadı = m.MusteriAdi+" "+ m.MusteriSoyAdi,
                             TelNo = m.MusteriTelefonNumarasi,
                             Adres = m.MusteriAdresi,
                         };
            dataGridView1.DataSource = result.ToList();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Temizle();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Yenile();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m.MusteriAdi = textBox1.Text;
            m.MusteriSoyAdi= textBox2.Text;
            m.MusteriTelefonNumarasi = textBox3.Text;
            m.MusteriAdresi= textBox4.Text;
            db.Musteriler.Add(m);
            db.SaveChanges();
            Yenile();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = String.Empty;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = String.Empty;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedCells[0].Value;
            db.Musteriler.Remove(db.Musteriler.Find(id));
            db.SaveChanges();
            Yenile();
        }
        Musteriler secili;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            secili = db.Musteriler.Find(id);
            textBox1.Text = secili.MusteriAdi;
            textBox2.Text = secili.MusteriSoyAdi;
            textBox3.Text = secili.MusteriTelefonNumarasi;
            textBox4.Text = secili.MusteriAdresi;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secili.MusteriAdi = textBox1.Text;
            secili.MusteriSoyAdi = textBox2.Text;
            secili.MusteriTelefonNumarasi = textBox3.Text;
            secili.MusteriAdresi= textBox4.Text;
            db.SaveChanges();
            Yenile();
        }
    }
}
