//@QnSCodeCopy
//MdStart
using System.Threading.Tasks;
using CommonBase.Extensions;
using QnSHolidayCalendar.Logic.Exceptions;
using QnSHolidayCalendar.Logic.Entities.Persistence.Account;
using QnSHolidayCalendar.Logic.Modules.Account;

namespace QnSHolidayCalendar.Logic.Controllers.Persistence.Account
{
    partial class IdentityController
    {
        private void CheckInsertEntity(Identity entity)
        {
            if (AccountManager.CheckMailAddressSyntax(entity.Email) == false)
            {
                throw new LogicException(ErrorType.InvalidEmail);
            }
            if (AccountManager.CheckPasswordSyntax(entity.Password) == false)
            {
                throw new LogicException(ErrorType.InvalidPassword);
            }
        }
        private void CheckUpdateEntity(Identity entity)
        {
            if (AccountManager.CheckMailAddressSyntax(entity.Email) == false)
            {
                throw new LogicException(ErrorType.InvalidEmail);
            }
            if (entity.Password.HasContent())
            {
                if (AccountManager.CheckPasswordSyntax(entity.Password) == false)
                {
                    throw new LogicException(ErrorType.InvalidPassword);
                }
            }
        }

        protected override Task BeforeInsertingAsync(Identity entity)
        {
            CheckInsertEntity(entity);
            entity.Guid = System.Guid.NewGuid().ToString();
            entity.State = Contracts.State.Active;
            entity.PasswordHash = AccountManager.CalculateHash(entity.Password);

            return base.BeforeInsertingAsync(entity);
        }

        protected override Task BeforeUpdatingAsync(Identity entity)
        {
            CheckUpdateEntity(entity);
            if (entity.Password.HasContent())
            {
                entity.PasswordHash = AccountManager.CalculateHash(entity.Password);
            }
            return base.BeforeUpdatingAsync(entity);
        }
    }
}
//MdEnd
