//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AptManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bildirim
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Icerik { get; set; }
        public System.DateTime Kayittarihi { get; set; }
        public System.DateTime Yayimtarihi { get; set; }
        public int Siteid { get; set; }
    }
}
