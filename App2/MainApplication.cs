using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Support.V7.Widget;
using Android.Views;
using MvvmCross;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Core;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCross.Exceptions;
using MvvmCross.Platforms.Android;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Presenters;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.Platforms.Android.Views.Base;
using MvvmCross.Presenters;
using MvvmCross.Presenters.Attributes;
using MvvmCross.Presenters.Hints;
using MvvmCross.ViewModels;
using MvvmCross.Views;
using Shared;

//using Square.LeakCanary;
using DialogFragment = Android.Support.V4.App.DialogFragment;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentManager = Android.Support.V4.App.FragmentManager;




namespace Pirana.Droid
{

    [Application]
    public class MainApplication : MvxAppCompatApplication<CustomSetup, App>
    {
    
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {



            


        }

    }









    public class CustomSetup : MvxAppCompatSetup<Shared.App>
    {


        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();
            //Mvx.RegisterSingleton<IMvxAndroidCurrentTopActivity>(new Test123());
        }

        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();


            //Mvx.RegisterSingleton<IMvxAndroidCurrentTopActivity>(new Test123());
            /*



            AndroidDialogBuilder t = new AndroidDialogBuilder();
            var dialog = new AndroidDialogBuilder();

            Mvx.RegisterSingleton<IDialogService>(new AndroidDialogBuilder());
            Mvx.RegisterSingleton<IServiceManager>(new ServiceManger());

            var deviceInfo = new DroidDeviceInfo();
            Mvx.RegisterSingleton<IDeviceInfo>(deviceInfo);
            Mvx.RegisterSingleton<Shared.Services.NFC>(new AndroidNFC());

            Mvx.RegisterSingleton<IBarcodeService>(new BarcodeService());
            Mvx.RegisterType<IDocumentService, DroidOpenFile>();

            Mvx.ConstructAndRegisterSingleton<Services.ISignatureService, Pirana.Droid.Services.SignatureService>();



            var res2 = new Pirana.Droid.ConnectionService.Connectivity();

            var res3 = new Pirana.Droid.ImageService();
            Mvx.RegisterSingleton<IImageService>(res3);

            Mvx.RegisterSingleton<IConnectivity>(res2);




            var res = new ScreenResService();
            Mvx.RegisterSingleton<IScreenResService>(res);
            */



        

        }





        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {

            MvxAppCompatSetupHelper.FillTargetFactories(registry);

            base.FillTargetFactories(registry);
        }


        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            return new MvxAppCompatViewPresenter(AndroidViewAssemblies);
        }


        protected override IEnumerable<Assembly> AndroidViewAssemblies => new List<Assembly>(base.AndroidViewAssemblies)
        {
            typeof(NavigationView).Assembly,
            typeof(CoordinatorLayout).Assembly,
            typeof(FloatingActionButton).Assembly,
            typeof(Toolbar).Assembly,
            typeof(DrawerLayout).Assembly,
            typeof(ProgressDialog).Assembly,
            typeof(ViewPager).Assembly,
            typeof(MvxRecyclerView).Assembly,
            typeof(MvxSwipeRefreshLayout).Assembly,
        };


  


 


   
    }

        

        
       

   
}
