using System;
using MarcelloDB.Platform;
using TestApp.iOS.Services;
using TestApp.Services.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(MarcelloService))]
namespace TestApp.iOS.Services
{
    public class MarcelloService : IMarcelloService
    {
        public IPlatform GetInstance()
        {
           return new MarcelloDB.netfx.Platform();
        }
    }
}
