using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmAspire;
using Xamarin.Forms;

namespace TestApp.ViewModel
{
    public class AboutViewModel : AppViewModel
    {

        public RelayCommand ShowAlertCommand { get; set; }

        public string _heroImageUrl;
        public string HeroImageUrl
        {
            get => _heroImageUrl;
            set => SetProperty(ref _heroImageUrl, value);
        }

        public AboutViewModel()
        {
            ShowAlertCommand = new RelayCommand(ShowAlert);
        }


        public override void Init()
        {
            base.Init();
            HeroImageUrl = "https://i.stack.imgur.com/GsDIl.jpg";
        }

        async void ShowAlert()
        {
            ShowAlertCommand.CanRun = false;
            await Page.DisplayAlert(null, "This is an alert", "Great!");
            ShowAlertCommand.CanRun = true;

        }
    }
}
