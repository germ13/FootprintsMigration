using System;
using System.Xml;

namespace FootprintsMigration.Core
{
    public class SearchService
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
                            if (reader.Name == "key" && reader.Value == "mrtitle")
                            {
                                reader.Read();
                                s += "<b>Title:</b>" + reader.Value + "<br>";
                            }
                            else if (reader.Name == "key" && reader.Value == "mrid")
                            {
                                reader.Read();
                                s += "<b>Issue Number:</b>" + reader.Value + "<br>";
                            }
                        }
                        break;
                }
            }
            return s;
        }

        public string search(string projid, string title){
            System.IO.StringReader stream = null;
            System.Xml.XmlTextReader reader = null;

            try
            {
                SearchCaller search = new SearchCaller();
                string result = search.MRWebServices__search(
                    "WebServices",
                    "fakepassword",
                    "RETURN_MODE => 'xml'",
                    "select mrID, mrTITLE from MASTER" + projid + " WHERE mrTITLE LIKE '%" + title + "%'");

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