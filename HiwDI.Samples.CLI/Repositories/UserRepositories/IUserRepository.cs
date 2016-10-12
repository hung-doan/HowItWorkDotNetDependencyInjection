using HiwDI.Samples.CLI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiwDI.Samples.CLI.Repositories.UserRepositories
{
    public interface IUserRepository
    {
        User GetById(int id);
    }
}
