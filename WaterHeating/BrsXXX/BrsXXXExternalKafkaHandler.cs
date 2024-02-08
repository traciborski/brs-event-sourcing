namespace WaterHeating.BrsXXX;

internal class BrsXXXExternalKafkaHandler 
    : ExternalKafkaHandler<UpsertMeteringPointCustomerVersionCommandExecutedEventPayload, UpsertMeteringPointCommand>
{
    protected override UpsertMeteringPointCommand Map(UpsertMeteringPointCustomerVersionCommandExecutedEventPayload message)
    {
        throw new NotImplementedException();
    }

    protected override string RecognizeBrsId(UpsertMeteringPointCommand command)
    {
        return Guid.NewGuid().ToString();
    }

    protected override string RecognizeTopic(UpsertMeteringPointCommand command)
    {
        return "topic.team9.commands.brs-xxx";
    }
}