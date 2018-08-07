using System;
using MarcelloDB.Platform;
using TestApp.Droid.Services;
using TestApp.Services.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(MarcelloService))]
namespace TestApp.Droid.Services
{
    public class MarcelloService : IMarcelloService
    {
        public IPlatform GetInstance()
        {
           return new MarcelloDB.netfx.Platform();
        }
    }
}
