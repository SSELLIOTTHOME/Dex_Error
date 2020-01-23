using MvvmCross;
using MvvmCross.ViewModels;

using Shared.ViewModels;

using MvvmCross.IoC;

using System.Threading;


using System.Collections.Generic;
using System;
using System.Reflection;
using MvvmCross.Logging;
using MvvmCross.Plugin;
using System.Threading.Tasks;
using MvvmCross.Navigation;

namespace Shared
{


   public class AppStart: MvxAppStart
    {

        public AppStart(IMvxApplication app, IMvxNavigationService mvxNavigationService)
         : base(app, mvxNavigationService)
        {
        }

        protected override System.Threading.Tasks.Task NavigateToFirstViewModel(object hint = null)
        {
            //if (Mvx.Resolve<IDeviceInfo>().Platform() == "iOS")
            //{
              //  return NavigationService.Navigate<DashboardViewModel>();
            //}
            //else
            //{
                return NavigationService.Navigate<HomeViewModel>();
            //}
        }
    }



    public class App : MvxApplication
    {


        public override void Reset()
        {
            System.Diagnostics.StackTrace t = new System.Diagnostics.StackTrace();
            Mvx.Resolve<IMvxLog>().Warn(t.ToString());
            base.Reset();
        }






        public override System.Threading.Tasks.Task Startup()
        {
            System.Diagnostics.StackTrace t = new System.Diagnostics.StackTrace();
            Mvx.Resolve<IMvxLog>().Warn(t.ToString());
            return base.Startup();
        }
   
        public static bool LeaveDatabaseAlone { get; set; } = false;

        public static SemaphoreSlim SetupSemaphire = new SemaphoreSlim(1, 1);

        public bool Loaded { get; set; } = false;

        public static void test() {
      

        }

        public bool IsRunning { get; set; }

        public override void Initialize()
        {



            RegisterCustomAppStart<AppStart>();
        }


        public static bool MvvmCrossIsRunning { get; set; }



    }
}
