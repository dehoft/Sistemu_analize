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
    
    public partial class eventt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public eventt()
        {
            this.programs = new HashSet<program>();
            this.tournaments = new HashSet<tournament>();
        }
    
        public int id { get; set; }
        public System.DateTime start_time { get; set; }
        public System.DateTime finish_time { get; set; }
        public string name { get; set; }
        public Nullable<int> fk_program { get; set; }
        public Nullable<int> fk_tournament { get; set; }
    
        public virtual tournament tournament { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<program> programs { get; set; }
        public virtual program program { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tournament> tournaments { get; set; }
    }
}