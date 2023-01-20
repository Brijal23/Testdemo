using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core.Domain.Cms;
using Nop.Core;
using Nop.Services.Security;

namespace Nop.Web.Controllers
{
    public partial class PaymentController : BasePublicController
    {
        //public virtual IActionResult Index()
        //{
        //    return View();
        //}
        //public virtual IActionResult ContactForm()
        //{
        //    return View();
        //}
        //public virtual IActionResult Paymentmethod()
        //{

        //    return View();
        //}
        [HttpGet]
        public  IActionResult CustomTotals()
        {
            return View("~/Plugins/Payments.NewPayment/Views/Payment/CustomTotals.cshtml");
        }
       
        //public async Task<IActionResult> Configure()
        //{
        //    if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageWidgets))
        //        return AccessDeniedView();

        //    //load settings for a chosen store scope
        //    var storeScope = await _storeContext.GetActiveStoreScopeConfigurationAsync();
        //    var myWidgetSettings = await _settingService.LoadSettingAsync<MyWidgetSettings>(storeScope);

        //    var model = new ConfigurationModel
        //    {
        //        // configuration model settings here
        //    };

        //    if (storeScope > 0)
        //    {
        //        // override settings here based on store scope
        //    }

        //    return View("~/Plugins/Widgets.MyFirstNopWidget/Views/Configure.cshtml", model);
        //}
    }
}