using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using UIKit;

namespace MvxXam.Starter.App.iOS
{
    /// <summary>
    /// Setup class
    /// </summary>
    public class Setup : MvxIosSetup
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="applicationDelegate"></param>
        /// <param name="window"></param>
        public Setup(IMvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }

        /// <summary>
        /// Create app
        /// </summary>
        /// <returns></returns>
        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        /// <summary>
        /// Create default presenter
        /// </summary>
        /// <returns></returns>
        protected override IMvxIosViewPresenter CreatePresenter()
        {
            return new MvxIosViewPresenter(ApplicationDelegate, Window);
        }
    }
}
