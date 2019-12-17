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
        private SPPRDbContext context;

        public ParametrSeviceBD(SPPRDbContext context)
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
                Name = model.Name,
                Choosing = model.Choosing,
                MarkParametrs = model.MarkParametrs,
                TelepParams = model.TelepParams

            });
            context.SaveChanges();
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
                })
                .ToList();
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


                    //найти все старые маркиПар
                    List<MarkParametrBM> markParametrs = context.MarkParametrs .Select(rec => new MarkParametrBM
                    {
                     Id = rec.Id,
                      Average = rec.Average,
                      Cheking = rec.Cheking,
                   Count = rec.Count,
                   Down = rec.Down,
                   Mark = rec.Mark,
                    ParametrId = rec.ParametrId,
                    Up = rec.Up
                            }).Where(rec => rec.ParametrId == model.Id).ToList();
                    //удалить все старые марки пар
                    foreach (MarkParametrBM markpar in markParametrs)
                    {
                        DelElement(markpar);
                    }
                    //запистаь все новые

                    foreach (var mp in model.MarkParametrs)
                    {
                        MarkParametr newMarkPar = context.MarkParametrs.FirstOrDefault(rec => rec.Mark == mp.Mark && rec.ParametrId == mp.ParametrId);
                        if (element != null)
                        {
                            throw new Exception("Уже есть такой MarkParametr");
                        }
                        context.MarkParametrs.Add(new MarkParametr
                        {
                            Average = mp.Average,
                            Cheking = mp.Cheking,
                            Down = mp.Down,
                            Mark = mp.Mark,
                            ParametrId = mp.ParametrId,
                            Up = mp.Up
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
    }
}
