using Ext.Net;
using Ext.Net.MVC;
using System.Web.Mvc;

namespace ExtendingExtNet.Mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Button_Click(string Item)
        {
            X.Msg.Show(new MessageBoxConfig() { Title = "Info", Message = "Testing" });
            return this.Direct();
        }
    }
}