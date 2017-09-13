using System.Windows.Threading;
using MvvmCross.Core.ViewModels;
using MvvmCross.Wpf.Platform;
using MvvmCross.Wpf.Views.Presenters;

namespace MvxXam.Starter.App.Wpf
{
    /// <summary>
    /// Start and configure the MvvmCross application
    /// </summary>
    public class Setup : MvxWpfSetup
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dispatcher"></param>
        /// <param name="presenter"></param>
        public Setup(Dispatcher dispatcher, IMvxWpfViewPresenter presenter)
            : base(dispatcher, presenter)
        {
        }

        /// <summary>
        /// Create App instance
        /// </summary>
        /// <returns>IMvxApplication</returns>
        protected override IMvxApplication CreateApp()
        {
            return new MvxXam.Starter.App.App();
        }
    }
}