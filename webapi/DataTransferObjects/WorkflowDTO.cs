
using System.Security.Policy;

namespace webapi.DataTransferObjects
{
    public class StageTypeTab
    {
        public ShortListingTab? ShortlistingInfo { get; set; }
        public VideoInterviewTab? VideoInterviewInfo { get; set; }
        public PlacementTab? PlacementInfo { get; set; }
    }
    public class PlacementTab
    {
        public string? PlacementSection { get; set; }
    }
    public class VideoInterviewTab
    {
        public string? VideoInterviewQuestion { get; set; }
        public string? AdditionalInformationForInterview { get; set; }
        public int? MaxDuration { get; set; }
        public int? Sec_Min { get; set; }
        public int? DeadlineDays { get; set; }
    }

    public class ShortListingTab
    {
        public string? ShortListingInfoSection { get; set; }
    }

    public class WorkflowDTO
    {
        public string? id { get; set; }
        public List<string>? Stages { get; set; }
        public string? StageName { get; set; }
        public StageTypeTab? StageType { get; set; }

    }
}
