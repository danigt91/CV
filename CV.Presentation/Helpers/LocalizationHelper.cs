using System.Globalization;
using System.Threading;
using System.Web.Mvc;
using System.Web.WebPages;

namespace CV.Presentation.Helpers
{
    public class LocalizationHelper
    {
        public static void SetLocalization(ViewContext v)
        {
            var culture = v.RouteData.Values["culture"]?.ToString();            

            if (!culture.IsEmpty())
            {
                CultureInfo ci = CultureInfo.GetCultureInfo(culture);
                Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = ci;
            }
        }

    }
}