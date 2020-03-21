using System;
using QnSHolidayCalendar.Contracts.Modules.App;

namespace QnSHolidayCalendar.Contracts.Business.App
{
    public interface IHolidayEntry : IIdentifiable, ICopyable<IHolidayEntry>
    {
        DateTime From { get; set; }
        DateTime? To { get; set; }

        string Location { get; set; }
        string Description { get; set; }
        HolidayType HolidayType { get; set; }
        RepeatType RepeatType { get; set; }
    }
}
