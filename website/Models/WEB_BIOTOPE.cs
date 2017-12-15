//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace website.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WEB_BIOTOPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WEB_BIOTOPE()
        {
            this.WEB_BIOT_RELATION = new HashSet<WEB_BIOT_RELATION>();
            this.WEB_BIOT_RELATION1 = new HashSet<WEB_BIOT_RELATION>();
            this.WEB_BIOT_SPECIES_GRAB = new HashSet<WEB_BIOT_SPECIES_GRAB>();
            this.WEB_BIOT_SPECIES_OBSERVATION = new HashSet<WEB_BIOT_SPECIES_OBSERVATION>();
            this.WEB_BIOTOPE_HIERARCHY = new HashSet<WEB_BIOTOPE_HIERARCHY>();
            this.WEB_BIOTOPE_HIERARCHY1 = new HashSet<WEB_BIOTOPE_HIERARCHY>();
            this.WEB_OLD_CODE = new HashSet<WEB_OLD_CODE>();
        }
    
        public string BIOTOPE_KEY { get; set; }
        public string ORIGINAL_CODE { get; set; }
        public string FULL_TERM { get; set; }
        public string DESCRIPTION { get; set; }
        public string SPECIAL_FEATURES { get; set; }
        public string TEMPORAL_VARIATION { get; set; }
        public string SITUATION { get; set; }
        public Nullable<short> FREQUENCY_KEY { get; set; }
        public string FREQUENCY { get; set; }
        public string LANDSCAPE { get; set; }
        public string SALINITY { get; set; }
        public string HEIGHT { get; set; }
        public string EXPOSURE { get; set; }
        public string TIDAL_STREAMS { get; set; }
        public string SUBZONE { get; set; }
        public string SUBSTRATUM { get; set; }
        public Nullable<short> SORT_CODE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WEB_BIOT_RELATION> WEB_BIOT_RELATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WEB_BIOT_RELATION> WEB_BIOT_RELATION1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WEB_BIOT_SPECIES_GRAB> WEB_BIOT_SPECIES_GRAB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WEB_BIOT_SPECIES_OBSERVATION> WEB_BIOT_SPECIES_OBSERVATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WEB_BIOTOPE_HIERARCHY> WEB_BIOTOPE_HIERARCHY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WEB_BIOTOPE_HIERARCHY> WEB_BIOTOPE_HIERARCHY1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WEB_OLD_CODE> WEB_OLD_CODE { get; set; }
    }
}
