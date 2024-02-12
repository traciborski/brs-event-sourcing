namespace WaterHeating;

public class BrsEvent2
{
    public string BrsId { get; set; }
    public string BrsName { get; set; }
    public string Version { get; set; }
    public string EventType { get; set; }

    public string Payload1 { get; set; } // 
    
    public object Payload2 { get; set; } // 
    
    public Dictionary<string, string> Payload3 { get; set; } // 

    // Payload.MeteringPointId
}