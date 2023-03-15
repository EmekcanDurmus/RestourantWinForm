using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Urun : Form
    {
        public Urun()
        {
            InitializeComponent();
        }
        RestaurantEntities1 db = new RestaurantEntities1();

        private void Yenile()
        {
            var result = from u in db.Urunler
                         select new
                         {
                             u.UrunID,
                             u.RestaurantMenu.MenuAdi,
                             u.UrunAdi,
                             u.Fiyat,
                             u.Durum
                         };
            dataGridView1.DataSource = result.ToList();

            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Temizle();
        }
        private void Temizle()
        {
            comboBox1.SelectedItem = null;
            comboBox1.Text = "Menü Seciniz";
            textBox1.Text = "Ürün Adi Giriniz";
            numericUpDown1.Value = 0;
            checkBox1.Checked = false;
        }
        private void Urun_Load(object sender, EventArgs e)
        {
            Yenile();

            //----------------------------------------

            var menuler = db.RestaurantMenu.ToList();
            comboBox1.DisplayMember = "MenuAdi";
            comboBox1.ValueMember = "RestaurantMenuID";
            foreach (var item in menuler)
            {
                comboBox1.Items.Add(item);
            }



        }



        private void btnYenile_Click(object sender, EventArgs e)
        {
            Yenile();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.RestaurantMenuID = comboBox1.SelectedIndex + 1;
            u.UrunAdi = textBox1.Text;
            u.Fiyat = numericUpDown1.Value;
            u.Durum = checkBox1.Checked;

            db.Urunler.Add(u);
            db.SaveChanges();
            
            Yenile();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedCells[0].Value;
            db.Urunler.Remove(db.Urunler.Find(id));
            db.SaveChanges();
            Yenile();
        }

        Urunler secili;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            secili = db.Urunler.Find(id);
            comboBox1.SelectedIndex = secili.RestaurantMenuID - 1;
            textBox1.Text = secili.UrunAdi;
            numericUpDown1.Value = (decimal)secili.Fiyat;
            checkBox1.Checked = secili.Durum;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var result = from u in db.Urunler
                         where u.RestaurantMenu.RestaurantMenuID == comboBox1.SelectedIndex + 1
                         select new
                         {
                             u.UrunID,
                             u.RestaurantMenu.MenuAdi,
                             u.UrunAdi,
                             u.Fiyat,
                             u.Durum
                         };
            dataGridView1.DataSource = result.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secili.RestaurantMenuID = (comboBox1.SelectedIndex + 1);
            secili.UrunAdi = textBox1.Text;
            secili.Fiyat = numericUpDown1.Value;
            secili.Durum = checkBox1.Checked;
            db.SaveChanges();
            Yenile();
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }
    }
}
