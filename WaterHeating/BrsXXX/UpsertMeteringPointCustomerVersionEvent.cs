namespace WaterHeating.BrsXXX;

public record UpsertMeteringPointCustomerVersionEvent(string MeteringPointCustomerVersionId, string MeteringPointId) : BrsEvent();