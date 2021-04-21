using System;
using System.ServiceModel;
using System.Timers;

namespace Service
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class Service : IService
    {
        public static IServiceCallback Callback;
        public static Timer Timer;

        public void Start()
        {
            Console.WriteLine("> Session opened at {0}", DateTime.Now);
            Callback = OperationContext.Current.GetCallbackChannel<IServiceCallback>();

            Timer = new Timer(1000);
            Timer.Elapsed += OnTimerElapsed;
            Timer.Enabled = true;
        }

        void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            Callback.OnCallback();
        }
    }
}
