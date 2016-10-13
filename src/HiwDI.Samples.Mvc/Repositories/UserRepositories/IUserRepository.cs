using HiwDI.Samples.Mvc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiwDI.Samples.Mvc.Repositories.UserRepositories
{
    public interface IUserRepository
    {
        User GetById(int id);
    }
}
