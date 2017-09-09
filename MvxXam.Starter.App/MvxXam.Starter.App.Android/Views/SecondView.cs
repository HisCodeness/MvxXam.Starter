using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Droid.Views;

namespace MvxXam.Starter.App.Droid.Views
{
    [Activity(Label = "MvxXam.Starter.App", ParentActivity = typeof(MainView), Icon = "@drawable/icon", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SecondView : MvxActivity
    {
        /// <summary>
        /// Activity creation
        /// </summary>
        /// <param name="bundle"></param>
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SecondActivity);
        }
    }
}

