using System;
using System.Xml;

namespace FootprintsMigration.Core {

    [System.ComponentModel.DesignerCategory("Code")]
    [
        System.Web.Services.WebServiceBindingAttribute(
            Name = "SearchWebService",
            Namespace = "MRWebServices"
        )
    ]
    public class Search : System.Web.Services.Protocols.SoapHttpClientProtocol
    {
        public Search()
        {
            this.Url = "http://localhost/MRcgi/MRWebServices.pl";
            // Comment out if not using a proxy server.
            System.Net.IWebProxy proxyObject = new System.Net.WebProxy("http://localhost:8888/", false);
            this.Proxy = proxyObject;
        }

        [
            System.Web.Services.Protocols.SoapDocumentMethodAttribute(
                "MRWebServices#MRWebServices__search",
                RequestNamespace = "MRWebServices",
                ResponseNamespace = "MRWebServices",
                Use = System.Web.Services.Description.SoapBindingUse.Encoded,
                ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped
            )
        ]

        [return: System.Xml.Serialization.SoapElementAttribute("return")]

        public byte[] MRWebServices__search(
            string usr,
            string pw,
            string extraInfo,
            string query,
            int api
        )

        {
            object[] results = this.Invoke(
                "MRWebServices__search",
                new object[] { usr, pw, extraInfo, query, api });
            return ((byte[])(results[0]));
        }

    }
}