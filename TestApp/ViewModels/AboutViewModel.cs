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
        public AboutViewModel()
        {

            ShowAlertCommand = new RelayCommand(ShowAlert);
        }

        async void ShowAlert()
        {
            ShowAlertCommand.CanRun = false;
            await Page.DisplayAlert(null, "This is an alert", "Great!");
            ShowAlertCommand.CanRun = true;

        }
    }
}
