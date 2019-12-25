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
        private SPPRDbContext3 context;

        public MarkParamServiceBD(SPPRDbContext3 context)
        {
            this.context = context;
        }

        public void CreateElement(MarkParametr model)
        {
            MarkParametr element = context.MarkParametrs.FirstOrDefault(rec => rec.Mark == model.Mark && rec.ParametrId==model.ParametrId&& rec.UserId==model.UserId);
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
                Up=model.Up,
                UserId=model.UserId
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
                    Up = element.Up,
                    UserId = element.UserId
                };
            }
            throw new Exception("Элемент не найден");
        }

        public MarkParametrBM GetElement(int idParam, Marks mark)
        {
            throw new NotImplementedException();
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
                    Up = rec.Up,
                    UserId = rec.UserId
                })
                .ToList();
            return result;
        }

        public List<MarkParametrBM> GetList(ParametrBM parametr, int userId)
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
                   Up = rec.Up,
                   UserId = rec.UserId
               })
               .Where(rec => rec.ParametrId==parametr.Id && rec.UserId==userId).ToList();
            return result;
        }

        public void UpdElement(MarkParametrBM model)
        {/*
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Parametr element = context.Parametrs.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                    element.Name = model.na;
                    element.Price = model.Price;
                    context.SaveChanges();

                    // обновляем существуюущие компоненты
                    var compIds = model.ProductComponents.Select(rec => rec.ComponentId).Distinct();
                    var updateComponents = context.ProductComponents
                                                    .Where(rec => rec.ProductId == model.Id &&
                                                        compIds.Contains(rec.ComponentId));
                    foreach (var updateComponent in updateComponents)
                    {
                        updateComponent.Count = model.ProductComponents
                                                        .FirstOrDefault(rec => rec.Id == updateComponent.Id).Count;
                    }
                    context.SaveChanges();
                    context.ProductComponents.RemoveRange(
                                        context.ProductComponents.Where(rec => rec.ProductId == model.Id &&
                                                                            !compIds.Contains(rec.ComponentId)));
                    context.SaveChanges();
                    // новые записи
                    var groupComponents = model.ProductComponents
                                                .Where(rec => rec.Id == 0)
                                                .GroupBy(rec => rec.ComponentId)
                                                .Select(rec => new
                                                {
                                                    ComponentId = rec.Key,
                                                    Count = rec.Sum(r => r.Count)
                                                });
                    foreach (var groupComponent in groupComponents)
                    {
                        ProductComponent elementPC = context.ProductComponents
                                                .FirstOrDefault(rec => rec.ProductId == model.Id &&
                                                                rec.ComponentId == groupComponent.ComponentId);
                        if (elementPC != null)
                        {
                            elementPC.Count += groupComponent.Count;
                            context.SaveChanges();
                        }
                        else
                        {
                            context.ProductComponents.Add(new ProductComponent
                            {
                                ProductId = model.Id,
                                ComponentId = groupComponent.ComponentId,
                                Count = groupComponent.Count
                            });
                            context.SaveChanges();
                        }
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
    }
}
