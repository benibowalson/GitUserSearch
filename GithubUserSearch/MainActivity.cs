using Android.App;
using Android.Widget;
using Android.OS;
using System.Net;
using Android.Content;

namespace GithubUserSearch
{
    [Activity(Label = "Search Github User", MainLauncher = true, Icon = "@drawable/search")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            Button SearchButton = FindViewById<Button>(Resource.Id.btnSearch);

            SearchButton.Click += (sender, e) =>
            {
                string uName = FindViewById<EditText>(Resource.Id.txtUsername).Text;
                string uPass = FindViewById<EditText>(Resource.Id.txtPassword).Text;

                var devResultsActivity = new Intent(this, typeof(DevsActivity));
                devResultsActivity.PutExtra("dUsername", uName);
                devResultsActivity.PutExtra("dPass", uPass);
                StartActivity(devResultsActivity);

            };
        }
    }
}

