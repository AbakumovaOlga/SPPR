using SPPR_Services.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR_Services.Interfaces
{
    public interface IParametrService
    {

        void CreateElement(ParametrBM model);

        void UpdElement(ParametrBM model);

        void DelElement(ParametrBM model);

        List<ParametrBM> GetList();

        ParametrBM GetElement(int id);
    }
}
