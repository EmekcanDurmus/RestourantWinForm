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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class YeniSiparis : Form
    {
        public YeniSiparis()
        {
            InitializeComponent();
        }
        RestaurantEntities1 db = new RestaurantEntities1();
        private void YeniSiparis_Load(object sender, EventArgs e)
        {
            var result5 = from sp in db.SiparisUrunDetay
                          where sp.Siparisler.Durum.ToString().Contains("True")
                          select new
                          {
                              sp.Siparisler.SiparisID,
                              sp.Siparisler.Musteriler.MusteriID,
                              sp.Siparisler.Musteriler.MusteriAdi,
                              sp.Urunler.UrunAdi,
                              sp.Adet,
                              sp.Tutar
                          };

            dataGridView2.DataSource = result5.ToList();
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            textBoxID.Text = "Siparis ID Giriniz";
            textBoxAdet.Text = "Adet Giriniz";
            textBox1.Text = "MusteriID Giriniz";
            textBox2.Text = "Adres Giriniz";

            var menu = db.RestaurantMenu.ToList();
            //comboBox1.DisplayMember = "MenuAdi";
            //comboBox1.ValueMember = "RestaurantMenuID";
            foreach (var item in menu)
            {
                //comboBox1.Items.Add(item);
            }


            dataGridView1.DataSource = db.Urunler.Select(u => new
            {
                u.UrunID,
                u.UrunAdi,
                u.Fiyat,
                u.Durum
            }).ToList();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var odemeyontemi = db.OdemeYontemleri.ToList();
            comboBox3.DisplayMember = "YontemAdi";
            comboBox3.ValueMember = "OdemeYontemID";
            foreach (var item1 in odemeyontemi)
            {
                comboBox3.Items.Add(item1);
            }

            var sipariskanali = db.SiparisKanallari.ToList();
            comboBox4.DisplayMember = "SiparisKanaliAdi";
            comboBox4.ValueMember = "SiparisKanaliID";
            foreach (var item2 in sipariskanali)
            {
                comboBox4.Items.Add(item2);
            }

            var sorumlucalisan = db.Calisanlar.ToList();
            comboBox5.DisplayMember = "CalisanAdi";
            comboBox5.ValueMember = "CalisanID";
            foreach (var item2 in sorumlucalisan)
            {
                comboBox5.Items.Add(item2);
            }

           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedIndex == 0)
            //{
            //    comboBox2.Items.Clear();
            //    var urun = db.Urunler.Where(u => u.RestaurantMenu.MenuAdi.Contains("Corbalar")).ToList();
            //    comboBox2.DisplayMember = "UrunAdi";
            //    comboBox2.ValueMember = "UrunID";
            //    foreach (var item in urun)
            //    {
            //        comboBox2.Items.Add(item);
            //    }
            //}
            //else if (comboBox1.SelectedIndex == 1)
            //{
            //    comboBox2.Items.Clear();
            //    var urun = db.Urunler.Where(u => u.RestaurantMenu.MenuAdi.Contains("Izgaralar")).ToList();
            //    comboBox2.DisplayMember = "UrunAdi";
            //    comboBox2.ValueMember = "UrunID";
            //    foreach (var item in urun)
            //    {
            //        comboBox2.Items.Add(item);
            //    }
            //}
            //else if (comboBox1.SelectedIndex == 2)
            //{
            //    comboBox2.Items.Clear();
            //    var urun = db.Urunler.Where(u => u.RestaurantMenu.MenuAdi.Contains("Kebaplar")).ToList();
            //    comboBox2.DisplayMember = "UrunAdi";
            //    comboBox2.ValueMember = "UrunID";
            //    foreach (var item in urun)
            //    {
            //        comboBox2.Items.Add(item);
            //    }
            //}
            //else if (comboBox1.SelectedIndex == 3)
            //{
            //    comboBox2.Items.Clear();
            //    var urun = db.Urunler.Where(u => u.RestaurantMenu.MenuAdi.Contains("Donerler")).ToList();
            //    comboBox2.DisplayMember = "UrunAdi";
            //    comboBox2.ValueMember = "UrunID";
            //    foreach (var item in urun)
            //    {
            //        comboBox2.Items.Add(item);
            //    }
            //}
            //else if (comboBox1.SelectedIndex == 4)
            //{
            //    comboBox2.Items.Clear();
            //    var urun = db.Urunler.Where(u => u.RestaurantMenu.MenuAdi.Contains("Lahmacunlar")).ToList();
            //    comboBox2.DisplayMember = "UrunAdi";
            //    comboBox2.ValueMember = "UrunID";
            //    foreach (var item in urun)
            //    {
            //        comboBox2.Items.Add(item);
            //    }
            //}
            //else if (comboBox1.SelectedIndex == 5)
            //{
            //    comboBox2.Items.Clear();
            //    var urun = db.Urunler.Where(u => u.RestaurantMenu.MenuAdi.Contains("Pideler")).ToList();
            //    comboBox2.DisplayMember = "UrunAdi";
            //    comboBox2.ValueMember = "UrunID";
            //    foreach (var item in urun)
            //    {
            //        comboBox2.Items.Add(item);
            //    }
            //}
            //else if (comboBox1.SelectedIndex == 6)
            //{
            //    comboBox2.Items.Clear();
            //    var urun = db.Urunler.Where(u => u.RestaurantMenu.MenuAdi.Contains("Salatalar")).ToList();
            //    comboBox2.DisplayMember = "UrunAdi";
            //    comboBox2.ValueMember = "UrunID";
            //    foreach (var item in urun)
            //    {
            //        comboBox2.Items.Add(item);
            //    }
            //}
            //else if (comboBox1.SelectedIndex == 7)
            //{
            //    comboBox2.Items.Clear();
            //    var urun = db.Urunler.Where(u => u.RestaurantMenu.MenuAdi.Contains("Mezeler")).ToList();
            //    comboBox2.DisplayMember = "UrunAdi";
            //    comboBox2.ValueMember = "UrunID";
            //    foreach (var item in urun)
            //    {
            //        comboBox2.Items.Add(item);
            //    }
            //}
            //else if (comboBox1.SelectedIndex == 8)
            //{
            //    comboBox2.Items.Clear();
            //    var urun = db.Urunler.Where(u => u.RestaurantMenu.MenuAdi.Contains("Sıcak İçecekler")).ToList();
            //    comboBox2.DisplayMember = "UrunAdi";
            //    comboBox2.ValueMember = "UrunID";
            //    foreach (var item in urun)
            //    {
            //        comboBox2.Items.Add(item);
            //    }
            //}
            //else if (comboBox1.SelectedIndex == 9)
            //{
            //    comboBox2.Items.Clear();
            //    var urun = db.Urunler.Where(u => u.RestaurantMenu.MenuAdi.Contains("Soguk İçecekler")).ToList();
            //    comboBox2.DisplayMember = "UrunAdi";
            //    comboBox2.ValueMember = "UrunID";
            //    foreach (var item in urun)
            //    {
            //        comboBox2.Items.Add(item);
            //    }
            //}
            //else if (comboBox1.SelectedIndex == 10)
            //{
            //    comboBox2.Items.Clear();
            //    var urun = db.Urunler.Where(u => u.RestaurantMenu.MenuAdi.Contains("Tatlılar")).ToList();
            //    comboBox2.DisplayMember = "UrunAdi";
            //    comboBox2.ValueMember = "UrunID";
            //    foreach (var item in urun)
            //    {
            //        comboBox2.Items.Add(item);
            //    }
            //}



        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SiparisUrunDetay s = new SiparisUrunDetay();
            s.SiparisID = Convert.ToInt32(textBoxID.Text);
            s.UrunID = secili.UrunID;
            s.Adet = Convert.ToInt16(textBoxAdet.Text);
            s.Tutar = Convert.ToDecimal((secili.Fiyat) * (s.Adet));
            db.SiparisUrunDetay.Add(s);
            db.SaveChanges();
            var result5 = from sp in db.SiparisUrunDetay
                          where sp.Siparisler.Durum.ToString().Contains("True")
                          select new
                          {
                              sp.Siparisler.SiparisID,
                              sp.Siparisler.Musteriler.MusteriID,
                              sp.Siparisler.Musteriler.MusteriAdi,
                              sp.Urunler.UrunAdi,
                              sp.Adet,
                              sp.Tutar
                          };

            dataGridView2.DataSource = result5.ToList();
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

       

        Siparisler si = new Siparisler();
        private void button2_Click(object sender, EventArgs e)
        {
            si.MusteriID = Convert.ToInt16(textBox1.Text);
            si.OdemeYontemID = Convert.ToInt32(comboBox3.SelectedIndex + 1);
            si.SiparişKanaliID = Convert.ToInt32(comboBox4.SelectedIndex + 1);
            si.SiparistenSorumluCalisan = comboBox5.SelectedIndex + 1;
            si.SiparişZamani = DateTime.Now;
            si.Durum = true;
            if (textBox2.Text == "" || textBox2.Text == "Adres Giriniz")
            {
                si.GonderilenAdres = "Masa Müsterisi";
            }
            else
            {
                si.GonderilenAdres = textBox2.Text;
            }
            db.Siparisler.Add(si);
            db.SaveChanges();
        }

        Urunler secili;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            secili = db.Urunler.Find(id);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            textBox1.Text = "MusteriID Giriniz";
            textBox2.Text = "Adres Giriniz";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }

        private void textBoxID_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
        }

        private void textBoxAdet_Click(object sender, EventArgs e)
        {
            textBoxAdet.Text = "";
        }
    }

}
