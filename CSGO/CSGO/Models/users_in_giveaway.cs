//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSGO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class users_in_giveaway
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public users_in_giveaway()
        {
            this.giveaways = new HashSet<giveaway>();
        }
    
        public int id { get; set; }
        public int fk_user { get; set; }
        public int fk_giveaway { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<giveaway> giveaways { get; set; }
        public virtual giveaway giveaway { get; set; }
        public virtual user user { get; set; }
    }
}