namespace WaterHeating.BrsXXX;

public sealed class BrsXXXPathBuilder : BaseBrsPathBuilder
{
    public void Apply(UpsertMeteringPointCustomerVersionEvent @event)
    {
        BrsDetails.Abc = "";
    }
}