namespace WaterHeating.BrsXXX;

public class BrsXXXInternalKafkaHandler : InternalKafkaHandler 
{
    public override string Topic => "topic.brs-xxx";

    protected override async Task<IEnumerable<BrsEvent>> Handle(BrsCommand command)
    {
        var brs = new BrsXXX();

        if(command is UpsertMeteringPointCommand x)
            return brs.Handle(x);
        else
            throw new NotSupportedException();
    }


    protected Type MapType(string typeName)
    {
        switch (typeName)
        {
            case "UpsertMeteringPointCommand":
                return typeof(UpsertMeteringPointCommand);
            default:
                throw new NotSupportedException();
        }
    }

}