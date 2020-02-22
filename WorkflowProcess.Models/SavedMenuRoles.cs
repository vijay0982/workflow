﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowProcess.Models
{
    [Table("SavedMenuRoles")]
    public class SavedMenuRoles
    {
        [Key]
        public int SavedMenuRoleId { get; set; }
        public int MenuId { get; set; }
        public int RoleId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool Status { get; set; }
    }
}
