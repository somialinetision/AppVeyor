using System;
using Xunit;

namespace App.Test
{
    public class UnitTest1 :TestBase
    {

        [Fact]
        public void Shoul_Return_EmployeeList()
        {
            //Arrange

            //Act
            var List = EmpService.FetchEmployeeList();

            //Assert
            Assert.Equal(10, List.Count);
                
        }
    }
}
