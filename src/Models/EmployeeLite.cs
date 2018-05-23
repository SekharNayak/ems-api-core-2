namespace ems.models {

    using System;
    public class EmployeeLite
    {      
   
        public Guid EmployeeId { get; set; }    
        public string FirstName { get; set; }  
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string ManagerName { get; set; }   
        public string DepartmentName { get; set; }

    }

}



