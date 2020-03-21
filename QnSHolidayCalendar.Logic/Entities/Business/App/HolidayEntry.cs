using System;
using System.Collections.Generic;
using System.Text;

namespace QnSHolidayCalendar.Logic.Entities.Business.App
{
    partial class HolidayEntry
    {
        partial void OnToReading()
        {
            if (_to.HasValue == false)
                _to = From;
        }
    }
}
