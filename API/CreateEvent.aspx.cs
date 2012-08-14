using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Http;

namespace API
{
    public partial class CreateEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void FormView1_InsertItem()
        {
            var item = new DAL.Event();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                // Save changes here
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:44611");
                client.PostAsJsonAsync("api/Event", item);
            }
        }
    }
}