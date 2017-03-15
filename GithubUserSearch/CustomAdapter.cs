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
namespace GithubUserSearch
{
    class CustomDevsAdapter: BaseAdapter<Developer>
    {
        Activity myContext;
        public List<Developer> devsList;

        //constructor
        public CustomDevsAdapter(Activity aContext, List<Developer> lstDvlprs) : base()
        {
            this.myContext = aContext;
            this.devsList = lstDvlprs;
            
        }

        //overrides for base class methods
        public override int Count
        {
            get
            {
                return this.devsList.Count;
            }
        }

        public override Developer this[int position]
        {
            get
            {
                return this.devsList[position];
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            Developer aDev = devsList[position];
            View aView = convertView;

            if (convertView == null)
                aView = myContext.LayoutInflater.Inflate(Resource.Layout.DevCustomView, parent, false);

            ImageView devImage = aView.FindViewById(Resource.Id.imgDev) as ImageView;
            TextView devUsername = aView.FindViewById(Resource.Id.txtDev) as TextView;

            devImage.SetImageBitmap(aDev.userAvatar);
            devUsername.SetText(aDev.username, TextView.BufferType.Normal);

            return aView;
        }
    }
}