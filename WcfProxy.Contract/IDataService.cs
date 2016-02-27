using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfProxy.Contract
{
    [ServiceContract(Namespace = "http://test.com/xyz")]
    public interface IDataService
    {
        [OperationContract]
        GetDataResponse GetData(GetDataRequest request);
    }

    [MessageContract]
    public class GetDataRequest
    {
        [MessageBodyMember]
        public GetDataRequestBody Body { get; set; }
    }

    [DataContract(Namespace = "http://test.com/xyz")]
    public class GetDataRequestBody
    {
        [DataMember]
        public int Id { get; set; }
    }

    [MessageContract]
    public class GetDataResponse
    {
        [MessageBodyMember]
        public GetDataResponseBody Body { get; set; }
    }

    [DataContract(Namespace = "http://test.com/xyz")]
    public class GetDataResponseBody
    {
        [DataMember]
        public int Value { get; set; }
    }
}