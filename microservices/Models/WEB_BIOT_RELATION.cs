//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace microservices.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WEB_BIOT_RELATION
    {
        public string BIOTOPE_RELATION_KEY { get; set; }
        public string BIOTOPE_KEY { get; set; }
        public string RELATED_BIOTOPE_KEY { get; set; }
        public string COMMENT { get; set; }
    
        public virtual WEB_BIOTOPE WEB_BIOTOPE { get; set; }
        public virtual WEB_BIOTOPE WEB_BIOTOPE1 { get; set; }
    }
}
