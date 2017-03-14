using Android.App;
using Android.Widget;
using Android.OS;
using System.Net;

namespace GithubUserSearch
{
    [Activity(Label = "Search Github User", MainLauncher = true, Icon = "@drawable/bennySearch")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            getDevelopers();
        }

        public void getDevelopers()
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create("https://api.github.com/search/users?q=language:java+location:lagos") as HttpWebRequest;

            myRequest.Credentials = CredentialCache.DefaultCredentials;
            //myRequest.Credentials = new NetworkCredential("benibowalson", ".12gitHUB34.");
            myRequest.Method = "GET";
            myRequest.Proxy = null;

            using (HttpWebResponse myResponse = myRequest.GetResponse() as HttpWebResponse)
            {

            }
        }
    }
}

