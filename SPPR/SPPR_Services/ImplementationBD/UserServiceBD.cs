using SPPR;
using SPPR_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPR_Services.ImplementationBD
{
    public class UserServiceBD : IUserService
    {
        private SPPRDbContext3 context;

        public UserServiceBD(SPPRDbContext3 context)
        {
            this.context = context;
        }

        public void CreateUser(User model)
        {
            User element = context.Users.FirstOrDefault(rec => rec.Login == model.Login);
            if (element != null)
            {
                throw new Exception("Уже есть user с таким login");
            }
            context.Users.Add(new User
            {
                Login = model.Login,
                Password = model.Password,
                FIO = model.FIO,
                Role = model.Role
            });
            context.SaveChanges();
        }

        public void DelUser(User model)
        {
            User element = context.Users.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Users.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public User Author(string login, string password)
        {

            var user = context.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
            if (user == null)
            {
                throw new Exception("Введен неверный логин/пароль");
            }
            return user;
        }
        public User GetElement(int id)
        {
            User element = context.Users.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new User
                {
                    Id = element.Id,
                    Login = element.Login,
                    Password = element.Password,
                    FIO = element.FIO,
                    Role = element.Role
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<User> GetList()
        {
            List<User> result = context.Users
                .Select(rec => new User
                {
                    Id = rec.Id,
                    Login = rec.Login,
                    Password = rec.Password,
                    FIO = rec.FIO,
                    Role = rec.Role
                })
                .ToList();
            return result;
        }

        public void UpdUser(User model)
        {
            throw new NotImplementedException();
        }
    }
}
