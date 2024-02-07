namespace WaterHeating.BrsXXX;

public sealed class BrsXXXPathBuilder : BaseBrsPathBuilder
{
    public void Apply(UpsertMeteringPointEvent @event)
    {
        BrsDetails.Abc = "";
    }
}