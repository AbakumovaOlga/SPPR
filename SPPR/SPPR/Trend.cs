﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR
{
   public  class Trend
    {
        public int Id { get; set; }
        public Marks First { get; set; }
        public Marks Second { get; set; }
        public Marks Third { get; set; }
        public int? Count { get; set; }
        public string Name { get; set; }
    }
}
