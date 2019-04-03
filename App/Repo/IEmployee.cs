using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Repo
{
    public interface IEmployee
    {
        List<EmployeeModel> FetchEmployeeList();

        bool AddEmp(EmployeeModel emp);
    }
}
