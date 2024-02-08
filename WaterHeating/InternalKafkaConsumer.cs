using Confluent.Kafka;
using KMD.Elements.Libraries.KafkaClient.Consumer;
using Polly;

namespace WaterHeating;

public abstract class InternalKafkaConsumer<TDeserializer> where TDeserializer : IDeserializer<BrsCommand>, new()
{
    public abstract string Topic { get; }

    public InternalKafkaConsumer()
    {
        //_logger = logger;

        var _consumer = new KafkaConsumerBuilder<string, BrsCommand>(new ConsumerConfig { })
            .SetValueDeserializer(new TDeserializer()) // BrsXXXDeserializer
            .SetTopic(Topic)
            .SetDisableAutoStoreOffset()
            .SetEnableDefaultConsumerHandlers()
            //.SetAutoOffsetReset(AutoOffsetReset.Earliest)
            .SetExecutionPolicy(Policy.Handle<Exception>().RetryAsync(3))
            //.SetLogger(logger)
            //.SetServiceProvider(serviceProvider)
            .Build();
    }
}