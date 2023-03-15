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
    public partial class Tedarik : Form
    {
        public Tedarik()
        {
            InitializeComponent();
        }
        RestaurantEntities1 db = new RestaurantEntities1();
        private void Tedarik_Load(object sender, EventArgs e)
        {
            

            Yenile1();

            //-------------------------------------------------

            Yenile2();
        }

        private void Temizle2()
        {
            textBox2.Text = "Tedarikçi Adi";
            textBox3.Text = "Telefon Numarasi";
            textBox4.Text = "Teslimat Günü";
        }
        private void Temizle1()
        {
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown1.Value = 0;
            textBox1.Text = "Ürün Adi Giriniz";
        }
        private void Yenile2()
        {
            var result2 = from t in db.Tedarikciler
                          select new
                          {
                              t.TedarikciID,
                              t.TedarikciAdi,
                              t.TelefonNumarasi,
                              t.TeslimatGünü,
                          };
            dataGridView2.DataSource = result2.ToList();
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Temizle2();
        }

        private void Yenile1()
        {
            var result = from tem in db.TedarikEdilenMalzemeler
                         select new
                         {
                             tem.MalzemeID,
                             tem.RestaurantID,
                             tem.MalzemeAdi,
                             tem.RestaurantStok,
                             tem.DepoStok
                         };
            dataGridView1.DataSource = result.ToList();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            Temizle1();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Yenile1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Yenile2();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TedarikEdilenMalzemeler tem = new TedarikEdilenMalzemeler();
            tem.RestaurantID = (int)numericUpDown1.Value;
            tem.MalzemeAdi = textBox1.Text;
            tem.RestaurantStok = (int)numericUpDown2.Value;
            tem.DepoStok = (int)numericUpDown3.Value;
            db.TedarikEdilenMalzemeler.Add(tem);
            db.SaveChanges();
            Yenile1();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        TedarikEdilenMalzemeler secili1;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id1 = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            secili1 = db.TedarikEdilenMalzemeler.Find(id1);
            numericUpDown1.Value = secili1.RestaurantID;
            textBox1.Text = secili1.MalzemeAdi;
            numericUpDown2.Value = secili1.RestaurantStok;
            numericUpDown3.Value = secili1.DepoStok;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {            
            secili1.RestaurantID = (int)numericUpDown1.Value;
            secili1.MalzemeAdi = textBox1.Text;
            secili1.RestaurantStok = (int)numericUpDown2.Value;
            secili1.DepoStok = (int)numericUpDown3.Value;
            db.SaveChanges();
            Yenile1();
        }

        private void btnEkle2_Click(object sender, EventArgs e)
        {
            Tedarikciler t = new Tedarikciler();
            t.TedarikciAdi = textBox2.Text;
            t.TelefonNumarasi = textBox3.Text;
            t.TeslimatGünü = textBox4.Text;
            db.Tedarikciler.Add(t);
            db.SaveChanges();
            Yenile2();
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

        Tedarikciler secili2 = new Tedarikciler();
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id2 = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            secili2 = db.Tedarikciler.Find(id2);
            textBox2.Text = secili2.TedarikciAdi;
            textBox3.Text = secili2.TelefonNumarasi;
            textBox4.Text = secili2.TeslimatGünü;
        }

        private void btnGuncelle2_Click(object sender, EventArgs e)
        {
            secili2.TedarikciAdi = textBox2.Text;
            secili2.TelefonNumarasi = textBox3.Text;
            secili2.TeslimatGünü = textBox4.Text;
            db.SaveChanges();
            Yenile2();
        }
    }
}
