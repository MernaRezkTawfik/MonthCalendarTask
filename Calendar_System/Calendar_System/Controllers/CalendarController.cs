using CalendarSystem.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CalendarSystem.Domain;

namespace Calendar_System.Controllers
{
    public class CalendarController : Controller
    {
        #region Fields

        private IMonthService _MonthService = null;
        #endregion
        #region Constructors

        public CalendarController(IMonthService monthService)
        {

            _MonthService = monthService;


        }
        #endregion
        // GET: Calendar
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult GetMonth()
        {
            var Months = _MonthService.Months();
            return View(Months);
        }

        public ActionResult GetAppointment(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var appointments = _MonthService.GetAppointments(id);
            return View(appointments);
        }
        public ActionResult GetDetailsOfAppointment(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var appointments = _MonthService.GetDetailsOfAppointment(id);
            return View(appointments);
        }
    }
}