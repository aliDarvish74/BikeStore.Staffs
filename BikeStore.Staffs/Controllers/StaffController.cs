using BikeStore.Staffs.Controllers.Models.Requests;
using BikeStore.Staffs.Services.Staffs;
using BikeStore.Staffs.Services.Staffs.Commands;
using Microsoft.AspNetCore.Mvc;

namespace BikeStore.Staffs.Controllers
{
    public class StaffController : Controller
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }
        public IActionResult GetAll()
        {
            return Json(_staffService.GetAllStaffs());
        }
        // localhost:3000/Staff/GetById/5
        public IActionResult GetById([FromRoute] int id)
        {
            return Json(_staffService.GetStaffById(id));
        }
        public IActionResult Create([FromForm] AddStaffRequest request)
        {
            var command = new AddStaffCommand(request);
            _staffService.AddStaff(command);
            return Json(new { Status = true });
        }
    }
}
