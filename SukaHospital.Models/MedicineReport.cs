﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sukaHospital.Models
{
    public class MedicineReport
    {

        public  int Id { get; set; }
        public int Quantity { get; set; }
        public Supplier Supplier { get; set; }

        public Medicine Medicine { get; set; }

        public string Company { get; set; }
            public DateTime ExpireDate { get; set; }
        public DateTime ProductionDate { get; set; }

        public string Country { get; set; }

    }
}
