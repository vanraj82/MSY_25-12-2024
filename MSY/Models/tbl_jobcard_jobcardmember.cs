//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSY.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_jobcard_jobcardmember
    {
        public int id { get; set; }
        public int jobcard_id { get; set; }
        public int jobcardmember_id { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual Tbl_JobCard Tbl_JobCard { get; set; }
        public virtual tbl_jobcardmembers tbl_jobcardmembers { get; set; }
    }
}
