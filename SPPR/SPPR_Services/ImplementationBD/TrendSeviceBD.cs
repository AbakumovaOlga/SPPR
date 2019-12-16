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
    public class TrendSeviceBD : ITrendService
    {
        private SPPRDbContext context;

        public TrendSeviceBD(SPPRDbContext context)
        {
            this.context = context;
        }

        public void CreateElement(TrendBM model)
        {
            Trend element = context.Trends.FirstOrDefault(rec => rec.Name == model.Name);
            if (element != null)
            {
                throw new Exception("Уже есть trend с таким name");
            }
            context.Trends.Add(new Trend
            {
                Name = model.Name,
                First = model.First,
                Second = model.Second,
                Third = model.Third
            });
            context.SaveChanges();
        }

        public void DelElement(TrendBM model)
        {
            Trend element = context.Trends.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Trends.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public bool DeleteAll()
        {
            foreach (var el in GetList())
            {
                DelElement(el);
            }
            return true;
        }

        public TrendBM GetElement(int id)
        {
            Trend element = context.Trends.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new TrendBM
                {
                    Id = element.Id,
                    Name = element.Name,
                    First = element.First,
                    Second = element.Second,
                    Third = element.Third,
                    Count = element.Count
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<TrendBM> GetList()
        {
            List<TrendBM> result = context.Trends
                .Select(rec => new TrendBM
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    First = rec.First,
                    Second = rec.Second,
                    Third = rec.Third,
                    Count = rec.Count
                })
                .ToList();
            return result;
        }

        public void UpdElement(TrendBM model)
        {
            Trend element = context.Trends.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Count = element.Count + 1;
        }
    }
}
