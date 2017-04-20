using System;
using System.IO;
using System.Net.Http;
using System.Xml.Linq;

namespace WsSunat
{
    public class SunatWs
    {
        private const string Domain = "https://e-beta.sunat.gob.pe/ol-ti-itcpfegem-beta/billService";

        public async void Run()
        {
            using (var client = new HttpClient())
            {
                var content = new StreamContent(new FileStream(@"E:\GIANCARLOS\factura.txt", FileMode.Open));
                var uri = new Uri(Domain);
                var r = await client.PostAsync(uri, content);
                r.EnsureSuccessStatusCode();
                using (r)
                {
                    var xml = await r.Content.ReadAsStringAsync();
                    var el = XElement.Parse(xml);
                    var appResp = ((XElement)((XElement)el.LastNode).FirstNode).FirstNode;
                    var base64 = ((XElement)appResp).Value;
                    var bytes = Convert.FromBase64String(base64);
                    var filename = @"E:\GIANCARLOS\file2.zip";
                    File.WriteAllBytes(filename, bytes);
                }
                
            }
        }
    }
}
