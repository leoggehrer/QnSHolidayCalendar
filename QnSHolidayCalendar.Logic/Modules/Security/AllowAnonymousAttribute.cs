//@QnSCodeCopy
//MdStart
using System;

namespace QnSHolidayCalendar.Logic.Modules.Security
{
    [AttributeUsage(AttributeTargets.Method)]
    internal partial class AllowAnonymousAttribute : AuthorizeAttribute
    {
        public AllowAnonymousAttribute()
            : base(false)
        {

        }
    }
}
//MdEnd
