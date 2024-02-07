namespace WaterHeating;

public abstract class BaseBrsHandler<TCommand>
{
    public async Task HandleAsync(TCommand command)
    {
        var id = RecognizeId(command);
        await ProduceAysnc("brs-");
    }

    private async Task ProduceAysnc(string brs)
    {
        throw new NotImplementedException();
    }

    protected abstract string RecognizeId(TCommand command);

    protected abstract string RecognizeBrs(TCommand command); //enum?
}