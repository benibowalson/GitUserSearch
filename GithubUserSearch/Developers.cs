using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


namespace GithubUserSearch
{
    class Developers : CollectionBase
    {
        public void Add(Developer aDev)
        {
            List.Add(aDev);
        }

        public void Remove(Developer aDev)
        {
            List.Remove(aDev);
        }

        //INDEXERR
        public Developer this[int devIndex]
        {
            get { return (Developer)List[devIndex]; }
            set { List[devIndex] = value; }
        }
    }
}