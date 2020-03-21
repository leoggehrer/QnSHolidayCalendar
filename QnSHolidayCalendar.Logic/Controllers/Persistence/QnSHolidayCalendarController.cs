//MdStart
using QnSHolidayCalendar.Logic.DataContext;

namespace QnSHolidayCalendar.Logic.Controllers.Persistence
{
    internal abstract partial class QnSHolidayCalendarController<I, E> : GenericController<I, E>
       where I : Contracts.IIdentifiable
       where E : Entities.IdentityObject, I, Contracts.ICopyable<I>, new()
    {
        internal IQnSHolidayCalendarContext QnSHolidayCalendarContext => (IQnSHolidayCalendarContext)Context;

        protected QnSHolidayCalendarController(IContext context)
            : base(context)
        {
        }
        protected QnSHolidayCalendarController(ControllerObject controller)
            : base(controller)
        {
        }
    }
}
//MdEnd
