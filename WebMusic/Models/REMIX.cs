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
    
    public partial class REMIX
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REMIX()
        {
            this.REMIX_ARTIST = new HashSet<REMIX_ARTIST>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public Nullable<int> TEMPO { get; set; }
        public string KEY_ { get; set; }
        public Nullable<double> COST { get; set; }
        public string LINK { get; set; }
        public Nullable<System.DateTime> DATE_RELEASE { get; set; }
        public string LINK_IMG { get; set; }
        public Nullable<int> ID_TRACK { get; set; }
        public string LENGTH { get; set; }
        public string GENRE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REMIX_ARTIST> REMIX_ARTIST { get; set; }
        public virtual TRACK TRACK { get; set; }
    }
}
