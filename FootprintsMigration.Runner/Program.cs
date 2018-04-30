using FootprintsMigration.Core;
using System;
using System.Xml;

namespace FootprintsMigration.Runner
{
    public class Program
    {
        public static void Main(string[] args)
        {


        }




    }


    public class main
    {
        private static void ParseXml(XmlReader reader)
        {
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
                                Console.WriteLine("Title: " + reader.Value);
                            }
                            else if (reader.Name == "key" && reader.Value == "mr")
                            {
                                reader.Read();
                                Console.WriteLine("Issue Number: " + reader.Value);
                            }
                            else if (reader.Name == "key" && reader.Value == "status")
                            {
                                reader.Read();
                                Console.WriteLine("Issue Status: " + reader.Value);
                            }
                            else if (reader.Name == "key" && reader.Value == "Product")
                            {
                                reader.Read();
                                Console.WriteLine("Product: " + reader.Value);
                            }
                            else if (reader.Name == "key" && reader.Value == "Last__bName")
                            {
                                reader.Read();
                                Console.WriteLine("Last Name: " + reader.Value);
                            }
                            else if (reader.Name == "key" && reader.Value == "First__bName")
                            {
                                reader.Read();
                                Console.WriteLine("First Name: " + reader.Value);
                            }
                        }
                        break;
                }
            }
        }

        [STAThread]

        static void Mainxxx()

        {

            System.IO.StringReader stream = null;

            System.Xml.XmlTextReader reader = null;

            try

            {

                GetIssueDetails obj = new GetIssueDetails();

                byte[] resultBytes = obj.MRWebServices__getIssueDetails(

                    "Webservices",

                    "root",

                    "RETURN_MODE => 'xml'",

                    12,

                    20047,

                    2); //the number 2 should be hard coded

                // The below encoding line may assumes FootPrints is using

                // UTF8. If using a different local encoding, you may need

                // to change the line to (example assumes Windows-1252):

                // System.Text.Encoding encoding =

                // System.Text.GetEncoding(1252);

                System.Text.Encoding encoding = System.Text.Encoding.UTF8;

                // In addition to replacing the above encoding line, if

                // using a different encoding and saving data to

                // FootPrints, you will need to place a line in your

                // MRlocalDefs file with the following information (this

                // also assumes Windows-1252):

                // $FP::WEB_SERVICES_ENCODING = 'cp1252';

                string result = encoding.GetString(resultBytes);

                Console.WriteLine("XML RESULT:\n-----------\n" + result);

                Console.WriteLine("PARSING RESULT:\n---------------");

                stream = new System.IO.StringReader(result);

                reader = new System.Xml.XmlTextReader(stream);

                ParseXml(reader);

            }

            catch (Exception e)

            {

                Console.WriteLine("Exception: {0}", e.ToString());

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





    class main__

    {

        private static void ParseXml(XmlReader reader)

        {

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

                                Console.WriteLine("Title: " + reader.Value);

                            }

                            else if (reader.Name == "key" && reader.Value == "mrid")

                            {

                                reader.Read();

                                Console.WriteLine("Issue Number: " + reader.Value);

                            }

                        }

                        break;

                }

            }

        }

        [STAThread]

        static void Mainxx()

        {

            System.IO.StringReader stream = null;

            System.Xml.XmlTextReader reader = null;

            try

            {

                Search search = new Search();

                byte[] resultBytes = search.MRWebServices__search(

                    "Webservices",

                    "root",

                    "RETURN_MODE => 'xml'",

                    @"SELECT MASTER12.mrID, mrPRIORITY, mrASSIGNEES, mrUPDATEDATE, mrSTATUS, mrTITLE, mrURGENT,
                    mrSUBMITTER, mrATTACHMENTS, First__bName, Last__bName
                    from MASTER12 inner join MASTER12_ABDATA on MASTER12.MRID = MASTER12_ABDATA.MRID
                    WHERE mrSTATUS <> '_DELETED_' and((((mrTITLE LIKE '%.Net%'"
                    +
                    " or(CONTAINS(MASTER12.*, '\"*.Net*\"')) or Platform LIKE '%__dNet%'"
                    +
                    @"or Product LIKE '%__dNet%' or request__btype LIKE '%__dNet%'
                    or Projected__brelease LIKE '%__dNet%' or FootPrints__bfeature LIKE '%__dNet%'
                    or DB LIKE '%__dNet%' or Complexity LIKE '%__dNet%' or Current__bversion LIKE '%__dNet%'
                    or Was__b5__d5__d1 LIKE '%__dNet%' or LocalDefs__bVariable LIKE '%.Net%'
                    or Customer__bpatch__Q LIKE '%__dNet%' or Not__bin__bGDBM__Q LIKE '%__dNet%'
                    or Tester__bAssigned LIKE '%__dNet%' or Alpha__b1__bVerified LIKE '%__dNet%'
                    or Fixed__bin LIKE '%__dNet%' or Alpha__b2__bVerified LIKE '%__dNet%'
                    or Alpha__b3__bVerified LIKE '%__dNet%' or Multi__bSelect__bField LIKE '%__dNet%'
                    or DateTime__bField__bLink LIKE '%.Net%' or SLA LIKE '%__dNet%'
                    or Last__bName LIKE '%.Net%' or First__bName LIKE '%.Net%'
                    or Email__baddress LIKE '%.Net%' or Company LIKE '%.Net%' or Phone LIKE '%.Net%'
                    or Customer__bstatus LIKE '%__dNet%' or Salesperson LIKE '%__dNet%'
                    or Country LIKE '%.Net%' or on__bor__boff LIKE '%__dNet%')) ) )
                    order by MASTER12.mrID DESC",

                    2); //the number 2 should be hard coded

                // The below encoding line may assumes FootPrints is using

                // UTF8. If using a different local encoding, you may need

                // to change the line to (example assumes Windows-1252):

                // System.Text.Encoding encoding =

                // System.Text.GetEncoding(1252);

                System.Text.Encoding encoding = System.Text.Encoding.UTF8;

                // In addition to replacing the above encoding line, if

                // using a different encoding and saving data to

                // FootPrints, you will need to place a line in your

                // MRlocalDefs file with the following information (this

                // also assumes Windows-1252):

                // $FP::WEB_SERVICES_ENCODING = 'cp1252';

                string result = encoding.GetString(resultBytes);

                Console.WriteLine("XML RESULT:\n-----------\n" + result);

                Console.WriteLine("PARSING RESULT:\n---------------");

                stream = new System.IO.StringReader(result);

                reader = new System.Xml.XmlTextReader(stream);

                ParseXml(reader);

            }

            catch (Exception e)

            {

                Console.WriteLine("Exception: {0}", e.ToString());

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



    //public class mainy

    //{

    //    [STAThread]

    //    static void Mainx()

    //    {

    //        EditIssue issue = new EditIssue();

    //        ABFields abFields = new ABFields();

    //        abFields.Custom__bAB__bField__bOne = "NEW VALUE FOR Custom AB Field One";

    //        ProjFields projFields = new ProjFields();

    //        projFields.Custom__bField__bTwo = "NEW VALUE FOR Custom Field Two";

    //        EditIssueArgs issueargs = new EditIssueArgs();

    //        issueargs.projectID = "78";

    //        issueargs.mrID = "11";

    //        issueargs.title = "NEW title is here.";

    //        issueargs.abfields = abFields;

    //        issueargs.projfields = projFields;

    //        issue.MRWebServices__editIssue(

    //            "WebServices",

    //            "fakepassword",

    //            "",

    //            issueargs

    //        );

    //        Console.WriteLine("done");

    //    }

    //}



    //class main00
    //{

    //    [STAThread]

    //    static void Main00()

    //    {

    //        CreateIssue issue = new CreateIssue();

    //        ABFields abFields = new ABFields();

    //        abFields.Last__bName = "Doe";

    //        abFields.First__bName = "John";

    //        abFields.Email__baddress = "johndoe@nowhere.com";

    //        //abFields.Custom__bAB__bField__bOne = "Value of Custom AB Field One"; //TODO comment?

    //        ProjFields projFields = new ProjFields();

    //        projFields.Custom__bField__bOne = "Value of Custom Field One";

    //        //projFields.Custom__bField__bTwo = "Value of Custom Field Two"; //TODO comment?

    //        CreateIssueArgs issueargs = new CreateIssueArgs();

    //        issueargs.projectID = "78";

    //        issueargs.title = "Place title of new issue here.";

    //        issueargs.assignees = new string[] { "user1", "user2" };

    //        issueargs.priorityNumber = 1;

    //        issueargs.status = "Open";

    //        issueargs.description = "Place issue description here.\nFrom C# code.";

    //        issueargs.abfields = abFields;

    //        issueargs.projfields = projFields;

    //        string result = issue.MRWebServices__createIssue(

    //            "WebServices",

    //            "fakepassword",

    //            "",

    //            issueargs

    //        );

    //        Console.WriteLine("Issue " + result + " has been created.\n");

    //    }

    //}


    class main01

    {

        private static void ParseXml(XmlReader reader)

        {

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

                                Console.WriteLine("Title: " + reader.Value);

                            }

                            else if (reader.Name == "key" && reader.Value == "mr")

                            {

                                reader.Read();

                                Console.WriteLine("Issue Number: " + reader.Value);

                            }

                            else if (reader.Name == "key" && reader.Value == "status")

                            {

                                reader.Read();

                                Console.WriteLine("Issue Status: " + reader.Value);

                            }

                        }

                        break;

                }

            }

        }

        [STAThread]

        static void Main01()

        {

            System.IO.StringReader stream = null;

            System.Xml.XmlTextReader reader = null;

            try

            {

                GetIssueDetails obj = new GetIssueDetails();

                byte[] resultBytes = obj.MRWebServices__getIssueDetails(

                    "WebServices",

                    "fakepassword",

                    "RETURN_MODE => 'xml'",

                    12,

                    20047,

                    2); //The number 2 should be hard coded.

                //The below coding line may assume FootPrints is using,

                //UTF8. If using a different local encoding, you may need

                //to chahge the line to (example assumes Windows-1252):



                //System.Text.Encoding encoding =

                //    System.Text.GetEncoding(1252);

                System.Text.Encoding encoding = System.Text.Encoding.UTF8;



                //In addition to replacing the above encoding line, if

                //using a different encoding and saving data to

                //FootPrints, you will need to place a line in your

                //MRlocalDefs file with the following information (this

                //also assumes Windows-1252):



                //$FP::WEB_SERVICES_ENCODING = 'cp1252';

                string result = encoding.GetString(resultBytes);



                Console.WriteLine("XML RESULT:\n-----------\n" + result);

                Console.WriteLine("PARSING RESULT:\n---------------");

                stream = new System.IO.StringReader(result);

                reader = new System.Xml.XmlTextReader(stream);

                ParseXml(reader);

            }

            catch (Exception e)

            {

                Console.WriteLine("Exception: {0}", e.ToString());

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

    class main02

    {

        private static void ParseXml(XmlReader reader)

        {

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

                                Console.WriteLine("Title: " + reader.Value);

                            }

                            else if (reader.Name == "key" && reader.Value == "mrid")

                            {

                                reader.Read();

                                Console.WriteLine("Issue Number: " + reader.Value);

                            }

                        }

                        break;

                }

            }

        }

        [STAThread]

        static void Main02()

        {

            System.IO.StringReader stream = null;

            System.Xml.XmlTextReader reader = null;

            try

            {

                Search search = new Search();

                byte[] resultBytes = search.MRWebServices__search(

                    "WebServices",

                    "fakepassword",

                    "RETURN_MODE => 'xml'",

                   @"SELECT MASTER12.mrID, mrPRIORITY, mrASSIGNEES, mrUPDATEDATE, mrSTATUS, mrTITLE, mrURGENT,
                        mrSUBMITTER, mrATTACHMENTS, First__bName, Last__bName
                        from MASTER12 inner join MASTER12_ABDATA on MASTER12.MRID = MASTER12_ABDATA.MRID
                        WHERE mrSTATUS <> '_DELETED_' and((((mrTITLE LIKE '%.Net%'"
                        +
                        " or(CONTAINS(MASTER12.*, '\"*.Net*\"')) or Platform LIKE '%__dNet%'"
                        +
                        @"or Product LIKE '%__dNet%' or request__btype LIKE '%__dNet%'
                        or Projected__brelease LIKE '%__dNet%' or FootPrints__bfeature LIKE '%__dNet%'
                        or DB LIKE '%__dNet%' or Complexity LIKE '%__dNet%' or Current__bversion LIKE '%__dNet%'
                        or Was__b5__d5__d1 LIKE '%__dNet%' or LocalDefs__bVariable LIKE '%.Net%'
                        or Customer__bpatch__Q LIKE '%__dNet%' or Not__bin__bGDBM__Q LIKE '%__dNet%'
                        or Tester__bAssigned LIKE '%__dNet%' or Alpha__b1__bVerified LIKE '%__dNet%'
                        or Fixed__bin LIKE '%__dNet%' or Alpha__b2__bVerified LIKE '%__dNet%'
                        or Alpha__b3__bVerified LIKE '%__dNet%' or Multi__bSelect__bField LIKE '%__dNet%'
                        or DateTime__bField__bLink LIKE '%.Net%' or SLA LIKE '%__dNet%'
                        or Last__bName LIKE '%.Net%' or First__bName LIKE '%.Net%'
                        or Email__baddress LIKE '%.Net%' or Company LIKE '%.Net%' or Phone LIKE '%.Net%'
                        or Customer__bstatus LIKE '%__dNet%' or Salesperson LIKE '%__dNet%'
                        or Country LIKE '%.Net%' or on__bor__boff LIKE '%__dNet%')) ) )
                    order by MASTER12.mrID DESC",


                    2); //The number 2 should be hard coded

                // The below encoding line may assumes FootPrints is using

                // UTF8. If using a different local encoding, you may need

                // to change the line to (example assumes Windows-1252):



                // System.Text.Encoding encoding =

                // System.Text.GetEncoding(1252);

                System.Text.Encoding encoding = System.Text.Encoding.UTF8;



                // In addition to replacing the above encoding line, if

                // using a different encoding and saving data to

                // FootPrints, you will need to place a line in your

                // MRlocalDefs file with the following information (this

                // also assumes Windows-1252):



                // $FP::WEB_SERVICES_ENCODING = 'cp1252';

                string result = encoding.GetString(resultBytes);



                Console.WriteLine("XML RESULT:\n-----------\n" + result);

                Console.WriteLine("PARSING RESULT:\n---------------");

                stream = new System.IO.StringReader(result);

                reader = new System.Xml.XmlTextReader(stream);

                ParseXml(reader);

            }

            catch (Exception e)

            {

                Console.WriteLine("Exception: {0}", e.ToString());

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
