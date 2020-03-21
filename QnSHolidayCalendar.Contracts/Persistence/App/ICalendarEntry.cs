using System;
using QnSHolidayCalendar.Contracts.Modules.App;

namespace QnSHolidayCalendar.Contracts.Persistence.App
{
    public interface ICalendarEntry : IIdentifiable, ICopyable<ICalendarEntry>
    {
        DateTime Date { get; set; }
        long HolidayGroup { get; set; }
        string Location { get; set; }
        string Description { get; set; }
        string Note { get; set; }
        HolidayType Type { get; set; }
    }
}
