﻿using System;
using System.Collections.Generic;

namespace Project_1.Models
{
    public partial class EmpProfile
    {
        public int EmpCode { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? EmpName { get; set; }
        public string? Email { get; set; }
        public int? DeptCode { get; set; }

        public virtual DeptMaster? DeptCodeNavigation { get; set; }
    }
}
