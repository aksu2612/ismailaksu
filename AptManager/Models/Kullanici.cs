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
    
    public partial class Kullanici
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public int Telefon { get; set; }
        public int Kapino { get; set; }
        public int Siteid { get; set; }
        public bool Onay { get; set; }
        public int BlokId { get; set; }
        public int KullaniciTipi { get; set; }
        public int BorcId { get; set; }
    }
}
