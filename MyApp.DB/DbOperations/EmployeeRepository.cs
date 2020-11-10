using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Model;

namespace MyApp.DB.DbOperations
{
    public class EmployeeRepository
    {

        public int AddEmployee(EmployeeModel model)
        {
            using (var context = new EmployeeDBEntities())
            {
                Employee employee = new Employee()
                { 
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    AddressId = model.AddressId+1,
                    Email = model.Email,
                    Code = model.Code,
                };
                //var AddressId = context.Address.OrderByDescending(u=>u.Id).fir ;

                int maxId = (from c in context.Address select c.Id).Max();
                if (model.Address != null)
                {
                    employee.Address = new Address()
                    {
                        Id= maxId+1,
                        Details = model.Address.Details,
                        State = model.Address.State,
                        Country = model.Address.Country
                    };
                }
                context.Employee.Add(employee);
                context.SaveChanges();
                return employee.Id;
            }
        }



        public List<EmployeeModel> GetAllEmployees()
        {
            using (var context = new EmployeeDBEntities())
            {
                var result = context.Employee.Select(x => new EmployeeModel()
                {
                    //AddressId = x.AddressId,
                    //Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Code = x.Code,
                    Email = x.Email,
                    Address= new AddressModel()
                    {
                        Id=x.Address.Id,
                        Details=x.Address.Details,
                        State=x.Address.State,
                        Country=x.Address.Country
                    }
                }).ToList();
                return result;
            }

        
        }
    }
}
