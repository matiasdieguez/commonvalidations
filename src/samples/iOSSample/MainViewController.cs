using CommonValidations;
using System;

using UIKit;

namespace iOSSample
{
    public partial class MainViewController : UIViewController
    {
        public MainViewController() : base("MainViewController", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var result = Validations.BePhoneNumber("+4258235783");
            var alert = new UIAlertView("title", result.ToString(), null, "Ok", null);
            alert.Show();

            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}