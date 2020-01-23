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
using App2;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;
using Shared.ViewModels;

namespace Pirana.Droid.Views
{
    [MvxActivityPresentation]
    [Activity(Label = "Test")]
    public class HomeView : MvxActivity<HomeViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            ProgressDialog.Show(this, "ssmdnfmsdn", "sdlfksldkf");
        //    Intent i = new Intent(this, typeof(Activity1));
      //      StartActivity(i);

            
        }
    }
}