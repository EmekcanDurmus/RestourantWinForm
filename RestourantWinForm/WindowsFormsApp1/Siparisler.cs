//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Siparisler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Siparisler()
        {
            this.SiparisUrunDetay = new HashSet<SiparisUrunDetay>();
        }
    
        public int SiparisID { get; set; }
        public int SiparişKanaliID { get; set; }
        public int MusteriID { get; set; }
        public int OdemeYontemID { get; set; }
        public int SiparistenSorumluCalisan { get; set; }
        public string GonderilenAdres { get; set; }
        public System.DateTime SiparişZamani { get; set; }
        public Nullable<bool> Durum { get; set; }
    
        public virtual Calisanlar Calisanlar { get; set; }
        public virtual Musteriler Musteriler { get; set; }
        public virtual OdemeYontemleri OdemeYontemleri { get; set; }
        public virtual SiparisKanallari SiparisKanallari { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SiparisUrunDetay> SiparisUrunDetay { get; set; }
    }
}
