using Microsoft.AspNetCore.Mvc;

namespace HelloDotnet.Api
{
    public class DemoController : Controller
    {
        [HttpGetAttribute("api/demo")]
        public JsonResult Get()
        {
            return Json(new {name = "Shawn"});
        }
    }
}