using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Payments.NewPayment.Models;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Payments.SamplePaymentMethod.Components
{
    [ViewComponent(Name = "PaymentNewPayment")]
    public class SimplePaymentViewComponent: NopViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = new NewPaymentInfoModel();
            return View("~/Plugins/Payments.PayPalCommerce/Views/NewPaymentInfo.cshtml", model);
            //return View("~/Plugins/Payment.Newpayment/Views/NewPaymentInfo.cshtml");
        }
    }
}
