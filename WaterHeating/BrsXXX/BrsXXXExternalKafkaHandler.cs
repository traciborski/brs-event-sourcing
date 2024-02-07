namespace WaterHeating.BrsXXX;

internal class BrsXXXExternalKafkaHandler 
    : ExternalKafkaHandler<UpsertMeteringPointCustomerVersionCommandExecutedEventPayload, UpsertMeteringPointCommand>
{
    protected override UpsertMeteringPointCommand Map(UpsertMeteringPointCustomerVersionCommandExecutedEventPayload message)
    {
        throw new NotImplementedException();
    }
}