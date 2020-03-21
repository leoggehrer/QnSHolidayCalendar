//@QnSCodeCopy
//MdStart
using System;
using System.Threading.Tasks;
using QnSHolidayCalendar.Logic.Entities.Persistence.Account;

namespace QnSHolidayCalendar.Logic.Controllers.Persistence.Account
{
    partial class LoginSessionController
    {
        protected override Task BeforeInsertingAsync(LoginSession entity)
        {
            entity.LoginTime = DateTime.Now;
            entity.LastAccess = entity.LoginTime;
            entity.SessionToken = Guid.NewGuid().ToString();
            return base.BeforeInsertingAsync(entity);
        }
    }
}
//MdEnd
