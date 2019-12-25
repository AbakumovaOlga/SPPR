using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR
{
    public class Parametr
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Choosing { get; set; }

        [ForeignKey("ParametrId")]
        public virtual List<TelepParam> TelepParams { get; set; }

        [ForeignKey("ParametrId")]
        public virtual List<MarkParametr> MarkParametrs { get; set; }



    }
}
