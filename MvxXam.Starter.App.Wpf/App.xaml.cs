using System;
using System.Windows;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Wpf.Views.Presenters;

namespace MvxXam.Starter.App.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Setup complete
        /// </summary>
        private bool setupComplete;

        /// <summary>
        /// Start the setup
        /// </summary>
        /// <param name="e"></param>
        protected override void OnActivated(EventArgs e)
        {
            if (!setupComplete)
                DoSetup();

            base.OnActivated(e);
        }

        /// <summary>
        /// Display/Close the splash screen and run setup 
        /// </summary>
        /// <returns></returns>
        private void DoSetup()
        {
            var presenter = new MvxWpfViewPresenter(MainWindow as MainWindow);
            var setup = new Setup(Dispatcher, presenter);

            // Create a thread to launch Breaker
            setup.Initialize();
            Mvx.Resolve<IMvxAppStart>().Start();

            setupComplete = true;
        }
    }
}
