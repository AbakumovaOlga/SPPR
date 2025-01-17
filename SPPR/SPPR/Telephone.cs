﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR
{
    public class Telephone
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Data { get; set; }


        [ForeignKey("TelephoneId")]
        public List<TelepParam> TelepParams { get; set; }
    }
}
