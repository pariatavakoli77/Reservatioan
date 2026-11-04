using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using ReservatioanWebApplication.Dtos_datatTransferObj_;

using ReservatioanWebApplication.MyApplication.Interfaces;
using ReservatioanWebApplication.MyDomain.Entities;
using ReservatioanWebApplication.Wrapper;

namespace ReservatioanWebApplication.Controllers
{
    [ApiVersion(1)]
    [ApiController]
    [Route("v{v:apiversion}[Controller]/[action]")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        public DoctorController(IDoctorService doctorService) {

            _doctorService = doctorService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] AddDoctorRequest dto)
        {
            Doctor doctor = new Doctor()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                BirthDate = dto.BirthDate,
                Phone = dto.Phone,
                MedicalCode = dto.MedicalCode,
                Specialty = dto.Specialty,
                LastLicense = dto.LastLicense,
                WorkDays = dto.WorkDays,
                StartWorkTime = dto.StartWorkTime,
                EndWorkTime = dto.EndWorkTime,
                SlotDuration = dto.SlotDuration,
                ConsultationFee = dto.ConsultationFee,

                Address = new Address
                {
                    Province = dto.Address.Province,
                    LocalArea = dto.Address.LocalArea,
                    Street = dto.Address.Street,
                    BuildingNumber = dto.Address.BuildingNumber,
                    PostalCode = dto.Address.PostalCode
                }
            };
            
            int result = _doctorService.Add(doctor);

            Result<int> response = Result.Success(
                result,
                message: "Doctor added successfully"
            );

            return Ok(response);
        }


        [HttpPut]
        //public IActionResult Update(int id, [FromBody] UpdateDoctorRequest dto)
        //{
        //    return Ok();
        //}

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok();

        }

        

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
