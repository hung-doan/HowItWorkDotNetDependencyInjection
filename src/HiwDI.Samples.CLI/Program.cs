using HiwDI.Core;
using HiwDI.Samples.CLI.Repositories.UserRepositories;
using HiwDI.Samples.CLI.Services.UserServices;
using System;

namespace HiwDI.Samples.CLI
{
    class Program
    {
        static string ManualDependenceInjection()
        {
            IUserRepository userRepo = new UserRepository();
            IUserService userService = new UserService(userRepo);
            return userService.GetDisplayName(1);
        }
        static string AutoDependenceInjection()
        {
            var diContainer = new HiwDIContainer();
            diContainer.Register<IUserService, UserService>();
            diContainer.Register<IUserRepository, UserRepository>();

            var userService = diContainer.Inject<IUserService>();

            return userService.GetDisplayName(2);
        }

        static void Main(string[] args)
        {
            // Dependency Injection Manually
            Console.WriteLine("Dependency Injection Manually:");
            Console.WriteLine(ManualDependenceInjection());

            // Dependency Injection Automatically
            Console.WriteLine("Dependency Injection Automatically:");
            Console.WriteLine(AutoDependenceInjection());
        }
    }
}
