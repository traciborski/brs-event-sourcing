namespace WaterHeating.BrsXXX;

public class BrsXXXInternalKafkaHandler : InternalKafkaHandler 
{
    protected override BaseBrs Brs => new BrsXXX();
}