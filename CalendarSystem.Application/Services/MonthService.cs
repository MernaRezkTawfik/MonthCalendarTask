using CalendarSystem.Application.Interfaces;
using CalendarSystem.Application.Utilities;
using CalendarSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CalendarSystem.Application
{
  public  class MonthService:IMonthService
    {
        
        #region Fields
        private readonly IJsonService _JsonService = null;

        private readonly MyContext myContext = null;
        #endregion
        #region Constructors
        public MonthService(IJsonService jsonService,MyContext context)
        {
            _JsonService = jsonService;
            myContext = context;
        }
        #endregion

      
        #region Functions
        public List<Month> GetMonths(string path = "")
        {
            var MonthJsonPath = path;
            if (string.IsNullOrEmpty(MonthJsonPath))
                MonthJsonPath = HttpContext.Current.Server.MapPath(AppSettingsUtil.MonthJsonPath);
            var Months = _JsonService.ReadJsonFile<List<Month>>(MonthJsonPath);
            return Months;
        }
        public List<Month> Months()
        {
            return myContext.months.ToList();
        }
        public Month GetMonth(int id)
        {
            return myContext.months.Find(id);
        }
        public List<Appointment> GetAppointments(int? id)
        {
            //Month month = getmonth(id);
            return myContext.appointments.Where(m => m.MonthID == id).ToList();
        }

        public List<Appointment> GetDetailsOfAppointment(int? id)
        {
            return myContext.appointments.Where(m => m.Id == id).ToList();
        }
        #endregion
    }
}
