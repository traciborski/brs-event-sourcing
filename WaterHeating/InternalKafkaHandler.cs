using Confluent.Kafka;
using KMD.Elements.Libraries.KafkaClient.Consumer;
using KMD.Elements.Libraries.KafkaClient.Handlers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Polly;

namespace WaterHeating;

public abstract class InternalKafkaHandler: IKafkaMessageHandler<string, BrsCommand>
{
    public  abstract string Topic {get;}

    public InternalKafkaHandler()
    {
        //_logger = logger;

        var _consumer = new KafkaConsumerBuilder<string, BrsCommand>(new ConsumerConfig {  })
            .SetValueDeserializer(new Deserializer()) // BrsXXXDeserializer
            .SetTopic(Topic)
            .SetDisableAutoStoreOffset()
            .SetEnableDefaultConsumerHandlers()
            //.SetAutoOffsetReset(AutoOffsetReset.Earliest)
            .SetExecutionPolicy(Policy.Handle<Exception>().RetryAsync(3))
            //.SetLogger(logger)
            //.SetServiceProvider(serviceProvider)
            .Build();
    }

    public async Task Handle(ConsumeResult<string, BrsCommand> consumeResult, CancellationToken cancellationToken)
    {
        await Handle(consumeResult.Value);
    }

    protected abstract Task Handle(BrsCommand command);

    //protected virtual Task Handle(BrsCommand command)
    //{
    //    throw new NotSupportedException();
    //    // return Task.CompletedTask;
    //}
}