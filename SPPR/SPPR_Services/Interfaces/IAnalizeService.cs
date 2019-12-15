using SPPR_Services.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR_Services.Interfaces
{
    public interface IAnalizeService
    {

        TelephoneBM GetAnalize(TelephoneBM idialTelephone);

        TelephoneBM GetPredict(TelephoneBM futureTelephone);

    }
}
