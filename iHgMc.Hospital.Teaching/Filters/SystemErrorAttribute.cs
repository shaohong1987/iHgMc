using iHgMc.Utils;
using iHgMc.Utils.Model;
using System.Web.Mvc;

namespace iHgMc.Hospital.Teaching.Filters
{
    public class SystemErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
           LogHelper.LogQueue.Enqueue(new LogMessage
            {
                Name = filterContext.Exception.Source,
                Message = filterContext.Exception.ToString(),
                Type = LogType.Error
            });
            base.OnException(filterContext);
            //处理错误消息，将其跳转到一个页面
            filterContext.HttpContext.Response.Redirect("~/Error.html");
        }
    }
}