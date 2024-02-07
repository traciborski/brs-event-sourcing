using Confluent.Kafka;
using System.Text.Json;

namespace WaterHeating;


public class Deserializer : IDeserializer<BrsCommand>
{
    public BrsCommand Deserialize(ReadOnlySpan<byte> data, bool isNull, SerializationContext context)
    {
        //context.Headers
        //context.Topic

        // get topic and brs and command type and deserialize to custom type

        // map type name from header to Type

        var xxx = JsonSerializer.Deserialize(data, typeof(BrsCommand));

        throw new NotImplementedException();
    }
}