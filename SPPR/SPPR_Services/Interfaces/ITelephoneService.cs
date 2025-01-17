﻿using SPPR_Services.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR_Services.Interfaces
{
    public interface ITelephoneService
    {
        void CreateElement(TelephoneBM model);

        void UpdElement(TelephoneBM model);

        void DelElement(TelephoneBM model);

        List<TelephoneBM> GetList();

        TelephoneBM GetElement(int id);
    }
}
