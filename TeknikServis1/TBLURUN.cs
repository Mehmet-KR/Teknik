//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikServis1
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLURUN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLURUN()
        {
            this.TBLURUNHAREKET = new HashSet<TBLURUNHAREKET>();
        }
    
        public int ID { get; set; }
        public string AD { get; set; }
        public string MARKA { get; set; }
        public Nullable<decimal> ALISFIYAT { get; set; }
        public Nullable<decimal> SATISFIYAT { get; set; }
        public Nullable<short> STOKSAYISI { get; set; }
        public Nullable<byte> KATEGORI { get; set; }
        public Nullable<bool> DURUM { get; set; }
        public Nullable<bool> durum2 { get; set; }
    
        public virtual TBLKATEGORI TBLKATEGORI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLURUNHAREKET> TBLURUNHAREKET { get; set; }
    }
}
