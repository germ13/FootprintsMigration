namespace FootprintsMigration.Core
{

    [System.Xml.Serialization.SoapTypeAttribute("CreateIssueArgs", "MRWebServices")]
    public class CreateIssueArgs
    {
        public string projectID;
        public string title;
        public string description;
        public string status;
        public int priorityNumber;
    }
}
