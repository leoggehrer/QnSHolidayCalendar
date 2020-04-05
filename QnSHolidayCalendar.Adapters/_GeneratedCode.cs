namespace QnSHolidayCalendar.Adapters
{
	public static partial class Factory
	{
		public static Contracts.Client.IAdapterAccess<I> Create<I>()
		{
			Contracts.Client.IAdapterAccess<I> result = null;
			if (Adapter == AdapterType.Controller)
			{
				if (typeof(I) == typeof(QnSHolidayCalendar.Contracts.Persistence.App.ICalendarEntry))
				{
					result = new Controller.GenericControllerAdapter<QnSHolidayCalendar.Contracts.Persistence.App.ICalendarEntry>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSHolidayCalendar.Contracts.Persistence.Account.IRole))
				{
					result = new Controller.GenericControllerAdapter<QnSHolidayCalendar.Contracts.Persistence.Account.IRole>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSHolidayCalendar.Contracts.Business.App.IHolidayEntry))
				{
					result = new Controller.GenericControllerAdapter<QnSHolidayCalendar.Contracts.Business.App.IHolidayEntry>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSHolidayCalendar.Contracts.Business.Account.IAppAccess))
				{
					result = new Controller.GenericControllerAdapter<QnSHolidayCalendar.Contracts.Business.Account.IAppAccess>() as Contracts.Client.IAdapterAccess<I>;
				}
			}
			else if (Adapter == AdapterType.Service)
			{
				if (typeof(I) == typeof(QnSHolidayCalendar.Contracts.Persistence.App.ICalendarEntry))
				{
					result = new Service.GenericServiceAdapter<QnSHolidayCalendar.Contracts.Persistence.App.ICalendarEntry, Transfer.Persistence.App.CalendarEntry>(BaseUri, "CalendarEntry") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSHolidayCalendar.Contracts.Persistence.Account.IRole))
				{
					result = new Service.GenericServiceAdapter<QnSHolidayCalendar.Contracts.Persistence.Account.IRole, Transfer.Persistence.Account.Role>(BaseUri, "Role") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSHolidayCalendar.Contracts.Business.App.IHolidayEntry))
				{
					result = new Service.GenericServiceAdapter<QnSHolidayCalendar.Contracts.Business.App.IHolidayEntry, Transfer.Business.App.HolidayEntry>(BaseUri, "HolidayEntry") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSHolidayCalendar.Contracts.Business.Account.IAppAccess))
				{
					result = new Service.GenericServiceAdapter<QnSHolidayCalendar.Contracts.Business.Account.IAppAccess, Transfer.Business.Account.AppAccess>(BaseUri, "AppAccess") as Contracts.Client.IAdapterAccess<I>;
				}
			}
			return result;
		}
		public static Contracts.Client.IAdapterAccess<I> Create<I>(string sessionToken)
		{
			Contracts.Client.IAdapterAccess<I> result = null;
			if (Adapter == AdapterType.Controller)
			{
				if (typeof(I) == typeof(QnSHolidayCalendar.Contracts.Persistence.App.ICalendarEntry))
				{
					result = new Controller.GenericControllerAdapter<QnSHolidayCalendar.Contracts.Persistence.App.ICalendarEntry>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSHolidayCalendar.Contracts.Persistence.Account.IRole))
				{
					result = new Controller.GenericControllerAdapter<QnSHolidayCalendar.Contracts.Persistence.Account.IRole>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSHolidayCalendar.Contracts.Business.App.IHolidayEntry))
				{
					result = new Controller.GenericControllerAdapter<QnSHolidayCalendar.Contracts.Business.App.IHolidayEntry>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSHolidayCalendar.Contracts.Business.Account.IAppAccess))
				{
					result = new Controller.GenericControllerAdapter<QnSHolidayCalendar.Contracts.Business.Account.IAppAccess>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
				}
			}
			else if (Adapter == AdapterType.Service)
			{
				if (typeof(I) == typeof(QnSHolidayCalendar.Contracts.Persistence.App.ICalendarEntry))
				{
					result = new Service.GenericServiceAdapter<QnSHolidayCalendar.Contracts.Persistence.App.ICalendarEntry, Transfer.Persistence.App.CalendarEntry>(sessionToken, BaseUri, "CalendarEntry") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSHolidayCalendar.Contracts.Persistence.Account.IRole))
				{
					result = new Service.GenericServiceAdapter<QnSHolidayCalendar.Contracts.Persistence.Account.IRole, Transfer.Persistence.Account.Role>(sessionToken, BaseUri, "Role") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSHolidayCalendar.Contracts.Business.App.IHolidayEntry))
				{
					result = new Service.GenericServiceAdapter<QnSHolidayCalendar.Contracts.Business.App.IHolidayEntry, Transfer.Business.App.HolidayEntry>(sessionToken, BaseUri, "HolidayEntry") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSHolidayCalendar.Contracts.Business.Account.IAppAccess))
				{
					result = new Service.GenericServiceAdapter<QnSHolidayCalendar.Contracts.Business.Account.IAppAccess, Transfer.Business.Account.AppAccess>(sessionToken, BaseUri, "AppAccess") as Contracts.Client.IAdapterAccess<I>;
				}
			}
			return result;
		}
	}
}
