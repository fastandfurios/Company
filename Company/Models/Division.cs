﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    public class Division
    {
        public int DivisionId { get; set; }
	    public string Name { get; set; }
	    public Employee Director { get; set; }
    }
}
