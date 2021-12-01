using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SpamHitToURL.Models
{
    public class URIHitterHelper
    {
        public string URI { get; set; }

        public URIHitterHelper()
        {
            URI = "";
        }

        public URIHitterHelper(string _newuri)
        {
            URI = _newuri;
        }

        public string HitUrl(string xmlToSend)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), URI))
                {
                    request.Content = new StringContent(xmlToSend);
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/xml");
                    httpClient.Timeout = TimeSpan.FromMilliseconds(20);

                    var response = httpClient.SendAsync(request).Result;
                    string responseInXml =  response.Content.ReadAsStringAsync().Result;

                    return responseInXml;
                }
            }
        }
    }
}
