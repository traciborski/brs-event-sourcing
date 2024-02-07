namespace WaterHeating;

public abstract class BaseBrsPathBuilder
{
    protected BrsPath BrsDetails = new ();

    public BrsPath Build()
    {
        return BrsDetails;
    }
}