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
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {

                    Telephone element = context.Telephones.FirstOrDefault(rec => rec.Name == model.Name);
                    if (element != null)
                    {
                        throw new Exception("Уже есть telephone с таким name");
                    }
                    Telephone tel = new Telephone
                    {
                        Name = model.Name,
                        Date = model.Date
                    };
                    context.Telephones.Add(tel);
                    context.SaveChanges();
                    foreach (var TelepParam in model.TelepParams)
                    {
                        context.TelepParams.Add(new TelepParam
                        {
                            ParametrId = TelepParam.ParametrId,
                            TelephoneId = tel.Id,
                            Value = TelepParam.Value
                        });
                        context.SaveChanges();
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void DelElement(int id)
        {
            Telephone element = context.Telephones.FirstOrDefault(rec => rec.Id == id);
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
                    Date = element.Date,
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
                    Date = rec.Date,
                    TelepParams = rec.TelepParams
                })
                .ToList();
            return result;
        }

        public List<TelephoneBM> GetSortList()
        {
            List<TelephoneBM> result = new List<TelephoneBM>();
            TelepComparer telepComparer = new TelepComparer();
            List<Telep> list = context.Telephones
                .Select(rec => new Telep
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Date = rec.Date
                })
                .ToList();

            list.Sort(telepComparer);

            foreach (var l in list)
            {
                result.Add(GetElement(l.Id));
            }
            return result;
        }

        public void UpdElement(TelephoneBM model)
        {
            throw new NotImplementedException();
        }
    }
}
