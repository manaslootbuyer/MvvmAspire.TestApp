using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using MvvmAspire;
using Xamarin.Forms;
namespace TestApp.ViewModel
{

    public abstract class AppViewModel : BaseViewModel
    {

        public AppViewModel()
        {


        }


        /// <summary>
        /// Exposes navigation functionality to the view model.
        /// </summary>
        [Unity.Attributes.Dependency]
        public MvvmAspire.Services.INavigation Navigation { get; set; }

        /// <summary>
        /// Exposes page functionality to the view model.
        /// </summary>
        [Unity.Attributes.Dependency]
        public IPage Page { get; set; }



        public override void OnPush(bool modal)
        {
            base.OnPush(modal);

        }

        public override void OnRevisit(bool modal, bool fromModal)
        {
            base.OnRevisit(modal, fromModal);

        }

        public override void OnPop(bool modal)
        {
            base.OnPop(modal);
        }

        public override void OnRemove(bool modal)
        {
            base.OnRemove(modal);
        }

    }
}