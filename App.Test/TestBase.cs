using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;


namespace App.Test
{
    public class TestBase
    {
        public readonly Repo.IEmployee EmpService;


        public readonly IConfiguration _configuration;
        

        public TestBase()
        {
            var builder = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json");
            _configuration = builder.Build();

            var serviceProvider = new ServiceCollection();
            //// Add application services.
            serviceProvider.AddTransient<Repo.IEmployee, Repo.EmployeeService>();
            var sp = serviceProvider.BuildServiceProvider();

            EmpService = sp.GetService<Repo.IEmployee>();         
            
        }
    }
}
