//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WardrobeApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Outfit
    {
        public int OutfitsID { get; set; }
        public string Name { get; set; }
        public string Occasion { get; set; }
        public string Season { get; set; }
        public int TopsID { get; set; }
        public int BottomsID { get; set; }
        public int ShoesID { get; set; }
        public int AccessoriesID { get; set; }
    
        public virtual Accessory Accessory { get; set; }
        public virtual Bottom Bottom { get; set; }
        public virtual Sho Sho { get; set; }
        public virtual Top Top { get; set; }
    }
}
