using Microsoft.AspNetCore.Mvc;

namespace ReservatioanWebApplication.Controllers;
[ApiController]
[Route("[Controller]/[Action]")]
public class PatientController : ControllerBase
{
    [HttpPost]
    public string AddPatient(string name, string lastName)
    {
        return "";
    }
    [HttpGet]
    public string GetPatient() 
    {
        return "";
    }
}
