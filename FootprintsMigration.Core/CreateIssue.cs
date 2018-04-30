using System.Web.Services;

namespace FootprintsMigration.Core
{
    [System.ComponentModel.DesignerCategory("Code")]
    [WebServiceBindingAttribute(Name = "CreateIssueWebService", Namespace = "MRWebServices")]
    public class CreateIssue : System.Web.Services.Protocols.SoapHttpClientProtocol
    {
        public CreateIssue()
        {
            this.Url = "http://10.0.12.206/hMRcgi/MRWebServices.pl";

            // Comment this out if not using a proxy server.
            System.Net.IWebProxy proxyObject = new System.Net.WebProxy("http://localhost:8888/", false);
            this.Proxy = proxyObject;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("MRWebServices#MRWebServices__createIssue", RequestNamespace = "MRWebServices", ResponseNamespace = "MRWebServices",
                Use = System.Web.Services.Description.SoapBindingUse.Encoded,
                ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped
            )
        ]

        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string MRWebServices__createIssue(
            string usr,
            string pw,
            string extraInfo,
            CreateIssueArgs args
        )

        {
            object[] results = this.Invoke(
                "MRWebServices__createIssue",
                new object[] { usr, pw, extraInfo, args }
            );

            return ((string)(results[0]));
        }
    }

}
