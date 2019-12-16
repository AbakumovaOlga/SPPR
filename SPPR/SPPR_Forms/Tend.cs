using SPPR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR_Forms
{
    public class Tend
    {
        public Marks first;
        public Marks second;
        public Marks third;
        public int count = 0;
        public string name;

        public Tend(Marks first, Marks second, Marks third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
    }
}
