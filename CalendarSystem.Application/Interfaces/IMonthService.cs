﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendarSystem.Domain;

namespace CalendarSystem.Application
{
    public  interface IMonthService
    {
        List<Month> GetMonths(string path = "");
        List<Month> Months();

        Month GetMonth(int id);
        List<Appointment> GetAppointments(int? id);

        List<Appointment> GetDetailsOfAppointment(int? id);

    }
}
