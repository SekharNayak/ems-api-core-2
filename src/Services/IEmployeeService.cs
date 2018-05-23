using System.Threading.Tasks;
using System.Collections.Generic;
using ems.models;

namespace ems.services.contract
{

    public interface IEmployeeService
    {

        Task<List<EmployeeLite>> GetEmployeesLite();

    }

}