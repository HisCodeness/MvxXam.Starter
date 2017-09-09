using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Platform;
using MvvmCross.Uwp.Platform;
using MvvmCross.Uwp.Views;
using Windows.UI.Xaml.Controls;

namespace MvxXam.Starter.App.UWP
{
    /// <summary>
    /// Setup class
    /// </summary>
    public class Setup : MvxWindowsSetup
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="rootFrame"></param>
        /// <param name="e"></param>
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        /// <summary>
        /// Create app
        /// </summary>
        /// <returns></returns>
        protected override IMvxApplication CreateApp()
        {
            return new Starter.App.App();
        }

        /// <summary>
        /// Create default presenter
        /// </summary>
        /// <param name="rootFrame"></param>
        /// <returns></returns>
        protected override IMvxWindowsViewPresenter CreateViewPresenter(IMvxWindowsFrame rootFrame)
        {
            var presenter = new MvxWindowsViewPresenter(rootFrame);
            Mvx.RegisterSingleton<IMvxViewPresenter>(presenter);

            return presenter;
        }
    }
}