using WcfProxy.Contract;

namespace WcfProxy.ServiceProxy
{
    public class DataService : ServiceProxy<IDataService>, IDataServiceProxy
    {
        public int GetData(int id)
        {
            var request = new GetDataRequest()
            {
                Body = new GetDataRequestBody()
                {
                    Id = id
                }
            };

            GetDataResponse response = null;

            Execute(c => response = c.GetData(request));

            return response.Body.Value;
        }
    }
}