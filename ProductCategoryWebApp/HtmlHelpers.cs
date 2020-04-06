using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductCategoryWebApp
{
    public static class HtmlHelpers
    {
        public static MvcHtmlString SuccessNotification(this HtmlHelper helper)
        {
            if (helper.ViewBag.Success == null)
                return MvcHtmlString.Empty;


            string success = @"<div class='alert alert-dismissible alert-success'><button type='button' class='close' data-dismiss='alert'>x</button><h4>Success!</h4>";
            success += HttpUtility.UrlDecode(helper.ViewBag.Success);
            success += @"</div>
                                <script type='text/javascript'>
                                $(function () {setTimeout(function(){ $('.alert-success').fadeOut(); },3000)});
                                </script>";

            return MvcHtmlString.Create(success);
        }

        public static MvcHtmlString ErrorNotification(this HtmlHelper helper)
        {
            if (helper.ViewBag.Error == null)
                return MvcHtmlString.Empty;

            string marutiWarning = @"<div class='alert alert-error alert-block'> <a class='close' data-dismiss='alert' href='#'>×</a>
                                        <h4 class='alert-heading'>Error!</h4>";
            marutiWarning += HttpUtility.UrlDecode(helper.ViewBag.Error);
            marutiWarning += "</div>";

            return MvcHtmlString.Create(marutiWarning);
        }
    }
}