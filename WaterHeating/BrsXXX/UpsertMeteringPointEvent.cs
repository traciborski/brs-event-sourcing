namespace WaterHeating.BrsXXX;

public record UpsertMeteringPointEvent(
    string MeteringPointCustomerVersionId, 
    //string responseFromMeteringPointsDomain,
    string MeteringPointId) 
    : BrsEvent();

public record UpsertMeteringPointEventV2(
    string MeteringPointCustomerVersionId, 
    //string responseFromMeteringPointsDomain,
    string MeteringPointId) 
    : BrsEvent();

public record ConfirmEvent(
    string MeteringPointCustomerVersionId, 
    string responseFromMeteringPointsDomain,
    string MeteringPointId) 
    : BrsEvent();

public record RejectedEvent(
    string Reason) 
    : BrsEvent();

public record ProcessCenterEvent(
    string Reason) 
    : BrsEvent();