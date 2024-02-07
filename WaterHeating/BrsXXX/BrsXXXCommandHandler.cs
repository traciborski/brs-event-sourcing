namespace WaterHeating.BrsXXX;

public class BrsXXXCommandHandler // recognizer?
    : BaseBrsHandler<UpsertMeteringPointCommand> 
    //, BaseBrsHandler<object>
{
    private const string Brs = "BRSXXX"; // enum?

    protected override string RecognizeBrs(UpsertMeteringPointCommand command)
    {
        return Brs; // 
    }

    protected override string RecognizeId(UpsertMeteringPointCommand command)
    {
        return Guid.NewGuid().ToString();
    }
}