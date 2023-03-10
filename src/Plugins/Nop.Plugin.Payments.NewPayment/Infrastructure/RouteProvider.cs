using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Mvc.Routing;

namespace Nop.Plugin.Payments.NewPayment.Infrastructure
{
    /// <summary>
    /// Represents plugin route provider
    /// </summary>
    public class RouteProvider : IRouteProvider
    {
        /// <summary>
        /// Register routes
        /// </summary>
        /// <param name="endpointRouteBuilder">Route builder</param>
        
        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            //endpointRouteBuilder.MapControllerRoute(name: "CustomTotalspage",
            //   "Admin/Payment/CustomTotals",
            //    defaults: new { controller = "Payment", action = "CustomTotals" });

            endpointRouteBuilder.MapControllerRoute("Plugin.Payments.NewPayment.CustomTotals",
                "Admin/Payment/CustomTotals",
                new { controller = "Payment", action = "CustomTotals" });

            //endpointRouteBuilder.MapControllerRoute("Plugin.Payments.NewPayment.Configure",
            //    "Plugins/Payment/Webhook",
            //    new { controller = "PayPalCommerceWebhook", action = "WebhookHandler" });
        }

        /// <summary>
        /// Gets a priority of route provider
        /// </summary>
        public int Priority => 0;
    }
}