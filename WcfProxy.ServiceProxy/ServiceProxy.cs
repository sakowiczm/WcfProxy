using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace WcfProxy.ServiceProxy
{
    public abstract class ServiceProxy<T>
    {
        public void Execute(Action<T> command)
        {
            var binding = new WSHttpBinding();
            var address = new EndpointAddress("http://localhost:9007/DataService");

            var factory = new ChannelFactory<T>(binding, address);
            var channel = factory.CreateChannel();

            command(channel);

            ((IChannel) channel).Close();
        }

        public void Dispose()
        {
            
        }
    }
}