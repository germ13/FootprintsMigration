using System.Web.Services;

namespace FootprintsMigration.Core
{
    [System.ComponentModel.DesignerCategory("Code")]
    [WebServiceBindingAttribute(Name = "EditIssueWebService", Namespace = "MRWebServices")]
    public class EditIssueCaller : System.Web.Services.Protocols.SoapHttpClientProtocol
    {
        public EditIssueCaller()
        {
            this.Url = "http://fakeserver/MRcgi/MRWebServices.pl";
            // Comment this out if not using a proxy server.
            //System.Net.IWebProxy proxyObject = new System.Net.WebProxy("http://localhost:8888/", false);
            //this.Proxy = proxyObject;
        }
        [
        System.Web.Services.Protocols.SoapDocumentMethodAttribute(
            "MRWebServices#MRWebServices__editIssue",
            RequestNamespace = "MRWebServices",
            ResponseNamespace = "MRWebServices",
            Use = System.Web.Services.Description.SoapBindingUse.Encoded,
            ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)
        ]

        [return: System.Xml.Serialization.SoapElementAttribute("return")]

        public void MRWebServices__editIssue(
            string usr,
            string pw,
            string extraInfo,
            EditIssueArgs args)
        {
            object[] results = this.Invoke(
                "MRWebServices__editIssue",
                new object[] { usr, pw, extraInfo, args });
        }
    }
}