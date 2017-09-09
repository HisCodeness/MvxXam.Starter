using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace MvxXam.Starter.App.Droid
{
    [Activity(
        Label = "MvxXam.Starter.App.Droid"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
