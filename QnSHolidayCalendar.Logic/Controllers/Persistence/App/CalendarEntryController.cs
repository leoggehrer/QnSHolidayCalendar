using QnSHolidayCalendar.Contracts.Persistence.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnSHolidayCalendar.Logic.Controllers.Persistence.App
{
    partial class CalendarEntryController
    {
        public override Task<IQueryable<ICalendarEntry>> GetAllAsync()
        {
            return ExecuteGetAllAsync();
        }
    }
}
