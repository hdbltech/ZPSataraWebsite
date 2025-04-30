using gurukul.Models;
using gurukul.Services;
using System.Web.Mvc;

namespace gurukul.Controllers
{
    public class HomeController : Controller
    {
        private readonly ResultServices resultServices;

        public HomeController()
        {
            resultServices = new ResultServices();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Result()
        {
            ResultModel data = new ResultModel();
            ViewBag.District = null;

            return View(data);
        }

        [HttpPost]
        public ActionResult Result(ResultModel model)


        {
            //var result = resultServices.getresult(model);

            if (ModelState.IsValid)
            {
                var result = resultServices.getresult(model, 1);
                if (result != null && model.rollnumber != 0)
                {
                    return RedirectToAction("ResultTable", model);
                }
                else
                {
                    ModelState.AddModelError("STUDENT NOT AVAILABLE", "");
                }
                return View(model);
            }
            else
                return View(model);
        }

        [HttpGet]
        public ActionResult ResultTable(ResultModel model)
        {
            var result = resultServices.getresult(model);

            return View(result);
        }




        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public JsonResult GetDistrict(string Language)
        {
            var districtList = resultServices.GetDistricts(Language);

            return Json(districtList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetTaluka(string Language, string District)
        {
            var districtList = resultServices.GetTaluka(Language, District);

            return Json(districtList, JsonRequestBehavior.AllowGet);
        }
    }
}