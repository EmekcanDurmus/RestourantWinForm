using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Rezervasyon : Form
    {
        public Rezervasyon()
        {
            InitializeComponent();
        }
        RestaurantEntities1 db = new RestaurantEntities1();
        private void Yenile()
        {
            var result = from r in db.Rezervasyonlar
                         select new
                         {
                             r.ReverzasyonID,
                             Ad = r.Musteriler.MusteriAdi,
                             Soyad = r.Musteriler.MusteriSoyAdi,
                             TelNo = r.Musteriler.MusteriTelefonNumarasi,
                             r.RezervasyonTarihi,
                             r.Masa.Bolumler.BolumAdi,
                             r.Masa.MasaID
                         };
            dataGridView1.DataSource = result.ToList();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[4].Width = 100;



            dateTimePicker1.Value = DateTime.Now;
            comboBox1.Text = "Bölüm Seçiniz";
            comboBox2.Text = "Masa Seçiniz";
            textBox1.Text = "Müsteri ID'sini Giriniz";


        }
        private void Rezervasyon_Load(object sender, EventArgs e)
        {
            Yenile();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd hh:mm:ss";

            //------------------------------------------------------------


            var bolumler = db.Bolumler.ToList();
            comboBox1.DisplayMember = "BolumAdi";
            comboBox1.ValueMember = "BolumID";
            foreach (var item in bolumler)
            {
                comboBox1.Items.Add(item);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                var masalar = db.Masa.Where(m => m.Bolumler.BolumAdi.Contains("Bahçe")).ToList();
                comboBox2.DisplayMember = "MasaID";
                comboBox2.ValueMember = "MasaID";
                foreach (var item in masalar)
                {
                    comboBox2.Items.Add(item);
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                var masalar = db.Masa.Where(m => m.Bolumler.BolumAdi.Contains("Salon1")).ToList();
                comboBox2.DisplayMember = "MasaID";
                comboBox2.ValueMember = "MasaID";
                foreach (var item in masalar)
                {
                    comboBox2.Items.Add(item);
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Clear();
                var masalar = db.Masa.Where(m => m.Bolumler.BolumAdi.Contains("Salon2")).ToList();
                comboBox2.DisplayMember = "MasaID";
                comboBox2.ValueMember = "MasaID";
                foreach (var item in masalar)
                {
                    comboBox2.Items.Add(item);
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                comboBox2.Items.Clear();
                var masalar = db.Masa.Where(m => m.Bolumler.BolumAdi.Contains("Teras")).ToList();
                comboBox2.DisplayMember = "MasaID";
                comboBox2.ValueMember = "MasaID";
                foreach (var item in masalar)
                {
                    comboBox2.Items.Add(item);
                }
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Yenile();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            Rezervasyonlar r = new Rezervasyonlar();

            r.MusteriID = Convert.ToInt32(textBox1.Text);
            r.MasaID = Convert.ToInt32(comboBox2.Text);
            r.RezervasyonTarihi = dateTimePicker1.Value;
            db.Rezervasyonlar.Add(r);
            db.SaveChanges();
            Yenile();

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedCells[0].Value;
            db.Rezervasyonlar.Remove(db.Rezervasyonlar.Find(id));
            db.SaveChanges();
            Yenile();
        }
    }
}
