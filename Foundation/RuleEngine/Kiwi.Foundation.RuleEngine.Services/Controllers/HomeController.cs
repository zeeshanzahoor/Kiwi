using Kiwi.Foundation.Backbone.RuleEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kiwi.Foundation.RuleEngine.Services.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRuleEngineSampleBusiness _ruleEngineSampleBusiness;
        public HomeController(IRuleEngineSampleBusiness RuleEngineSampleBusiness)
        {
            _ruleEngineSampleBusiness = RuleEngineSampleBusiness;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}