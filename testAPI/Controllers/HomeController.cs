using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace testAPI.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult>  Index()
        {
            using (var client = new HttpClient())
            {
            //    client.BaseAddress = new Uri("http://demohoadon.minvoice.com.vn");
            //    var content = new FormUrlEncodedContent(new[]
            //    {
            //    new KeyValuePair<string, string>("username", "administrator"),
            //     new KeyValuePair<string, string>("password", "kythuat"),
            //      new KeyValuePair<string, string>("ma_dvcs", "VP")

            //});
            //    var result = await client.PostAsync("/api/Account/Login", content);
            //    string resultContent = await result.Content.ReadAsStringAsync();
            //    var obj = JObject.Parse(resultContent);
            //    var kq = obj["token"].ToString();
            //    if (kq != null)
            //    {
            //        System.Diagnostics.Debug.WriteLine(kq);
            //    }
                WebClient client2 = new WebClient();
                client2.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                client2.Encoding = System.Text.Encoding.UTF8;
                string tendangnhap = "administrator";
                string matkhau = "kythuat";
                string json = "{\"username\":\"" + tendangnhap + "\",\"password\":\"" + matkhau + "\",\"ma_dvcs\":\"VP\"}";
                // 
                string reslt = client2.UploadString("http://demohoadon.minvoice.com.vn/api/Account/Login", json);
                JObject tk = JObject.Parse(reslt);
                string kq = tk["token"].ToString();
                using (var client1 = new HttpClient())
                {
                    client1.BaseAddress = new Uri("http://demohoadon.minvoice.com.vn");
                    client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
                    client1.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", kq);
                    
            //     var content1 = new FormUrlEncodedContent(new[]
            //    {
            //    new KeyValuePair<string, string>("username", "administrator"),
            //     new KeyValuePair<string, string>("password", "kythuat"),
            //      new KeyValuePair<string, string>("ma_dvcs", "VP")

            //});
                    var result1 = await client1.GetAsync("/api/System/GetDataReferencesByRefId?refId=RF00027");
                    string resultContent1 = await result1.Content.ReadAsStringAsync();
                    var obj1 = JObject.Parse(resultContent1);
                    //double a = Math.Round();
                    //System.Diagnostics.Debug.WriteLine(a);
                    //WebClient client2 = new WebClient();
                    //client2.Encoding = Encoding.UTF8;
                    //client2.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    //client2.Headers.Add(HttpRequestHeader.Authorization, token);
                }

            }
           


                return View();
        }
    }
}
