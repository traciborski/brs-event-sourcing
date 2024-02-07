namespace WaterHeating.BrsXXX;

internal class KafkaHandler : BaseKafkaHandler<UpsertMeteringPointCustomerVersionCommandExecutedEventPayload, UpsertMeteringPointCustomerVersionCommand>
{
    protected override UpsertMeteringPointCustomerVersionCommand Map(UpsertMeteringPointCustomerVersionCommandExecutedEventPayload message)
    {
        throw new NotImplementedException();
    }
}