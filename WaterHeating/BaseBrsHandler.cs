namespace WaterHeating;

public abstract class BaseBrsHandler<TCommand>
{
    public async Task HandleAsync(TCommand command)
    {
        var brs = RecognizeBrs(command);
        var id = RecognizeId(command);
        // add header with key brs-id=@id
        await ProduceAsync("topic.sth." + brs, command);
    }

    private async Task ProduceAsync(string brs, TCommand command)
    {
        throw new NotImplementedException();
    }

    protected abstract string RecognizeId(TCommand command);

    protected abstract string RecognizeBrs(TCommand command); //enum?
}