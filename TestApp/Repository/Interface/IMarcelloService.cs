using MarcelloDB.Platform;

namespace TestApp.Services.Interfaces
{
    public interface IMarcelloService
    {
        IPlatform GetInstance();
    }
}