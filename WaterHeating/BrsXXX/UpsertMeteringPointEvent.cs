namespace WaterHeating.BrsXXX;

public record UpsertMeteringPointEvent(string MeteringPointCustomerVersionId, string MeteringPointId) : BrsEvent();