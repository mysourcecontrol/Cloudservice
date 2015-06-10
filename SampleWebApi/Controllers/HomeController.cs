using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace SampleWebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            string instanceId = RoleEnvironment.CurrentRoleInstance.Id;
            int instanceIndex = 0;
            if (int.TryParse(instanceId.Substring(instanceId.LastIndexOf(".") + 1), out instanceIndex)) // On cloud.
            {
                int.TryParse(instanceId.Substring(instanceId.LastIndexOf("_") + 1), out instanceIndex); // On compute emulator.
            }

            ViewBag.InstanceId = instanceId;

            return View();
        }
    }
}
