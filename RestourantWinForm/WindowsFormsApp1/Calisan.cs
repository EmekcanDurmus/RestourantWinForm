using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calisan : Form
    {
        public Calisan()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            textBox1.Text = "Ad Giriniz";
            textBox2.Text = "Soyad Giriniz";
            textBox3.Text = "Ünvan Giriniz";
            comboBox1.Text = "Sorumlu Kisi Seciniz";
        }
        private void Yenile()
        {
            var result = from c in db.Calisanlar
                         select new
                         {
                             c.CalisanID,
                             Ad = c.CalisanAdi,
                             Soyad = c.CalisanSoyAdi,
                             c.Unvan,
                             RaporVerecegiKişi = c.Calisanlar2.CalisanAdi + " " + c.Calisanlar2.CalisanSoyAdi,
                         };
            dataGridView1.DataSource = result.ToList();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Temizle();
        }
        RestaurantEntities1 db = new RestaurantEntities1();
        private void Calisan_Load(object sender, EventArgs e)
        {

            Yenile();

            var hesap = db.Calisanlar.ToList();
            comboBox1.DisplayMember = "CalisanAdi";
            comboBox1.ValueMember = "RaporVerecegiKisi";
            foreach (var item in hesap)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Calisanlar c = new Calisanlar();
            c.CalisanAdi = textBox1.Text;
            c.CalisanSoyAdi = textBox2.Text;
            c.Unvan = textBox3.Text;
            c.RaporVerecegiKisi = comboBox1.SelectedIndex + 1;
            db.Calisanlar.Add(c);
            db.SaveChanges();
            Yenile();
            
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Yenile();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedCells[0].Value;
            db.Calisanlar.Remove(db.Calisanlar.Find(id));
            db.SaveChanges();
            Yenile();
            
        }

        Calisanlar secili;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            secili = db.Calisanlar.Find(id);
            textBox1.Text = secili.CalisanAdi;
            textBox2.Text = secili.CalisanSoyAdi;
            textBox3.Text = secili.Unvan;
            comboBox1.SelectedIndex = (int)secili.RaporVerecegiKisi - 1;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secili.CalisanAdi = textBox1.Text;
            secili.CalisanSoyAdi = textBox2.Text;
            secili.Unvan = textBox3.Text;
            secili.RaporVerecegiKisi = (comboBox1.SelectedIndex + 1);
            db.SaveChanges();
            Yenile();
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
        }
    }
}
