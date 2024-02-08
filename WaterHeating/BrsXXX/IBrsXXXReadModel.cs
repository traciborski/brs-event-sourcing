namespace WaterHeating.BrsXXX;

internal interface IBrsXXXReadModel // hujowa nazwa
{
    void Apply(UpsertMeteringPointEvent upsert);

    void Apply(RejectedEvent upsert);
}

internal interface IBrsXXXHandler 
{
    void Handle(UpsertMeteringPointCommand upsert);
}