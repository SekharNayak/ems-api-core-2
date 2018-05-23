using System.Collections.Generic;
using System.Threading.Tasks;
using ems.models;
using ems.services.contract;

namespace ems.services.implementation{

    public class EmployeeService : IEmployeeService
    {
        public Task<List<EmployeeLite>> GetEmployeesLite()
        {
            return Task.Run(()=> {
                return new List<EmployeeLite>();
            } );
        }
    }

}