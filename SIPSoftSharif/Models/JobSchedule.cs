//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIPSoftSharif.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobSchedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JobSchedule()
        {
            this.JobShift = new HashSet<JobShift>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> JobDate { get; set; }
        public Nullable<System.DateTime> RegisterStart { get; set; }
        public Nullable<System.DateTime> RegisterEnd { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobShift> JobShift { get; set; }
    }
}