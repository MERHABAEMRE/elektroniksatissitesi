//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElektronikSatisi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserKupon
    {
        public int id { get; set; }
        public Nullable<int> Uuserid { get; set; }
        public Nullable<int> Ukuponid { get; set; }
    
        public virtual Kuponlar Kuponlar { get; set; }
        public virtual UserLogin UserLogin { get; set; }
    }
}
