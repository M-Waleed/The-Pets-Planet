//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FypOnEF.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vendor_Product_Cost
    {
        public int VPC_Id { get; set; }
        public int VPQ_Id { get; set; }
        public int Vendor_Price { get; set; }
        public int Company_Price { get; set; }
    
        public virtual Vendor_Product_Qty Vendor_Product_Qty { get; set; }
    }
}
