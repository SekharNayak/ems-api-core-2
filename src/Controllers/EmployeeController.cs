using System.Collections.Generic;
using System.Threading.Tasks;
using ems.models;
using ems.services.contract;
using Microsoft.AspNetCore.Mvc;

namespace ems.controller{

    [Route("api/employees")]
    public class EmployeeController :Controller
    {


        private IEmployeeService _empService ;
        public EmployeeController(IEmployeeService empService)
        {
            _empService = empService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetEmployeesLite() =>   Ok(await _empService.GetEmployeesLite());

    }
}