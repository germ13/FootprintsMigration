using System.Xml.Serialization;

namespace FootprintsMigration.Core
{
    [SoapTypeAttribute("CreateIssueArgs", "MRWebServices")]
    public class EditIssueArgs
    {
        public string projectID;
        public string mrID;
        public string title;
    }
}
