//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HastaneProgrami.Models.Entity_Framework
{
    using System;
    using System.Collections.Generic;
    
    public partial class ameliyatSonuc
    {
        public int ameliyatSonucID { get; set; }
        public Nullable<int> ameliyatID { get; set; }
        public Nullable<int> hastaneOdaID { get; set; }
        public Nullable<bool> ameliyatDurum { get; set; }
        public Nullable<bool> hastaDurum { get; set; }
        public Nullable<bool> durum { get; set; }
        public Nullable<System.DateTime> ameliyatBitisTarih { get; set; }
    
        public virtual ameliyat ameliyat { get; set; }
        public virtual hastaneOda hastaneOda { get; set; }
    }
}
