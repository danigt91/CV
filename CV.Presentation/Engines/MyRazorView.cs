using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace CV.Presentation.Engines
{
    public class MyRazorView : RazorView
    {
        public MyRazorView(ControllerContext controllerContext, string viewPath, string layoutPath, bool runViewStartPages, IEnumerable<string> viewStartFileExtensions, IViewPageActivator viewPageActivator)
            : base(controllerContext, viewPath, layoutPath, runViewStartPages, viewStartFileExtensions, viewPageActivator)
        {

        }

        protected override void RenderView(ViewContext viewContext, TextWriter writer, object instance)
        {
            Helpers.LocalizationHelper.SetLocalization(viewContext);

            base.RenderView(viewContext, writer, instance);            
        }
    }
}