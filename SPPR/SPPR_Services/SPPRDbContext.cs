using SPPR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR_Services
{
    [Table("SPPRDatabase")]
    public class SPPRDbContext : DbContext
    {
        public SPPRDbContext()
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }


        public virtual DbSet<MarkParametr> MarkParametrs { get; set; }

        public virtual DbSet<Parametr> Parametrs { get; set; }

        public virtual DbSet<Telephone> Telephones { get; set; }

        public virtual DbSet<TelepParam> TelepParams { get; set; }

        public virtual DbSet<Trend> Trends { get; set; }
    }
}
