using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR
{
    public class User
    {
        public int Id { get; set; }

        public string FIO { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        [ForeignKey("UserId")]
        public List<MarkParametr> MarkParametrs { get; set; }
    }
}
