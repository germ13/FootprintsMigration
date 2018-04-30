using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootprintsMigration.Core
{
    [System.ComponentModel.DesignerCategory("Code")]
    [
    System.Web.Services.WebServiceBindingAttribute(
        Name = "SearchWebService",
        Namespace = "MRWebServices")
    ]
    public class SearchCaller : System.Web.Services.Protocols.SoapHttpClientProtocol
    {
        public SearchCaller()
        {
            this.Url = "http://fakeserver/MRcgi/MRWebServices.pl";

            // Comment out if not using a proxy server.
            //System.Net.IWebProxy proxyObject = new System.Net.WebProxy("http://localhost:8888/", false);
            //this.Proxy = proxyObject;
        }

        [
        System.Web.Services.Protocols.SoapDocumentMethodAttribute(
            "MRWebServices#MRWebServices__search",
            RequestNamespace = "MRWebServices",
            ResponseNamespace = "MRWebServices",
            Use = System.Web.Services.Description.SoapBindingUse.Encoded,
            ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)
        ]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]

        public string MRWebServices__search(
            string usr,
            string pw,
            string extraInfo,
            string query
            )
        {
            object[] results = this.Invoke(
                "MRWebServices__search",
                new object[] { usr, pw, extraInfo, query });
            return ((string)(results[0]));
        }
    }

}
