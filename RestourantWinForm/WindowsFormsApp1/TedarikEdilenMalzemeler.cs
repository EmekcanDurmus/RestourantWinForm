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
    
    public partial class TedarikEdilenMalzemeler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TedarikEdilenMalzemeler()
        {
            this.Tedarikciler = new HashSet<Tedarikciler>();
        }
    
        public int MalzemeID { get; set; }
        public string MalzemeAdi { get; set; }
        public int RestaurantID { get; set; }
        public int RestaurantStok { get; set; }
        public int DepoStok { get; set; }
        public bool Durum { get; set; }
    
        public virtual Restaurant Restaurant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tedarikciler> Tedarikciler { get; set; }
    }
}