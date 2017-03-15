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
using Android.Graphics;
using System.Net;

namespace GithubUserSearch
{
    public class Developer
    {
        public string username { get; set; }
        public string profileURL { get; set; }
        public string photoPath { get; set; }
        public Bitmap userAvatar { get; }

        public Developer() { }

        public Developer(string uName, string pURL, string pPath)
        {
            this.username = uName;
            this.profileURL = pURL;
            this.photoPath = pPath;
            userAvatar = avatarFromUrl();
        }

        private Bitmap avatarFromUrl()
        {
            Bitmap dBitMapImage = null;
            using(var aClient = new WebClient())
            {
                var imageBytes = aClient.DownloadData(this.photoPath);
                if (imageBytes != null && imageBytes.Length > 0)
                    dBitMapImage = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
            }

            return dBitMapImage;
        }
    }
}