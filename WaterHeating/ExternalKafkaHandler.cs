using Confluent.Kafka;
using KMD.Elements.Libraries.KafkaClient.Handlers;

namespace WaterHeating;

internal abstract class ExternalKafkaHandler<TExternalMessage, TCommand> : IKafkaMessageHandler<string, TExternalMessage>
{
    public async Task Handle(ConsumeResult<string, TExternalMessage> consumeResult, CancellationToken cancellationToken)
    {
        var externalMessage = consumeResult.Value;
        var command /* aka internal message */ = Map(externalMessage);
        await ProduceInternalMessageAsync(command);
    }

    protected abstract TCommand Map(TExternalMessage message);

    private async Task ProduceInternalMessageAsync(TCommand command)
    {
        var topic = RecognizeTopic(command); // or maybe RecognizeBrs(command);
        var brsId = RecognizeBrsId(command);

        // var header_brs_id = brs;

        throw new NotImplementedException();
    }

    protected abstract string RecognizeBrsId(TCommand command);

    protected abstract string RecognizeTopic(TCommand command); // enum? or RecognizeTopic 
}