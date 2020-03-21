namespace QnSHolidayCalendar.Logic.Controllers.Persistence.App
{
	sealed partial class CalendarEntryController : GenericController<QnSHolidayCalendar.Contracts.Persistence.App.ICalendarEntry, Entities.Persistence.App.CalendarEntry>
	{
		static CalendarEntryController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public CalendarEntryController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public CalendarEntryController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
namespace QnSHolidayCalendar.Logic.Controllers.Persistence.Account
{
	sealed partial class ActionLogController : GenericController<QnSHolidayCalendar.Contracts.Persistence.Account.IActionLog, Entities.Persistence.Account.ActionLog>
	{
		static ActionLogController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public ActionLogController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public ActionLogController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
namespace QnSHolidayCalendar.Logic.Controllers.Persistence.Account
{
	[Logic.Modules.Security.Authorize("SysAdmin")]
	sealed partial class IdentityController : GenericController<QnSHolidayCalendar.Contracts.Persistence.Account.IIdentity, Entities.Persistence.Account.Identity>
	{
		static IdentityController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public IdentityController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public IdentityController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
namespace QnSHolidayCalendar.Logic.Controllers.Persistence.Account
{
	[Logic.Modules.Security.Authorize("SysAdmin")]
	sealed partial class IdentityXRoleController : GenericController<QnSHolidayCalendar.Contracts.Persistence.Account.IIdentityXRole, Entities.Persistence.Account.IdentityXRole>
	{
		static IdentityXRoleController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public IdentityXRoleController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public IdentityXRoleController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
namespace QnSHolidayCalendar.Logic.Controllers.Persistence.Account
{
	[Logic.Modules.Security.Authorize("SysAdmin")]
	sealed partial class LoginSessionController : GenericController<QnSHolidayCalendar.Contracts.Persistence.Account.ILoginSession, Entities.Persistence.Account.LoginSession>
	{
		static LoginSessionController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public LoginSessionController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public LoginSessionController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
namespace QnSHolidayCalendar.Logic.Controllers.Persistence.Account
{
	[Logic.Modules.Security.Authorize("SysAdmin")]
	sealed partial class RoleController : GenericController<QnSHolidayCalendar.Contracts.Persistence.Account.IRole, Entities.Persistence.Account.Role>
	{
		static RoleController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public RoleController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public RoleController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
