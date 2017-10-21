using Android.App;
using Android.Widget;
using Android.OS;
using CommonValidations;

namespace AndroidSample
{
    [Activity(Label = "AndroidSample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var result = Validations.BePhoneNumber("+4258235783");

            Toast.MakeText(this.ApplicationContext, result.ToString(), ToastLength.Short).Show();

        }
    }
}

