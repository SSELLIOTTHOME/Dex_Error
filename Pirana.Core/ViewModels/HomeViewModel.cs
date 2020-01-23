

using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Linq;


using MvvmCross.Core;
using MvvmCross;
using MvvmCross.Base;
using MvvmCross;
using MvvmCross.Base;

using MvvmCross.Navigation;

using MvvmCross.Logging;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Shared.ViewModels
{

    
    public class HomeViewModel
        : MvxViewModel<int>
    {

        protected override void ReloadFromBundle(IMvxBundle state)
        {
            base.ReloadFromBundle(state);
        }

        protected override void SaveStateToBundle(IMvxBundle bundle)
        {
            bundle.Data["Loaded"] = "true";
            base.SaveStateToBundle(bundle);
        }

        public override void ViewCreated()
        {
            base.ViewCreated();
            //nfc = Mvx.Resolve<Shared.Services.NFC>();

        }



        public override void ViewDestroy(bool viewFinishing = true)
        {
            base.ViewDestroy(viewFinishing);
        }

        public override void ViewDisappeared()
        {
            
            base.ViewDisappeared();
        }

        public override void ViewAppeared()
        {
            base.ViewAppeared();

            return;

         


        }

        public override void Prepare(int parameter)
        {

        }

        public HomeViewModel()
        { 



        }






    }

}


