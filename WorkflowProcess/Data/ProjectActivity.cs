//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkflowProcess.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProjectActivity
    {
        public int ProjectActivityId { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<int> ActivityId { get; set; }
        public Nullable<int> ActivityStatusId { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> ActionedOn { get; set; }
        public string ActionedBy { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual ActivityStatus ActivityStatus { get; set; }
        public virtual Project Project { get; set; }
    }
}
