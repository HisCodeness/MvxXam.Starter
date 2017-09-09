using Foundation;
using MvvmCross.iOS.Views;
using UIKit;

namespace MvxXam.Starter.App.iOS.Views
{
    [Register("MainView")]
    public class MainView : MvxViewController
    {
        /// <summary>
        /// Indicates if interface is iPhone
        /// </summary>
        private static bool UserInterfaceIdiomIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public MainView()
            : base(UserInterfaceIdiomIsPhone ? "MainView_iPhone" : "MainView_iPad", null)
        {
        }

        /// <summary>
        /// Did receive memory warning
        /// </summary>
        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        /// <summary>
        /// View did load
        /// </summary>
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // TODO a xib file
            //var set = this.CreateBindingSet<MainView, MainViewModel>();
            //set.Bind(this.TimeLabel).To(vm => vm.Time);
            //set.Bind(this.Text).To(vm => vm.Text);
            //set.Bind(this.GoNextButton).To(vm => vm.NextCommand);
            //set.Bind(this.ResetButton).To(vm => vm.ResetCommand);
            //set.Apply();
        }
    }
}