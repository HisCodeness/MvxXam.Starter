using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MvxXam.Starter.ViewModels
{
    /// <summary>
    /// SecondiewModel class
    /// </summary>
    public class SecondViewModel : MvxViewModel<string, string>
    {
        /// <summary>
        /// Main page text
        /// </summary>
        private string text;

        /// <summary>
        /// Navigation Service
        /// </summary>
        private readonly IMvxNavigationService navigationService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="appService"></param>
        public SecondViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        /// <summary>
        /// Load data here
        /// </summary>
        /// <returns></returns>
        public override Task Initialize()
        {
            return base.Initialize();
        }

        /// <summary>
        /// Get and save parameters here
        /// </summary>
        /// <param name="parameter"></param>
        public override void Prepare(string parameter)
        {
            text = parameter;
        }

        #region Bindings tests

        public IMvxCommand GoBackCommand => new MvxCommand(GoBack);

        private void GoBack()
        {
            navigationService.Close(this, "backParam");
        }

        public string Title
        {
            get { return string.Concat("Second page, ", text); }
        }

        #endregion
    }
}