using Confluent.Kafka;
using KMD.Elements.Libraries.KafkaClient.Consumer;
using Polly;

namespace WaterHeating;

internal abstract class ExternalKafkaConsumer<TMessage> 
{
    public abstract string Topic { get; }

    public ExternalKafkaConsumer()
    {
        //_logger = logger;

        var _consumer = new KafkaConsumerBuilder<string, TMessage>(new ConsumerConfig { })
            //.SetValueDeserializer(new Deserializer()) // BrsXXXDeserializer
            .SetTopic(Topic)
            //.hand
            .SetDisableAutoStoreOffset()
            .SetEnableDefaultConsumerHandlers()
            //.SetAutoOffsetReset(AutoOffsetReset.Earliest)
            .SetExecutionPolicy(Policy.Handle<Exception>().RetryAsync(3))
            //.SetLogger(logger)
            //.SetServiceProvider(serviceProvider)
            .Build();
    }
}