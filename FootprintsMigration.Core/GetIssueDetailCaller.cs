namespace FootprintsMigration.Core
{
    [System.ComponentModel.DesignerCategory("Code")]
    [
    System.Web.Services.WebServiceBindingAttribute(
        Name = "GetIssueDetailsWebService",
        Namespace = "MRWebServices")
    ]
    public class GetIssueDetailsCaller : System.Web.Services.Protocols.SoapHttpClientProtocol
    {
        public GetIssueDetailsCaller()
        {
            this.Url = "http://fakeserver/MRcgi/MRWebServices.pl";
            // Comment out if not using a proxy server.
            //System.Net.IWebProxy proxyObject = new System.Net.WebProxy("http://localhost:8888/", false);
            //this.Proxy = proxyObject;
        }

        [
        System.Web.Services.Protocols.SoapDocumentMethodAttribute(
            "MRWebServices#MRWebServices__getIssueDetails",
            RequestNamespace = "MRWebServices",
            ResponseNamespace = "MRWebServices",
            Use = System.Web.Services.Description.SoapBindingUse.Encoded,
            ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped
            )
        ]

        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string MRWebServices__getIssueDetails(
            string usr,
            string pw,
            string extraInfo,
            string proj,
            string num)
        {
            object[] results = this.Invoke(
                "MRWebServices__getIssueDetails",
                new object[] { usr, pw, extraInfo, proj, num });
            return ((string)(results[0]));
        }
    }

}
