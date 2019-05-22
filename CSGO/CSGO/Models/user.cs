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
    
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            this.evaluations = new HashSet<evaluation>();
            this.places = new HashSet<place>();
            this.users_bets = new HashSet<users_bets>();
            this.users_in_giveaway = new HashSet<users_in_giveaway>();
        }
    
        public int id { get; set; }
        public int fk_person { get; set; }
        public Nullable<int> fk_ticket { get; set; }
        public Nullable<int> fk_users_bets { get; set; }
        public Nullable<int> fk_giveaway { get; set; }
        public Nullable<int> fk_evaluation { get; set; }
        public Nullable<int> fk_place { get; set; }
    
        public virtual evaluation evaluation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<evaluation> evaluations { get; set; }
        public virtual giveaway giveaway { get; set; }
        public virtual person person { get; set; }
        public virtual place place { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<place> places { get; set; }
        public virtual ticket ticket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<users_bets> users_bets { get; set; }
        public virtual users_bets users_bets1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<users_in_giveaway> users_in_giveaway { get; set; }
    }
}