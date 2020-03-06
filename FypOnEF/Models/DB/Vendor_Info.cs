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
    
    public partial class Vendor_Info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vendor_Info()
        {
            this.Product_Inventory = new HashSet<Product_Inventory>();
        }
    
        public int VI_Id { get; set; }
        public string VI_CNIC { get; set; }
        public string VI_Province { get; set; }
        public string VI_City { get; set; }
        public int US_Id { get; set; }
        public Nullable<int> VI_Approved { get; set; }
        public Nullable<int> VI_NotApproved { get; set; }
        public Nullable<int> VendorImage_Id { get; set; }
        public Nullable<double> VI_Commission { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Inventory> Product_Inventory { get; set; }
        public virtual User_Info User_Info { get; set; }
        public virtual Vendor_Image Vendor_Image { get; set; }
    }
}