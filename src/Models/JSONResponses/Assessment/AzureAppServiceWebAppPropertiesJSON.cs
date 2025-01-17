using Newtonsoft.Json;

namespace Azure.Migrate.Export.Models
{
    public class AzureAppServiceWebAppPropertiesJSON
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("properties")]
        public AzureAppServiceWebAppProperty Properties { get; set; }
    }

    public class AzureAppServiceWebAppProperty
    {
        [JsonProperty("monthlyCost")]
        public double MonthlyCost { get; set; }
    }
}