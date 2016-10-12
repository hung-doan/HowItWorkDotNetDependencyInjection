using HiwDI.Samples.CLI.Repositories.UserRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiwDI.Samples.CLI.Services.UserServices
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepo;
        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public string GetDisplayName(int id)
        {
            var user = _userRepo.GetById(id);
            var result = $"{id}: {user.FirstName} {user.LastName}";
            return result;
        }

    }
}
