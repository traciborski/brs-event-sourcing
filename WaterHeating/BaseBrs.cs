namespace WaterHeating;

public abstract class BaseBrs
{
    public string BrsId { get; set; } // aka CorrelationKey, or Id, or Identifier, BrsId, BrsKey

    public void Apply(IEnumerable<BrsEvent> events)
    {
        foreach (var @event in events)
        {
            Apply(@event);
        }
    }

    public abstract void Apply(BrsEvent @event);

    public abstract IEnumerable<BrsEvent> Handle(BrsCommand command);
}