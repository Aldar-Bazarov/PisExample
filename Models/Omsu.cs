//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PisFirst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Omsu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Omsu()
        {
            this.AppUser = new HashSet<AppUser>();
            this.RegistrationCard = new HashSet<RegistrationCard>();
        }
    
        public int om_id { get; set; }
        public string om_name { get; set; }
        public Nullable<int> md_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppUser> AppUser { get; set; }
        public virtual MunicipalDistrict MunicipalDistrict { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistrationCard> RegistrationCard { get; set; }
    }
}
