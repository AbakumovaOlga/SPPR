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
    public class TelephoneServiceBD : ITelephoneService
    {
        private SPPRDbContext context;

        public TelephoneServiceBD(SPPRDbContext context)
        {
            this.context = context;
        }

        public void CreateElement(TelephoneBM model)
        {
            Telephone element = context.Telephones.FirstOrDefault(rec => rec.Name == model.Name);
            if (element != null)
            {
                throw new Exception("Уже есть telephone с таким name");
            }
            context.Telephones.Add(new Telephone
            {
                Name = model.Name,
                Data=model.Data
            });
            context.SaveChanges();
        }

        public void DelElement(TelephoneBM model)
        {
            Telephone element = context.Telephones.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Telephones.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public TelephoneBM GetElement(int id)
        {
            Telephone element = context.Telephones.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new TelephoneBM
                {
                    Id = element.Id,
                    Name = element.Name,
                    Data=element.Data,
                    TelepParams = element.TelepParams
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<TelephoneBM> GetList()
        {
            List<TelephoneBM> result = context.Telephones
                .Select(rec => new TelephoneBM
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Data=rec.Data,
                    TelepParams=rec.TelepParams
                })
                .ToList();
            return result;
        }

        public void UpdElement(TelephoneBM model)
        {
            throw new NotImplementedException();
        }
    }
}
