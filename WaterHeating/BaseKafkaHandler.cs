using Confluent.Kafka;
using KMD.Elements.Libraries.KafkaClient.Handlers;

namespace WaterHeating;

internal abstract class BaseKafkaHandler<TMessage, TCommand>: IKafkaMessageHandler<string, TMessage>
{
    public Task Handle(ConsumeResult<string, TMessage> consumeResult, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    protected abstract TCommand Map(TMessage message);
}