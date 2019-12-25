﻿using SPPR;
using SPPR_Services.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR_Services.Interfaces
{
    public interface IMarkParamService
    {
        void CreateElement(MarkParametr model);

        void UpdElement(MarkParametrBM model);

        void DelElement(MarkParametrBM model);

        List<MarkParametrBM> GetList();

        List<MarkParametrBM> GetList(ParametrBM parametr, int userId);

        MarkParametrBM GetElement(int id);

        MarkParametrBM GetElement(int idParam, Marks mark);
    }
}
