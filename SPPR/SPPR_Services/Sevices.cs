using SPPR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR_Services
{
    public class Sevices
    {
    }

    public class ParamMark
    {
        public int Id { get; set; }

        public string par { get; set; }

        public Marks Mark { get; set; }
    }

    public class Telep 
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }
    }

    public class TelepComparer : IComparer<Telep>
    {
        public int Compare(Telep t1, Telep t2)
        {
          //  if (t1.order.Equals(" ") || o2.order.Equals(" ")) { return 0; }
            if (t1.Date > t2.Date)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
