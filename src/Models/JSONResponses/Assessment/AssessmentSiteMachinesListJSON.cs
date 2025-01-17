using Newtonsoft.Json;
using System.Collections.Generic;

namespace Azure.Migrate.Export.Models
{
    public class AssessmentSiteMachinesListJSON
    {
        [JsonProperty("value")]
        public List<AssessmentSiteMachinesValue> Values { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class AssessmentSiteMachinesValue
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public AssessmentSiteMachineProperty Properties { get; set; }
    }

    public class AssessmentSiteMachineProperty
    {
        [JsonProperty("discoveryMachineArmId")]
        public string DiscoveryMachineArmId { get; set; }

        [JsonProperty("sqlInstances")]
        public List<string> SqlInstances { get; set; }

        [JsonProperty("webApplications")]
        public List<string> WebApplications { get; set; }
    }
}