using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrioStroy
{
    public static class HtmlExtensions
    {
        public static string IsSelected(this HtmlHelper html, string controller = null, string action = null)
        {
            string currentAction = (string)html.ViewContext.RouteData.Values["action"];
            string currentController = (string)html.ViewContext.RouteData.Values["controller"];

            if (String.IsNullOrEmpty(controller))
                controller = currentController;

            if (String.IsNullOrEmpty(action))
                action = currentAction;

            return controller == currentController && action == currentAction ?
                "active" : String.Empty;
        }

        public static string GetHello()
        {
            return "Hello, World!";
        }
    }

    public class Account
    {
        // ...
        double SchedulePayment()
        {
            DateTime paymentDate = GetNearFirstDate(previousDate);

            // Issue a payment using paymentDate.
            // ...
        }

        //TODO: Foreign method. Should be on DateTime.
        public static DateTime GetNearFirstDate(DateTime date)
        {
            if (date.Day == 1)
                return date;

            DateTime nextDate = date.AddMonths(1);

            return new DateTime(nextDate.Year, nextDate.Month, 1);
        }
    }

}