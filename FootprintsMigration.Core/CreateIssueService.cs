using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootprintsMigration.Core
{
    public class CreateIssueService
    {
        public string createIssue(string projid, string title, string desc)
        {
            CreateIssueServiceCalller issue = new CreateIssueServiceCalller();
            CreateIssueArgs issueargs = new CreateIssueArgs();

            issueargs.projectID = projid;
            issueargs.title = title;
            issueargs.description = desc;
            issueargs.status = "Open";
            issueargs.priorityNumber = 1;

            string result = issue.MRWebServices__createIssue(
                "WebServices", "fakepassword", "", issueargs);

            return "Issue " + result + " has been created.";
        }
    }
}
