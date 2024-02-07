namespace WaterHeating.BrsXXX;

public class BrsXXX : BaseBrs
{
    //public void Apply(UpsertMeteringPointCustomerVersionEvent @event)
    //{
    //    // 
    //}

    public IEnumerable<BrsEvent> Handle(UpsertMeteringPointCustomerVersionCommand command)
    {
        // custom actions like:
        // send sth to domains
        // send sth to PC

        // generic behaviour like:
        // emit or return event

        yield return new UpsertMeteringPointCustomerVersionEvent(command.MeteringPointCustomerVersionId, command.MeteringPointId);
    }
}