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
    
    public partial class CalendarEvent
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string EventDesciption { get; set; }
        public Nullable<int> HamiId { get; set; }
        public Nullable<int> MadadkarId { get; set; }
        public string HamiName { get; set; }
        public Nullable<bool> Deleted { get; set; }
    }
}
