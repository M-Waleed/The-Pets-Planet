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
    
    public partial class OrderItem
    {
        public int OrderitemID { get; set; }
        public Nullable<int> OD_Id { get; set; }
        public Nullable<int> VPC_Id { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<int> QuantityOrder { get; set; }
        public Nullable<decimal> TotalItemPrice { get; set; }
    
        public virtual OrderDetail OrderDetail { get; set; }
    }
}