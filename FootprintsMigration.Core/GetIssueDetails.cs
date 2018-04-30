using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;

namespace FootprintsMigration.Core
{
    [System.ComponentModel.DesignerCategory("Code")]
    [WebServiceBindingAttribute(Name = "GetIssueDetailsWebService", Namespace = "MRWebServices")]
    public class GetIssueDetails : System.Web.Services.Protocols.SoapHttpClientProtocol
    {
        public GetIssueDetails()
        {
            Url = "http://fakeserver/MRcgi/MRWebServices.pl";
        }

        [SoapDocumentMethodAttribute(
            "MRWebServices#MRWebServices__getIssueDetails",
            RequestNamespace = "MRWebServices",
            ResponseNamespace = "MRWebServices",
            Use = SoapBindingUse.Encoded,
            ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public byte[] MRWebServices__getIssueDetails(string usr, string pw, string extraInfo, int proj, int num, int api)
        {
            object[] results = this.Invoke(
                "MRWebServices__getIssueDetails",
                new object[] { usr, pw, extraInfo, proj, num, api });

            return ((byte[])(results[0]));
        }
    }
}
