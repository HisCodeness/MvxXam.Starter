using MvvmCross.Uwp.Views;
using MvxXam.Starter.ViewModels;
using Windows.UI.Core;

namespace MvxXam.Starter.App.UWP.Views
{
    /// <summary>
    /// Main page class
    /// </summary>
    public sealed partial class SecondView : MvxWindowsPage
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SecondView()
        {
            InitializeComponent();

            // Add back button
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += (s, e) =>
            {
                (ViewModel as SecondViewModel).GoBackCommand.Execute();
            };
        }
    }
}
