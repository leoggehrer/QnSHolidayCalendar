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
        public override Task<int> CountAsync()
        {
            return ExecuteCountAsync();
        }
        public override Task<int> CountByAsync(string predicat)
        {
            return ExecuteCountByAsync(predicat);
        }

        public override Task<IQueryable<ICalendarEntry>> GetPageListAsync(int pageIndex, int pageSize)
        {
            return ExecuteGetPageListAsync(pageIndex, pageSize);
        }
        public override Task<IQueryable<ICalendarEntry>> GetAllAsync()
        {
            return ExecuteGetAllAsync();
        }

        public override Task<IQueryable<ICalendarEntry>> QueryPageListAsync(string predicate, int pageIndex, int pageSize)
        {
            return ExecuteQueryPageListAsync(predicate, pageIndex, pageSize);
        }
        public override Task<IQueryable<ICalendarEntry>> QueryAllAsync(string predicate)
        {
            return ExecuteQueryAllAsync(predicate);
        }
    }
}
