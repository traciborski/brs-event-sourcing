namespace WaterHeating.BrsXXX;

public sealed class BrsXXXInternalKafkaConsumer : InternalKafkaConsumer<BrsCommandDeserializer>
{
    public override string Topic => "kmd.elements.brs-xxx";
}