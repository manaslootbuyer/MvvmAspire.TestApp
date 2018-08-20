using System;
using System.Collections.Generic;
using MvvmAspire.Controls;
using Xamarin.Forms;

namespace TestApp.Adapter
{
    public partial class UserViewCell : FastCell
    {
        protected override void InitializeCell()
        {
            InitializeComponent();
        }
        protected override void SetupCell(bool isRecycled) { }
    }

}
