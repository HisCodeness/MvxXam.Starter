using Foundation;
using MvvmCross.iOS.Views;
using UIKit;

namespace MvxXam.Starter.App.iOS.Views
{
    [Register("SecondView")]
    public class SecondView : MvxViewController
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
        public SecondView()
            : base(UserInterfaceIdiomIsPhone ? "SecondView_iPhone" : "SecondView_iPad", null)
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
            //var set = this.CreateBindingSet<SecondView, SecondViewModel>();
            //set.Bind(this.Text).To(vm => vm.Title);
            //set.Bind(this.GoBackButton).To(vm => vm.GoBackCommand);
            //set.Apply();
        }
    }
}