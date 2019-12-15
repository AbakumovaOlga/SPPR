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
    public class MarkParamServiceBD : IMarkParamService
    {
        private SPPRDbContext context;

        public MarkParamServiceBD(SPPRDbContext context)
        {
            this.context = context;
        }

        public void CreateElement(MarkParametrBM model)
        {
            MarkParametr element = context.MarkParametrs.FirstOrDefault(rec => rec.Mark == model.Mark && rec.ParametrId==model.ParametrId);
            if (element != null)
            {
                throw new Exception("Уже есть такой MarkParametr");
            }
            context.MarkParametrs.Add(new MarkParametr
            {
                Average=model.Average,
                Cheking=model.Cheking,
                Count=model.Count,
                Down=model.Down,
                Mark=model.Mark,
                ParametrId=model.ParametrId,
                Up=model.Up
            });
            context.SaveChanges();
        }

        public void DelElement(MarkParametrBM model)
        {
            MarkParametr element = context.MarkParametrs.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.MarkParametrs.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public MarkParametrBM GetElement(int id)
        {
            MarkParametr element = context.MarkParametrs.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new MarkParametrBM
                {
                    Id = element.Id,
                    Average = element.Average,
                    Cheking = element.Cheking,
                    Count = element.Count,
                    Down = element.Down,
                    Mark = element.Mark,
                    ParametrId = element.ParametrId,
                    Up = element.Up
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<MarkParametrBM> GetList()
        {
            List<MarkParametrBM> result = context.MarkParametrs
                .Select(rec => new MarkParametrBM
                {
                    Id = rec.Id,
                    Average = rec.Average,
                    Cheking = rec.Cheking,
                    Count = rec.Count,
                    Down = rec.Down,
                    Mark = rec.Mark,
                    ParametrId = rec.ParametrId,
                    Up = rec.Up
                })
                .ToList();
            return result;
        }

        public void UpdElement(MarkParametrBM model)
        {
            throw new NotImplementedException();
        }
    }
}
