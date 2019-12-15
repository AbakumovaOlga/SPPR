using SPPR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR_Services.BindingModels
{
    public class TelephoneBM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Data { get; set; }

        public List<TelepParam> TelepParams { get; set; }
    }
}
