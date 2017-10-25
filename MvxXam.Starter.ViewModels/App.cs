using System.Reflection;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using MvxXam.Starter.ViewModels;

namespace MvxXam.Starter.App
{
    /// <summary>
    /// CoreApp class
    /// </summary>
    public class App : MvxApplication
    {
        /// <summary>
        /// Initialize App
        /// </summary>
        public override void Initialize()
        {
            var serviceAssembly = Assembly.Load(new AssemblyName("MvxXam.Starter.Services"));

            CreatableTypes(serviceAssembly)
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<MainViewModel>();
        }
    }
}
