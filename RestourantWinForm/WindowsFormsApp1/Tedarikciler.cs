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
    
    public partial class Tedarikciler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tedarikciler()
        {
            this.TedarikEdilenMalzemeler = new HashSet<TedarikEdilenMalzemeler>();
        }
    
        public int TedarikciID { get; set; }
        public string TedarikciAdi { get; set; }
        public string TelefonNumarasi { get; set; }
        public string TeslimatGünü { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TedarikEdilenMalzemeler> TedarikEdilenMalzemeler { get; set; }
    }
}
