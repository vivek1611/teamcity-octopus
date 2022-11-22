namespace PartyLifeCycleSample;

public class PartyRelationshipProcedure
{
    [Newtonsoft.Json.JsonProperty("CustomerReference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public object CustomerReference { get; set; }
    
    [Newtonsoft.Json.JsonProperty("PartyReference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public object PartyReference { get; set; }
    
    [Newtonsoft.Json.JsonProperty("PartyRelationshipType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string PartyRelationshipType { get; set; }
    
    [Newtonsoft.Json.JsonProperty("PartyLife-cycleMaintenanceSchedule", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string PartyLifeCycleMaintenanceSchedule { get; set; }
    
    [Newtonsoft.Json.JsonProperty("PartyLife-cycleMaintenanceTask", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string PartyLifeCycleMaintenanceTask { get; set; }
    
    [Newtonsoft.Json.JsonProperty("PartyLife-cycleMaintenanceTaskType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string PartyLifeCycleMaintenanceTaskType { get; set; }
}