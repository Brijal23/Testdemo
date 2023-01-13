using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers
{
    public partial class HomeController : BasePublicController
    {
        public virtual IActionResult Index()
        {
            return View();
        }
        public virtual IActionResult ContactForm()
        {
            return View();
        }
        public virtual IActionResult Paymentmethod()
        {

            return View();
        }
        public virtual IActionResult CustomTotals()
        {
            return View();
        }
    }
}