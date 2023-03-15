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
    public partial class SiparisKanalOdemeYontem : Form
    {
        public SiparisKanalOdemeYontem()
        {
            InitializeComponent();
        }
        RestaurantEntities1 db = new RestaurantEntities1();
        private void SiparisKanalOdemeYontem_Load(object sender, EventArgs e)
        {
            Yenile1();

            Yenile2();
        }

        private void Yenile2()
        {
            var result2 = from o in db.OdemeYontemleri
                          select new
                          {
                              o.OdemeYontemID,
                              o.YontemAdi,
                              o.Durum
                          };
            dataGridView2.DataSource = result2.ToList();
        }

        private void Yenile1()
        {
            var result = from s in db.SiparisKanallari
                         select new
                         {
                             s.SiparisKanaliID,
                             s.SiparisKanaliAdi,
                             s.Durum
                         };
            dataGridView1.DataSource = result.ToList();
        }

       
        SiparisKanallari secili;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            secili = db.SiparisKanallari.Find(id);
            checkBox1.Checked = secili.Durum;
        }

        OdemeYontemleri secili2;
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView2.Rows[e.RowIndex].Cells[0].Value;
            secili2 = db.OdemeYontemleri.Find(id);
            checkBox2.Checked = secili2.Durum;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secili.Durum = checkBox1.Checked;
            db.SaveChanges();
            Yenile1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secili2.Durum = checkBox2.Checked;
            db.SaveChanges();
            Yenile2();
        }
    }
}
