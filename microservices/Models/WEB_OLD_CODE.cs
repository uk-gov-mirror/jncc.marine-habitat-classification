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
    
    public partial class WEB_OLD_CODE
    {
        public string BIOTOPE_KEY { get; set; }
        public string OLD_CODE { get; set; }
        public string VERSION { get; set; }
    
        public virtual WEB_BIOTOPE WEB_BIOTOPE { get; set; }
    }
}
