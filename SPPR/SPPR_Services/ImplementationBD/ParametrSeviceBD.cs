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
    public class ParametrSeviceBD : IParametrService
    {
        private SPPRDbContext3 context;

        public ParametrSeviceBD(SPPRDbContext3 context)
        {
            this.context = context;
        }

        public void CreateElement(ParametrBM model)
        {
           Parametr element = context.Parametrs.FirstOrDefault(rec => rec.Name == model.Name);
              if (element != null)
              {
                  throw new Exception("Уже есть parametr с таким name");
              }
              context.Parametrs.Add(new Parametr
              {
                  Name = model.Name
              });
              context.SaveChanges();
           /*  using (var transaction = context.Database.BeginTransaction())
            {
                try
                {

                    Parametr element = context.Parametrs.FirstOrDefault(rec => rec.Name == model.Name);
                    if (element != null)
                    {
                        throw new Exception("Уже есть Parametr с таким name");
                    }
                    Parametr par = new Parametr
                    {
                        Name = model.Name,
                        Choosing=model.Choosing
                    };
                    context.Parametrs.Add(par);
                    context.SaveChanges();
                    foreach (var markParametr in model.MarkParametrs)
                    {
                        context.MarkParametrs.Add(new MarkParametr
                        {
                            ParametrId = par.Id,
                            Average= markParametr.Average,
                            Down=markParametr.Down,
                            Mark=markParametr.Mark,
                            Up=markParametr.Up,
                            UserId=markParametr.UserId,
                            Cheking=markParametr.Cheking,
                            Count=markParametr.Count
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
            }*/
        }

        public void DelElement(int id)
        {
            Parametr element = context.Parametrs.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Parametrs.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public ParametrBM GetElement(int id)
        {
            Parametr element = context.Parametrs.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new ParametrBM
                {
                    Id = element.Id,
                    Name = element.Name,
                    Choosing = element.Choosing,
                    MarkParametrs = element.MarkParametrs,
                    TelepParams = element.TelepParams
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<ParametrBM> GetList()
        {
            List<ParametrBM> result = context.Parametrs
                .Select(rec => new ParametrBM
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Choosing = rec.Choosing,
                    MarkParametrs = rec.MarkParametrs,
                    TelepParams = rec.TelepParams
                }).ToList();
            return result;
        }

        public void UpdElement(ParametrBM model)
        {
           using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Parametr element = context.Parametrs.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                    element.Name = model.Name;
                    context.SaveChanges();


                    
                    //запистаь все новые

                    foreach (var mp in model.MarkParametrs)
                    {
                        MarkParametr newMarkPar = context.MarkParametrs.FirstOrDefault(rec => rec.Mark == mp.Mark && rec.ParametrId == mp.ParametrId&& rec.UserId==mp.UserId);
                        if (element != null)
                        {
                            throw new Exception("Уже есть такой MarkParametr");
                        }
                        context.MarkParametrs.Add(new MarkParametr
                        {
                            ParametrId = mp.Id,
                            Average = mp.Average,
                            Down = mp.Down,
                            Mark = mp.Mark,
                            Up = mp.Up,
                            UserId = mp.UserId,
                            Cheking = mp.Cheking,
                            Count = mp.Count
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

        public ParametrBM GetElement(int id, int userId)
        {
            


            Parametr element = context.Parametrs.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                List<MarkParametr> marks = GetListM(element, userId);
                return new ParametrBM
                {
                    Id = element.Id,
                    Name = element.Name,
                    Choosing = element.Choosing,
                    MarkParametrs = marks,
                    TelepParams = element.TelepParams
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<MarkParametr> GetListM(Parametr parametr, int userId)
        {
            List<MarkParametrBM> result1 = context.MarkParametrs
               .Select(rec => new MarkParametrBM
               {
                   Id = rec.Id,
                   Average = rec.Average,
                   Cheking = rec.Cheking,
                   Count = rec.Count,
                   Down = rec.Down,
                   Mark = rec.Mark,
                   ParametrId = rec.ParametrId,
                   Up = rec.Up,
                   UserId = rec.UserId
               })
               .Where(rec => rec.ParametrId == parametr.Id && rec.UserId == userId).ToList();
            List<MarkParametr> result = new List<MarkParametr>();
            foreach(var res in result1)
            {
                result.Add(new MarkParametr
                {
                    Id = res.Id,
                    Average = res.Average,
                    Cheking = res.Cheking,
                    Count = res.Count,
                    Down = res.Down,
                    Mark = res.Mark,
                    ParametrId = res.ParametrId,
                    Up = res.Up,
                    UserId = res.UserId
                });
            }
            return result;
        }
    }
}
