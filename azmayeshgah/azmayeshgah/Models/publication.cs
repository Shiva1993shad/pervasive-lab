//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace azmayeshgah.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class publication
    {
        public int pub_id { get; set; }
        public string authors { get; set; }
        public string title { get; set; }
        public string jcon { get; set; }
        public int year { get; set; }
        public bool active { get; set; }
        public string type { get; set; }
        public string place { get; set; }
        public string descrip { get; set; }
        public Nullable<int> people_id { get; set; }
    
        public virtual person person { get; set; }
    }
}
