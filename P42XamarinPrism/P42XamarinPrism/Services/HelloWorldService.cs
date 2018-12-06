using P42XamarinPrism.Helpers;
using P42XamarinPrism.Services.Interfaces;

namespace P42XamarinPrism.Services
{
    public class HelloWorldService : IHelloWorldService
    {
        string IHelloWorldService.GetHelloWorld()
        {
            return Secrets.HelloWorldMessage;
        }
    }
}