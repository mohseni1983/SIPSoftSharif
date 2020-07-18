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
    
    public partial class PayRequests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PayRequests()
        {
            this.PaymentDetails = new HashSet<PaymentDetails>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> HamiId { get; set; }
        public string HamiName { get; set; }
        public Nullable<int> MadadkarId { get; set; }
        public string MadadkarName { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public string TransactionId { get; set; }
        public string UniqeId { get; set; }
        public string PayDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentDetails> PaymentDetails { get; set; }
    }
}