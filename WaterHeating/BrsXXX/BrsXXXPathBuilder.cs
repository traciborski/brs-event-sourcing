namespace WaterHeating.BrsXXX;

public sealed class BrsXXXPathBuilder : BaseBrsPathBuilder, IBrsXXXReadModel
{
    public void Apply(UpsertMeteringPointEvent @event)
    {
        BrsDetails.Abc = "";
        BrsDetails.ProcessCenterStatus = "ProcessStarted";
    }

    public void Apply(RejectedEvent @event)
    {
        BrsDetails.Abc = "rejected";
        BrsDetails.ProcessCenterStatus = "RequiresManualHandling";
    }
}