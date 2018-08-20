using System;
using MarcelloDB.Platform;
using TestApp.Mac.Services;
using TestApp.Services.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(MarcelloService))]
namespace TestApp.Mac.Services
{
    public class MarcelloService : IMarcelloService
    {
        public IPlatform GetInstance()
        {
           return new MarcelloDB.netfx.Platform();
        }
    }
}
