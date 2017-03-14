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

namespace GithubUserSearch
{
    public class Developer
    {
        public string username { get; set; }
        public string profileURL { get; set; }
        public string photoPath { get; set; }

        public Developer() { }

        public Developer(string uName, string pURL, string pPath)
        {
            uName = this.username;
            pURL = this.profileURL;
            pPath = this.photoPath;
        }
    }
}