//@QnSCodeCopy
//MdStart
using CommonBase.Extensions;
using QnSHolidayCalendar.Contracts;

namespace QnSHolidayCalendar.Transfer
{
    public partial class TransferObject : Contracts.IIdentifiable
    {
        public virtual int Id { get; set; }
        public virtual byte[] Timestamp { get; set; }
	}
}
//MdEnd
