//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pets_Inventory
    {
        public int PetInventory_Id { get; set; }
        public Nullable<int> PetsC3_Id { get; set; }
        public Nullable<int> US_Id { get; set; }
        public Nullable<int> PetsWarehouse_Id { get; set; }
    
        public virtual Pets_Warehouse Pets_Warehouse { get; set; }
        public virtual Pets_C3 Pets_C3 { get; set; }
        public virtual User_Info User_Info { get; set; }
    }
}