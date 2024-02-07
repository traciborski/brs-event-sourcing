using Confluent.Kafka;
using KMD.Elements.Libraries.KafkaClient.Handlers;

namespace WaterHeating;

internal abstract class InternalKafkaHandler<TCommand>: IKafkaMessageHandler<string, TCommand>
{
    public InternalKafkaHandler()
    {
        

    }
    public Task Handle(ConsumeResult<string, TCommand> consumeResult, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}