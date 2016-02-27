using WcfProxy.Contract;

namespace WcfProxy.Service
{
    public class DataService : IDataService
    {
        public GetDataResponse GetData(GetDataRequest request)
        {
            return new GetDataResponse()
            {
                Body = new GetDataResponseBody()
                {
                    Value = request.Body.Id
                }
            };
        }
    }
}