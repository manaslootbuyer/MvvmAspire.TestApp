using System;
using Xamarin.Forms;
using TestApp.Views;
using Xamarin.Forms.Xaml;
using MvvmAspire;

namespace TestApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            var navigation = Resolver.Get<MvvmAspire.Services.INavigation>();
            MainPage = ((MvvmAspire.Services.XamarinFormsNavigation)navigation).NavigationPage;
            MainPage.SetValue(NavigationPage.BarTextColorProperty, Color.Black);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
