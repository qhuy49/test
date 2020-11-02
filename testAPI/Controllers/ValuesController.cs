using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace testAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        static void Main(string[] args)
        {
            Task.Run(() => MainAsync());
            Console.ReadLine();
        }
        public 
        static async Task MainAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://demohoadon.minvoice.com.vn");
                var content = new FormUrlEncodedContent(new[]
                {
                new KeyValuePair<string, string>("username", "login"),
               
            });
                var result = await client.PostAsync("/api/Account/Login", content);
                string resultContent = await result.Content.ReadAsStringAsync();
                Console.WriteLine(resultContent);
            }
        }
    }
}
