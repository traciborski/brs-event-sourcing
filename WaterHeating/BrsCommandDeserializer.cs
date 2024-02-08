using Confluent.Kafka;
using System.Text.Json;

namespace WaterHeating;

public class BrsCommandDeserializer : IDeserializer<BrsCommand>
{
    public BrsCommand Deserialize(ReadOnlySpan<byte> data, bool isNull, SerializationContext context)
    {
        var typeName = context.Headers.First(x => x.Key == "type").GetValueBytes().ToString(); // todo

        return (BrsCommand)JsonSerializer.Deserialize(data, Type.GetType(typeName));

        //var xxx1 = JsonSerializer.Deserialize(data, typeof(BrsCommand));
        //var xxx2 = JsonSerializer.Deserialize(data, typeof(UpsertMeteringPointCommand));

    }
}