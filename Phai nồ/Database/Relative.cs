//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Đồ_án.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Relative
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Relative()
        {
            this.DetailUsers = new HashSet<DetailUser>();
        }
    
        public string CCCD { get; set; }
        public string FullName { get; set; }
        public Nullable<bool> Gender { get; set; }
        public string Occupation { get; set; }
        public string DateOfBirth { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Ethnic { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailUser> DetailUsers { get; set; }
    }
}
