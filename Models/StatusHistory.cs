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
    
    public partial class StatusHistory
    {
        public int sh_id { get; set; }
        public Nullable<int> rc_id { get; set; }
        public System.DateTime as_changedate { get; set; }
        public string as_name { get; set; }
        public string or_name { get; set; }
    
        public virtual RegistrationCard RegistrationCard { get; set; }
    }
}
