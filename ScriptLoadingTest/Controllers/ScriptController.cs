using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScriptLoadingTest.Controllers
{
    public class ScriptController : Controller
    {
        public ActionResult File([Bind(Prefix = "id")] int fileNum)
        {
            System.Threading.Thread.Sleep(fileNum * 1000);

            return Content("console.log('File" + fileNum + " loaded')", "text/javascript");
        }
    }
}