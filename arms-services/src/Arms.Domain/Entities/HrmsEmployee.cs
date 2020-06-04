﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Arms.Domain.Entities
{
    public partial class HrmsEmployee
    {
        public HrmsEmployee()
        {
            Images = new HashSet<Images>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CygCode { get; set; }
        public string Designation { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

        public ICollection<Images> Images { get; set; }
    }
}