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
    
    public partial class CalisanDetay
    {
        public int CalisanID { get; set; }
        public string TCKN { get; set; }
        public System.DateTime DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string CalisanTelefonNumarasi { get; set; }
        public string CalisanAdresi { get; set; }
        public string CalisanEmail { get; set; }
        public decimal CalisanMaasi { get; set; }
    
        public virtual Calisanlar Calisanlar { get; set; }
    }
}
