using System;
using System.Collections.Generic;
using MvvmAspire;
using Xamarin.Forms;

namespace TestApp.Views
{
    public partial class TestPage : ContentPage
    {

        public TestPage()
        {
            InitializeComponent();
            Title = "MVVM ASPIRE";
            NavigationPage.SetBackButtonTitle(this, "Back");
        }
    }
}
