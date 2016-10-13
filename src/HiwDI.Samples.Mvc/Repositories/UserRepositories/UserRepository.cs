using HiwDI.Samples.Mvc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiwDI.Samples.Mvc.Repositories.UserRepositories
{
    public class UserRepository: IUserRepository
    {
        public User GetById(int id)
        {
            return new User {
                Id = id,
                FirstName = "Hung",
                LastName = "Doan",
                BirthYear = 1991
            };
        }
    }
}
