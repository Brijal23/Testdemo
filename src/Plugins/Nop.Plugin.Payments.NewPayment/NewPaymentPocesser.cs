using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExCSS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Nop.Core.Domain.Orders;
using Nop.Plugin.Payments.NewPayment.Components;
using Nop.Services.Cms;
using Nop.Services.Payments;
using Nop.Services.Plugins;
using Nop.Web.Framework;
using Nop.Web.Framework.Infrastructure;
using Nop.Web.Framework.Menu;

namespace Nop.Plugin.Payments.NewPayment
{
    public class NewPaymentPocesser:BasePlugin,IWidgetPlugin,IAdminMenuPlugin
    {
        public Task ManageSiteMapAsync(SiteMapNode rootNode)
        {
            var menuItem = new SiteMapNode()
            {
                SystemName = "Payments.NewPayment",
                Title = "NewPayment",
                ControllerName = "PaymentController",
                ActionName = "CustomTotals",
                IconClass = "far fa-dot-circle",
                Visible = true,
                RouteValues = new RouteValueDictionary() { { "area", AreaNames.Admin } },
            };
            var pluginNode = rootNode.ChildNodes.FirstOrDefault(x => x.SystemName == "Payments.NewPayment");
            if (pluginNode != null)
                pluginNode.ChildNodes.Add(menuItem);
            else
                rootNode.ChildNodes.Add(menuItem);

            return Task.CompletedTask;
        }
        public bool HideInWidgetList => true;
        //public bool SupportCapture => throw new NotImplementedException();

        //public bool SupportPartiallyRefund => throw new NotImplementedException();

        //public bool SupportRefund => throw new NotImplementedException();

        //public bool SupportVoid => throw new NotImplementedException();

       // public RecurringPaymentType RecurringPaymentType => throw new NotImplementedException();

        //public PaymentMethodType PaymentMethodType => throw new NotImplementedException();

        //public bool SkipPaymentInfo => throw new NotImplementedException();

        //public bool HideInWidgetList => throw new NotImplementedException();

        //public Task<CancelRecurringPaymentResult> CancelRecurringPaymentAsync(CancelRecurringPaymentRequest cancelPaymentRequest)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> CanRePostProcessPaymentAsync(Order order)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<CapturePaymentResult> CaptureAsync(CapturePaymentRequest capturePaymentRequest)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<decimal> GetAdditionalHandlingFeeAsync(IList<ShoppingCartItem> cart)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<ProcessPaymentRequest> GetPaymentInfoAsync(IFormCollection form)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<string> GetPaymentMethodDescriptionAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public Type GetPublicViewComponent()
        //{
        //    throw new NotImplementedException();
        //}

        public Type GetWidgetViewComponent(string widgetZone)
        {
            return typeof(PaymentNewPaymentViewComponent);
        }

        public Task<IList<string>> GetWidgetZonesAsync()
        {
            return Task.FromResult<IList<string>>(new List<string> { PublicWidgetZones.ProductDetailsTop });
        }

        //public Task<bool> HidePaymentMethodAsync(IList<ShoppingCartItem> cart)
        //{
        //    throw new NotImplementedException();
        //}

        public override Task InstallAsync()
        {
            return base.InstallAsync();
        }
        public override Task UninstallAsync()
        {
            return base.UninstallAsync();
        }
        //public Task ManageSiteMapAsync(SiteMapNode rootNode)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task PostProcessPaymentAsync(PostProcessPaymentRequest postProcessPaymentRequest)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<ProcessPaymentResult> ProcessPaymentAsync(ProcessPaymentRequest processPaymentRequest)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<ProcessPaymentResult> ProcessRecurringPaymentAsync(ProcessPaymentRequest processPaymentRequest)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<RefundPaymentResult> RefundAsync(RefundPaymentRequest refundPaymentRequest)
        //{
        //    throw new NotImplementedException();
        //}



        //public Task<IList<string>> ValidatePaymentFormAsync(IFormCollection form)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<VoidPaymentResult> VoidAsync(VoidPaymentRequest voidPaymentRequest)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
