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
            DateTime paymentDate = new MfDateTimeWrap(previousDate).GetNearFirstDate();

            // Issue a payment using paymentDate.
            // ...
        }
    }

    public class MfDateTimeWrap
    {
        private DateTime date;

        public MfDateTimeWrap()
            : this(new DateTime())
        { }

        public MfDateTimeWrap(DateTime date)
        {
            this.date = date;
        }

        public DateTime GetNearFirstDate()
        {
            if (this.date.Day == 1)
                return this.date;

            DateTime nextDate = this.date.AddMonths(1);

            return new DateTime(nextDate.Year, nextDate.Month, 1);
        }
    }

}