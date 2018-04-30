using System;
using System.Xml;

namespace FootprintsMigration.Core
{
    public class GetIssueDetailsService
    {
        private static string ParseXml(XmlReader reader)
        {
            string s = "";

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        while (reader.MoveToNextAttribute())
                        {
                            if (reader.Name == "key" && reader.Value == "title")
                            {
                                reader.Read();
                                s += "<b>Title:</b>" + reader.Value;
                                s += "<br>";
                            }
                            else if (reader.Name == "key" && reader.Value == "mr")
                            {
                                reader.Read();
                                s += "<b>Issue Number:</b>" + reader.Value;
                                s += "<br>";
                            }
                            else if (reader.Name == "key" && reader.Value == "status")
                            {
                                reader.Read();
                                s += "<b>Issue Status:</b>" + reader.Value;
                                s += "<br>";
                            }
                        }

                        break;
                }
            }

            return s;
        }

        public string getIssueDetails(string projid, string issueid)
        {
            System.IO.StringReader stream = null;
            System.Xml.XmlTextReader reader = null;

            try
            {
                GetIssueDetailsCaller obj = new GetIssueDetailsCaller();

                string result = obj.MRWebServices__getIssueDetails(
                    "WebServices",
                    "fakepassword",
                    "RETURN_MODE => 'xml'",
                    projid,
                    issueid);

                stream = new System.IO.StringReader(result);
                reader = new System.Xml.XmlTextReader(stream);
                return ParseXml(reader);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
    }
}
