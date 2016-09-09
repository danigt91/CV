using System.Web.Mvc;

namespace CV.Presentation.Engines
{
    public class MyRazorViewEngine : RazorViewEngine
    {
        protected override IView CreatePartialView(ControllerContext controllerContext, string partialPath)
        {
            return new MyRazorView(
                controllerContext,
                partialPath,
                null,
                false,
                base.FileExtensions,
                base.ViewPageActivator
            );
        }
    }
}