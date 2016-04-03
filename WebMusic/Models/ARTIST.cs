//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebMusic.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ARTIST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ARTIST()
        {
            this.SHOWs = new HashSet<SHOW>();
            this.TRACK_ARTIST = new HashSet<TRACK_ARTIST>();
            this.GENREs = new HashSet<GENRE>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public string BORN { get; set; }
        public Nullable<System.DateTime> DATE { get; set; }
        public string DESCRIP { get; set; }
        public string TW { get; set; }
        public string FB { get; set; }
        public Nullable<short> ID_NOW_LABEL { get; set; }
        public string IMG { get; set; }
    
        public virtual LABEL LABEL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHOW> SHOWs { get; set; }
        public virtual STATISTIC_ARTIST STATISTIC_ARTIST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRACK_ARTIST> TRACK_ARTIST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GENRE> GENREs { get; set; }
    }
}
