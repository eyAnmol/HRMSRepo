using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Reflection.Metadata.Ecma335;


namespace EmployeeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    { 
        [HttpGet(Name = "GetEmployees")]
        public List<Employee> GetEmployees()

            //invoke newly created method in the employee service class

        {
            List<Employee> employees = new List<Employee>(){

             new Employee(1,"Anmol","Ojha",7000000),
             new Employee(2,"Shweta","singh",10000000),
             new Employee(3,"Rikesh","mainali",500000000),
            };
            return employees;
        }
    }
}
