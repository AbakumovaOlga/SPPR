using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR
{
   public  class TelepParam
    {
        public int Id { get; set; }


        public int? Value { get; set; }


        public int TelephoneId { get; set; }
        public int ParametrId { get; set; }

        public virtual Telephone Telephone { get; set; }
        public virtual Parametr Parametr { get; set; }
    }
}
