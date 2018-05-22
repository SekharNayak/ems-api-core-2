

namespace ems.data.entities
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Employee
    {
        public Employee() => Addresses = new List<Address>();

        [Required]
        public Guid EmployeeId { get; set; }

        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        public string LastName { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        public ICollection<Address> Addresses { get; set; }

        public int ManagerId { get; set; }

        public Employee Manager { get; set; }

        [Required]
        public int DepartmentId { get; set; }


        public Department Department { get; set; }
    }

}