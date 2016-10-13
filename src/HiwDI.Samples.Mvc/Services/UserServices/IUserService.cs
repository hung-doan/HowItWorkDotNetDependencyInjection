using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiwDI.Samples.Mvc.Services.UserServices
{
    public interface IUserService
    {
        string GetDisplayName(int id);
    }
}
