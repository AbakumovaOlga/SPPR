using SPPR_Services.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR_Services.Interfaces
{
    public interface ITelepParamService
    {

        void CreateElement(TelepParamBM model);

        void UpdElement(TelepParamBM model);

        void DelElement(TelepParamBM model);

        List<TelepParamBM> GetList();

        TelepParamBM GetElement(int id);

        TelepParamBM GetElement(int paramId, int telepId);
    }
}
