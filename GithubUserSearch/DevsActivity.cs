using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using System.Net;

namespace GithubUserSearch
{
    [Activity(Label = "Lagos Based Java Developers")]
    public class DevsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.DevsListView);

            string uName = Intent.GetStringExtra("dUser") ?? "";
            string uPass = Intent.GetStringExtra("dPass") ?? "";

            getDevelopers(uName, uPass);
            
        }

        public void getDevelopers(string usrName, string pWord)
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create("https://api.github.com/search/users?q=language:java+location:lagos") as HttpWebRequest;

            //myRequest.UseDefaultCredentials = true;
            //myRequest.Credentials = CredentialCache.DefaultCredentials;
            myRequest.Credentials = new NetworkCredential(usrName, pWord);
            myRequest.Method = "GET";
            myRequest.Proxy = null;

            using (HttpWebResponse myResponse = myRequest.GetResponse() as HttpWebResponse)
            {
                dynamic myJson = Newtonsoft.Json.JsonConvert.SerializeObject(myResponse);
                
            }
        }
    }
}