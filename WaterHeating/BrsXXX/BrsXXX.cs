namespace WaterHeating.BrsXXX;

public class BrsXXX : BaseBrs, IBrsXXXReadModel, IBrsXXXHandler
{
    public override void Apply(BrsEvent @event)
    {
        if (@event is UpsertMeteringPointEvent upsert)
            Apply(upsert);
        else
            throw new NotSupportedException();
    }

    public void Apply(UpsertMeteringPointEvent upsert)
    {
        // Status = BrsStatus.ProcessStarted; // for example
    }

    public void Apply(RejectedEvent upsert)
    {
        // throw new NotImplementedException();
    }

    public override IEnumerable<BrsEvent> Handle(BrsCommand command)
    {
        if (command is UpsertMeteringPointCommand upsert)
            return Handle(upsert);

        throw new NotSupportedException();
    }

    public IEnumerable<BrsEvent> Handle(UpsertMeteringPointCommand command)
    {
        var invalid = false;

        if (invalid)
        {
            //yield return new InvalidSthEvent("RequiresManualHandling");
            //throw new Exception();
        }

        // if status == BrsStatus.ProcessStarted then throw exception

        // send sth to domains
        // if failed
        yield return new ProcessCenterEvent("Failed");
        // and return;

        // send sth to PC

        yield return new ProcessCenterEvent("RequiresManualHandling");

        yield return new UpsertMeteringPointEvent(command.MeteringPointCustomerVersionId, command.MeteringPointId);
    }

    void IBrsXXXHandler.Handle(UpsertMeteringPointCommand upsert)
    {
        throw new NotImplementedException();
    }
}