using System.Collections.Generic;

using Azure.Migrate.Export.Common;

namespace Azure.Migrate.Export.Models
{
    public class AzureVMAsOnPremDataset
    {
        public string DisplayName { get; set; }
        public string DatacenterMachineArmId { get; set; }
        public string DatacenterManagementServerName { get; set; }
        public string Environment { get; set; }
        public Suitabilities Suitability { get; set; }
        public string SuitabilityExplanation { get; set; }
        public string OperatingSystem { get; set; }
        public string BootType { get; set; }
        public int NumberOfCores { get; set; }
        public double MegabytesOfMemory { get; set; }
        public int NetworkAdapters { get; set; }
        public List<AssessedNetworkAdapter> NetworkAdapterList  { get; set; }
        public string RecommendedVMSize { get; set; }
        public List<AssessedDisk> Disks { get; set; }
        public double StorageMonthlyCost { get; set; }
        public double MonthlyComputeCostEstimate { get; set; }
        public string GroupName { get; set; }
    }
}