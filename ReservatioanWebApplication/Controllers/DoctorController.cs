using Microsoft.AspNetCore.Mvc;
using ReservatioanWebApplication.Dtos_datatTransferObj_;
using ReservatioanWebApplication.Interfaces;
using ReservatioanWebApplication.Models;

namespace ReservatioanWebApplication.Controllers
{
    [ApiController]
    [Route("[Controller]/[action]")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        public DoctorController(IDoctorService doctorService) {

            _doctorService = doctorService;
        }




        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddDoctorRequest dto)
        {
            Doctor doctor = new Doctor()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                MedicalCode = dto.MedicalCode,
            };


            //add service or add business


            //DoctorService doctorService = new DoctorService();
            int result = _doctorService.Add(doctor);



            return Ok(new AddDoctorResponse()
            {
                Id = result,
            });
        }



        [HttpGet]
        public string Get()
        {
            return "Doctor 1";
        }
    }
}
