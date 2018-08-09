using Microsoft.AspNetCore.Mvc;

namespace WebApplication7.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Index()
        {
            TempData["A"] = "TempData Works!";
            return RedirectToAction("Index2");
        }

        public string Index2()
        {
            return TempData != null ? (TempData["A"]?.ToString() ?? "No TempData Value") : "No TempData";
        }
    }
}
