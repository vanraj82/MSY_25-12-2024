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
    
    public partial class tbl_ulb_targets
    {
        public int id { get; set; }
        public int ulb_id { get; set; }
        public string ulb_type { get; set; }
        public int fresh_target { get; set; }
        public Nullable<int> cumulative_target { get; set; }
        public Nullable<int> work_fresh_target { get; set; }
        public Nullable<int> work_cumulative_target { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    }
}
