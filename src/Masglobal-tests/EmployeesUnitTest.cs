using Masglobal_Application.CQRS.Query;
using Masglobal_Infrastructure.Dto_s;
using Masglobal_Persistance;
using Masglobal_Infrastructure.Interface.Read;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Masglobal_tests
{
    public class UnitTest1
    {

        private readonly Mock<IEmployeeReadRepository> _mockRepo;
        private readonly EmployeeQuery.Handler _handler;

        public UnitTest1()
        {
            _mockRepo = new Mock<IEmployeeReadRepository>();
            _handler = new EmployeeQuery.Handler(_mockRepo.Object);
        }
        [Fact]
        public void EmployeesUnitTest()
        {
            EmployeeQuery.Query query = new EmployeeQuery.Query();
            var employesDto = new List<EmployeeDto>();
             IEnumerable<Employee> employes = new List<Employee>();
            _mockRepo.Setup(m => m.GetALL()).Returns(Task.FromResult(employes));

            var actual = _handler.Handle(query, new System.Threading.CancellationToken()).Result;

            Assert.Equal(employesDto, actual);
        }
    }
}
