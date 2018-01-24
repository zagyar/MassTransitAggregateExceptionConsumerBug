using System;

namespace RequestService
{
    using System.Threading.Tasks;
    using MassTransit;
    using MassTransit.Logging;
    using Sample.MessageTypes;


    public class RequestConsumer :
        IConsumer<ISimpleRequest>
    {
        readonly ILog _log = Logger.Get<RequestConsumer>();
		
        public async Task Consume(ConsumeContext<ISimpleRequest> context)
        {
            _log.InfoFormat("Returning name for {0}", context.Message.CustomerId);
	        await Task.Run(() => throw new AggregateException());
			//same as throw new  AggregateException();
        }
    }
}