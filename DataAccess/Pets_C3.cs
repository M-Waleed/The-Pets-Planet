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
    
    public partial class Pets_C3
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pets_C3()
        {
            this.Pets_Image = new HashSet<Pets_Image>();
            this.Pets_Inventory = new HashSet<Pets_Inventory>();
        }
    
        public int PetsC3_Id { get; set; }
        public string PetsC3_Name { get; set; }
        public int PetsC2_Id { get; set; }
        public Nullable<int> PetsC1_Id { get; set; }
    
        public virtual Pets_C1 Pets_C1 { get; set; }
        public virtual Pets_C2 Pets_C2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pets_Image> Pets_Image { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pets_Inventory> Pets_Inventory { get; set; }
    }
}
