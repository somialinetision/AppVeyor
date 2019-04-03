using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Repo
{
    public class EmployeeService : IEmployee
    {

        private readonly List<EmployeeModel> _Emp;

        public EmployeeService()
        {
            _Emp = new List<EmployeeModel>() {
                new EmployeeModel(){
                    Id=1,
                    Name="John wick",
                    Designation="Office boy"
                },
                new EmployeeModel(){
                    Id=2,
                    Name="Sima Roy",
                    Designation="IT head"
                },
                new EmployeeModel(){
                    Id=3,
                    Name="Raju singh",
                    Designation="Technician"
                },
                new EmployeeModel(){
                    Id=4,
                    Name="John Doe",
                    Designation="Professior"
                },
                new EmployeeModel(){
                    Id=5,
                    Name="Sunny singh",
                    Designation="Faculty"
                },
                new EmployeeModel(){
                    Id=6,
                    Name="Masria pao",
                    Designation="Mixed role"
                },
                new EmployeeModel(){
                    Id=7,
                    Name="Dolly K.",
                    Designation="Tester"
                },
                new EmployeeModel(){
                    Id=8,
                    Name="Baby D.",
                    Designation="Programmer"
                },
                new EmployeeModel(){
                    Id=9,
                    Name="Asha Naure.",
                    Designation="Software"
                },
                  new EmployeeModel(){
                    Id=10,
                    Name="Zaack joshef",
                    Designation="Delivery boy"
                },

            };
        }

        public bool AddEmp(EmployeeModel emp)
        {
            _Emp.Add(emp);
            return true;
        }

        public List<EmployeeModel> FetchEmployeeList()
        {
            return _Emp;            
        }
    }
}
