namespace PartyLifeCycleSample;

public class InitiatePartyRelationshipProcedureResponse
{
    [Newtonsoft.Json.JsonProperty("PartyLife-cycleMaintenanceSchedule", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string PartyLifeCycleMaintenanceSchedule { get; set; }
    
    [Newtonsoft.Json.JsonProperty("PartyLife-cycleMaintenanceTask", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string PartyLifeCycleMaintenanceTask { get; set; }
    
    [Newtonsoft.Json.JsonProperty("PartyLife-cycleMaintenanceTaskType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string PartyLifeCycleMaintenanceTaskType { get; set; }
    
    [Newtonsoft.Json.JsonProperty("PartyLife-cycleMaintenanceWorkProducts", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string PartyLifeCycleMaintenanceWorkProducts { get; set; }

    [Newtonsoft.Json.JsonProperty("PartyLife-cycleMaintenanceTaskResult", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string PartyLifeCycleMaintenanceTaskResult { get; set; }

    [Newtonsoft.Json.JsonProperty("CustomerPrecedentProfileUpdateLog", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string CustomerPrecedentProfileUpdateLog { get; set; }

}