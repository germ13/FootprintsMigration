namespace FootprintsMigration.Core
{
    public class EditIssueService
    {
        public void editIssue(string projid, string issueid, string newtitle)
        {
            EditIssueCaller issue = new EditIssueCaller();
            EditIssueArgs issueargs = new EditIssueArgs();
            issueargs.projectID = projid;
            issueargs.mrID = issueid;
            issueargs.title = newtitle;
            issue.MRWebServices__editIssue("WebServices", "fakepassword", "", issueargs);
        }
    }

}
