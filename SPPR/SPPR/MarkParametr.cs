using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR
{
    public class MarkParametr
    {

        public int Id { get; set; }

        public Marks Mark { get; set; }
        public int Down { get; set; }
        public int Average { get; set; }
        public int Up { get; set; }
        public int Count { get; set; }

        public bool Cheking { get; set; }

        public int ParametrId { get; set; }

        public virtual Parametr Parametr { get; set; }


        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
