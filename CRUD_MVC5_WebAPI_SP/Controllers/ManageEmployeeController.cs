using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CRUD_MVC5_WebAPI_SP.Models;

namespace CRUD_MVC5_WebAPI_SP.Controllers
{
    public class ManageEmployeeController : ApiController
    {
        TestDBEntities obj = new TestDBEntities();

        [HttpGet]
        public IEnumerable<ReadAllEmployee_Result> ListAllEmployee(string emp_Name, string country, string managerName)
        {
            return obj.ReadAllEmployee(emp_Name, country, managerName).AsEnumerable();
        }

        [HttpGet]
        public void addNewEmployee(string emp_Name, string email, string country, string managerName)
        {
            obj.ADDNewEmployee(emp_Name, email, country, 1, managerName, "Profile.jpg");
        }

        [HttpGet]
        public void updateEmployee(int? emp_ID, string emp_Name, string email, string country string managerName)
        {
            obj.UpdateEmployee(emp_ID, emp_Name, email, country, managerName);
        }

        [HttpGet]
        public void deleteEmployee(int emp_ID)
        {
            obj.DeleteEmployee(emp_ID);
            obj.SaveChanges();
        }

    }
}
