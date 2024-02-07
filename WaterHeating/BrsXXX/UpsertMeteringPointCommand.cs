namespace WaterHeating.BrsXXX;

public record UpsertMeteringPointCommand(string MeteringPointCustomerVersionId, string MeteringPointId)
    : BrsCommand;