namespace WaterHeating.BrsXXX;

public class BrsXXXCommandHandler // recognizer
    : BaseBrsHandler<UpsertMeteringPointCustomerVersionCommand>
//, BaseBrsHandler<object>
{
    private const string Brs = "BRSXXX"; // enum?

    protected override string RecognizeBrs(UpsertMeteringPointCustomerVersionCommand command)
    {
        return Brs; // 
    }

    protected override string RecognizeId(UpsertMeteringPointCustomerVersionCommand command)
    {
        // custom actions like:
        // send sth to domains
        // send sth to PC

        // generic behaviour like:
        // emit or return event

        //var id = Guid.NewGuid().ToString();
        //var brs = new BrsXXX(); // recognize

        return Guid.NewGuid().ToString();

        //var id = command.MeteringPointId; // whatever

        //await EnqueueCommandAsync("", id);

        //var oldEvents = new BrsEvent[0];
        //brs.Apply(oldEvents);
        //var events = brs.Handle(command);
        // persist new events
    }
}