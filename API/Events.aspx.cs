using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace API
{
    public partial class Events : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //// this is the old way of databinding
            //WebClient client = new WebClient();
            //client.BaseAddress = this.Context.Request.Url.Scheme + "://" + this.Context.Request.Url.Authority + this.Context.Request.ApplicationPath.TrimEnd('/') + '/';

            //var clientcontacts = client.DownloadString("api/Events");

            //var events = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DAL.Event>>(clientcontacts.ToString());
            //foo.DataSource = events;
            //foo.DataBind();




            //HttpClient client = new HttpClient();
            ////client.BaseAddress = new Uri("http://localhost:9000/");

            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //HttpResponseMessage resp = client.GetAsync("api/products").Result;
            //if (resp.IsSuccessStatusCode)
            //{
            //    var events = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DAL.Event>>
            //    //var products = resp.Content.ReadAsAsync<IEnumerable<Product>>().Result;
            //    foreach (var e in events)
            //    {
            //        Console.WriteLine("{0}\t{1};\t{2}", p.Name, p.Price, p.Category);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("{0} ({1})", (int)resp.StatusCode, resp.ReasonPhrase);
            //}
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<DAL.Event> Unnamed_GetData()
        {
            WebClient client = new WebClient();
            client.BaseAddress = this.Context.Request.Url.Scheme + "://" + this.Context.Request.Url.Authority + this.Context.Request.ApplicationPath.TrimEnd('/') + '/';

            var clientcontacts = client.DownloadString("api/Events");

            var events = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DAL.Event>>(clientcontacts.ToString());
            return events.AsQueryable();
        }
    }
}