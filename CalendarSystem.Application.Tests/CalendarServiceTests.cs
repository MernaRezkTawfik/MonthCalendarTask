using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalendarSystem.Application;
using CalendarSystem.Application.Services;
using CalendarSystem.Domain;

namespace CalendarSystem.Application.Tests
{
    [TestFixture()]
    public  class CalendarServiceTests
    {
        [Test()]
        public void GetAppointments()
        {
            //Arrange
            var jsonService = new JsonService();
            MyContext mycontext=new MyContext();

            var MonthService = new MonthService(jsonService,mycontext);

            //Act
            var Appointments = MonthService.GetAppointments(1);
            //Assert
            Assert.IsTrue(Appointments.Count > 0);
        }
    }
}
