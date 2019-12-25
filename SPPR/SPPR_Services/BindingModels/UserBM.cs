using SPPR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR_Services.BindingModels
{
   public class UserBM
    {
        public int Id { get; set; }

        public string FIO { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
        public List<MarkParametr> MarkParametrs { get; set; }
    }
}
