namespace QnSHolidayCalendar.Logic.Controllers.Business.App
{
	sealed partial class HolidayEntryController : BusinessControllerAdapter<QnSHolidayCalendar.Contracts.Business.App.IHolidayEntry, Entities.Business.App.HolidayEntry>
	{
		static HolidayEntryController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public HolidayEntryController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public HolidayEntryController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
namespace QnSHolidayCalendar.Logic.Controllers.Business.Account
{
	[Logic.Modules.Security.Authorize("SysAdmin")]
	sealed partial class AppAccessController : BusinessControllerAdapter<QnSHolidayCalendar.Contracts.Business.Account.IAppAccess, Entities.Business.Account.AppAccess>
	{
		static AppAccessController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public AppAccessController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public AppAccessController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
