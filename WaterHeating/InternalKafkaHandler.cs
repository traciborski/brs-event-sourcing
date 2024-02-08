using Confluent.Kafka;
using KMD.Elements.Libraries.KafkaClient.Handlers;
using KMD.Elements.Libraries.KafkaClient.Helpers;

namespace WaterHeating;

public abstract class InternalKafkaHandler : IKafkaMessageHandler<string, BrsCommand>
{
    protected abstract BaseBrs Brs { get; }

    public async Task Handle(ConsumeResult<string, BrsCommand> consumeResult, CancellationToken cancellationToken)
    {
        var brsId = consumeResult.Message.Headers.GetCorrelationId().ToString(); // not GetCorrelationId but GetBrsId instead
        Brs.BrsId = brsId; // todo: 

        var oldEvents = await FetchEventsAsync(brsId);
        Brs.Apply(oldEvents);

        var command = consumeResult.Value;
        var events = Brs.Handle(command);

        await PersistAsync(events);
    }

    private async Task<IEnumerable<BrsEvent>> FetchEventsAsync(string brsId)
    {
        throw new NotImplementedException();
    }

    private async Task PersistAsync(IEnumerable<BrsEvent> events)
    {
        var brsId = Brs.BrsId;
        var brsName = Brs.GetType().Name;
        var createdAt = DateTime.UtcNow;
        var eventType = "";
        var payload = "serialize every event";
        var version = 123;

        /* brs-events
            GUID Brs-4 CreateEvent 1 { json } 
            GUID Brs-4 RejectEvent 2 { json }
            GUID Brs-4 SthEvent 3 { json }
        */

        // persist BrsEvent = BrsId, Version (1,2,3), CreatedAt, Brs, Payload (serialized BrsEvent)
        throw new NotImplementedException();
    }
}