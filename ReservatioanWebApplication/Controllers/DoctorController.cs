using Microsoft.AspNetCore.Mvc;

namespace ReservatioanWebApplication.Controllers
{
    [ApiController]
    [Route("[Controller]/[action]")]
    public class DoctorController : ControllerBase
    {
        [HttpPost]
        public string AddDoctor(string firstName, string lastName, string medicalCode)
        {
            return "";
        }

        [HttpGet]
        public string Get()
        {
            return "Doctor 1";
        }
    }
}
