using System;

namespace WcfProxy.ServiceProxy
{
    public interface IDataServiceProxy : IDisposable
    {
        int GetData(int id);
    }
}