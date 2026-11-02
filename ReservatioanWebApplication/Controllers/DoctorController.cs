using Microsoft.AspNetCore.Mvc;
using ReservatioanWebApplication.Dtos_datatTransferObj_;
using ReservatioanWebApplication.Interfaces;
using ReservatioanWebApplication.Models;
using ReservatioanWebApplication.Services;
using System.Security.Cryptography.X509Certificates;

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
                FirstName = dto.firstName,
                LastName = dto.lastName,
                MedicalCode = dto.medicalCode,
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
