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
    
    public partial class ameliyatKadro
    {
        public int ameliyatKadroID { get; set; }
        public Nullable<int> ameliyatEkipID { get; set; }
        public Nullable<int> personelID { get; set; }
        public Nullable<bool> durum { get; set; }
        public Nullable<System.DateTime> tarih { get; set; }
    
        public virtual personel personel { get; set; }
        public virtual ameliyatEkip ameliyatEkip { get; set; }
    }
}
