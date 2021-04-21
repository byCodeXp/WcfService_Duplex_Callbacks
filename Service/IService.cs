using System.ServiceModel;

namespace Service
{
    public interface IServiceCallback
    {
        [OperationContract]
        void OnCallback();
    }

    [ServiceContract(CallbackContract = typeof(IServiceCallback))]
    public interface IService
    {
        [OperationContract]
        void Start();
    }
}
