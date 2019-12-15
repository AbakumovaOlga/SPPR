using SPPR;
using SPPR_Services.BindingModels;
using SPPR_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR_Services.ImplementationBD
{
    public class TelepParamServiceBD : ITelepParamService
    {
        private SPPRDbContext context;

        public TelepParamServiceBD(SPPRDbContext context)
        {
            this.context = context;
        }

        public void CreateElement(TelepParamBM model)
        {
            TelepParam element = context.TelepParams.FirstOrDefault(rec => rec.ParametrId == model.ParametrId && rec.TelephoneId == model.TelephoneId);
            if (element != null)
            {
                throw new Exception("Уже есть такой параметр телефона");
            }
            context.TelepParams.Add(new TelepParam
            {
                ParametrId = model.ParametrId,
                TelephoneId = model.TelephoneId
            });
            context.SaveChanges();
        }

        public void DelElement(TelepParamBM model)
        {
            TelepParam element = context.TelepParams.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.TelepParams.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public TelepParamBM GetElement(int id)
        {
            TelepParam element = context.TelepParams.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new TelepParamBM
                {
                    Id = element.Id,
                    ParametrId = element.ParametrId,
                    TelephoneId = element.TelephoneId,
                    Value = element.Value
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<TelepParamBM> GetList()
        {
            List<TelepParamBM> result = context.TelepParams
                .Select(rec => new TelepParamBM
                {
                    Id = rec.Id,
                    ParametrId = rec.ParametrId,
                    TelephoneId = rec.TelephoneId,
                    Value = rec.Value
                })
                .ToList();
            return result;
        }

        public void UpdElement(TelepParamBM model)
        {
            throw new NotImplementedException();
        }
    }
}
