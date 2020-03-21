//@QnSCodeCopy
//MdStart
using QnSHolidayCalendar.Contracts;
using QnSHolidayCalendar.Contracts.Client;

namespace QnSHolidayCalendar.AspMvc
{
    public interface IFactoryWrapper
    {
        IAdapterAccess<I> Create<I>() where I : IIdentifiable;
        IAdapterAccess<I> Create<I>(string sessionToken) where I : IIdentifiable;
    }
}
//MdEnd
