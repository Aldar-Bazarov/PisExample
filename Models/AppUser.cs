//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PisFirst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AppUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AppUser()
        {
            this.RegistrationCard = new HashSet<RegistrationCard>();
        }
    
        public int u_id { get; set; }
        public string u_first_name { get; set; }
        public string u_second_name { get; set; }
        public string u_phone_number { get; set; }
        public string u_login { get; set; }
        public string u_password { get; set; }
        public Nullable<int> ur_id { get; set; }
        public Nullable<int> om_id { get; set; }
        public Nullable<int> or_id { get; set; }
    
        public virtual Omsu Omsu { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual UserRole UserRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistrationCard> RegistrationCard { get; set; }
    }
}
