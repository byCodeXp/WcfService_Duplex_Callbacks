using Client.ServiceReference;
using System;
using System.ServiceModel;

namespace Client
{
    public class ServiceCallback : IServiceCallback
    {
        public void OnCallback()
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ServiceCallback callback = new ServiceCallback();

            InstanceContext instanceContext = new InstanceContext(callback);

            ServiceClient client = new ServiceClient(instanceContext);

            client.Start();

            Console.ReadLine();
        }
    }
}
