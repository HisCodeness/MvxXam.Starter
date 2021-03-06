using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvxXam.Starter.Services;

namespace MvxXam.Starter.ViewModels
{
    /// <summary>
    /// MainViewModel class
    /// </summary>
    public class MainViewModel : BaseViewModel<MvxNullViewModel, MvxNullViewModel>
    {
        /// <summary>
        /// Test app service
        /// </summary>
        private readonly IAppService appService;

        /// <summary>
        /// Navigation Service
        /// </summary>
        private readonly IMvxNavigationService navigationService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="appService"></param>
        public MainViewModel(IAppService appService, IMvxNavigationService navigationService)
        {
            this.appService = appService;
            this.navigationService = navigationService;
        }

        /// <summary>
        /// Initialize view model
        /// </summary>
        /// <returns></returns>
        public override Task Initialize()
        {
            //TODO: Add starting logic here

            return base.Initialize();
        }

        #region Bindings tests

        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);
        private void ResetText()
        {
            Text = "Hello MvvmCross";
            RaisePropertyChanged(() => Time);
        }

        public IMvxCommand NextCommand => new MvxAsyncCommand(GoNext);
        private async Task GoNext()
        {
            // With return value
            var result = await navigationService.Navigate<SecondViewModel, string, string>(text);

            Text += result;
        }

        private string text = "Hello MvvmCross !";
        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }

        public string Time
        {
            get { return appService.WhatTimeIsIt(); }
        }

        #endregion
    }
}