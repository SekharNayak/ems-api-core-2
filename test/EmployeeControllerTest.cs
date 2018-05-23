using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using ems.models;
using ems.services.contract;
using Microsoft.AspNetCore.Mvc;

namespace ems.controller.test
{
    [TestFixture]
    public class EmployeeControllerTest{

        Mock<IEmployeeService> employeeServiceMock = null;

        [SetUp]
        public void SetUp(){

         employeeServiceMock = new Mock<IEmployeeService>();

        }

        [Test]
        public void GetEmployeesTest(){
            employeeServiceMock.Setup( x => x.GetEmployeesLite()).Returns(
            Task.Run(()=> {return new List<EmployeeLite>();} ));
            EmployeeController empController = new EmployeeController(employeeServiceMock.Object);
            var employees = empController.GetEmployeesLite();
            Assert.NotNull(employees);
            
        }
    }
}