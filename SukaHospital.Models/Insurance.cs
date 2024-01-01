﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sukaHospital.Models
{
    public class Insurance
    {
        public int Id { get; set; }
        public string PolicyNumber { get; set; }
        public ICollection<Bill> Bill { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

    }
}
