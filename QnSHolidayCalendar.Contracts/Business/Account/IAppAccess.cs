//@QnSCodeCopy
//MdStart
using System.Collections.Generic;
using QnSHolidayCalendar.Contracts.Persistence.Account;

namespace QnSHolidayCalendar.Contracts.Business.Account
{
    public partial interface IAppAccess : IIdentifiable, ICopyable<IAppAccess>
    {
        IIdentity Identity { get; }
        IEnumerable<IRole> Roles { get; }

        void ClearRoles();
        IRole CreateRole();
        void AddRole(IRole role);
        void RemoveRole(IRole role);
    }
}
//MdEnd
