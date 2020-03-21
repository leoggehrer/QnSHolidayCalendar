using System;
using System.ComponentModel.DataAnnotations;

namespace QnSHolidayCalendar.AspMvc.Models.Persistence.App
{
    partial class CalendarEntry
    {
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy, ddd}")]
        public DateTime ViewDate => Date;

        public bool DeleteGroup { get; set; }
    }
}
