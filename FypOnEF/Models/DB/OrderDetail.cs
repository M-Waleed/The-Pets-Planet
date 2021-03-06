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
    
    public partial class OrderDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderDetail()
        {
            this.OrderItems = new HashSet<OrderItem>();
        }
    
        public int OD_Id { get; set; }
        public Nullable<int> US_Id { get; set; }
        public string DeliveryAddress { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<int> Totalitem { get; set; }
        public string US_Name { get; set; }
        public string OrderStatus { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
    
        public virtual User_Info User_Info { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
