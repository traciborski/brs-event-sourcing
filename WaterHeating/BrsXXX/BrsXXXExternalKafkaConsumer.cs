namespace WaterHeating.BrsXXX;

internal sealed class BrsXXXExternalKafkaConsumer : ExternalKafkaConsumer<UpsertMeteringPointCustomerVersionCommandExecutedEventPayload>
{
    public override string Topic => "kmd.elements.team-yyy.commands-or-events-but-dont-give-a-fuck.upsert-metering-point-customer-version-command-executed-event-payload";
}