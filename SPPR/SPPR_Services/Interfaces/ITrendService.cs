using SPPR_Services.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR_Services.Interfaces
{
    public interface ITrendService
    {
        void CreateElement(TrendBM model);

        void UpdElement(TrendBM model);

        void DelElement(TrendBM model);

        List<TrendBM> GetList();

        bool DeleteAll();

        TrendBM GetElement(int id);
    }
}
