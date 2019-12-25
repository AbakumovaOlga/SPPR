using SPPR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR_Services.BindingModels
{
    public class ParametrBM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Choosing { get; set; }

        public virtual List<TelepParam> TelepParams { get; set; }

        public virtual List<MarkParametr> MarkParametrs { get; set; }


       
    }
}
