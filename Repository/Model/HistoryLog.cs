//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class HistoryLog
    {
        public string UserId { get; set; }
        public string EntityKey { get; set; }
        public Nullable<System.DateTime> LoginDate { get; set; }
        public int LogId { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Entity Entity { get; set; }
    }
}