
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR_Services.BindingModels
{
   public class TelepParamBM
    {
        public int Id { get; set; }

        public int? Value { get; set; }

        public int TelephoneId { get; set; }
        public int ParametrId { get; set; }
    }
}
