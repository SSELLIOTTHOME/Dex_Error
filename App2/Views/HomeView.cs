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
using MvvmCross.Droid.Support.V7.AppCompat;
using Shared.ViewModels;

namespace Pirana.Droid.Views
{
    [Activity(Label = "HomeView")]
    public class HomeView : MvxAppCompatActivity<HomeViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);


            ProgressDialog.Show(this, "ssmdnfmsdn", "sdlfksldkf");
        }
    }
}