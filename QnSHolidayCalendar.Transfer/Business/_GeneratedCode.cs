namespace QnSHolidayCalendar.Transfer.Business.App
{
	using System.Text.Json.Serialization;
	public partial class HolidayEntry : QnSHolidayCalendar.Contracts.Business.App.IHolidayEntry
	{
		static HolidayEntry()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public HolidayEntry()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public System.DateTime From
		{
			get
			{
				OnFromReading();
				return _from;
			}
			set
			{
				bool handled = false;
				OnFromChanging(ref handled, ref _from);
				if (handled == false)
				{
					this._from = value;
				}
				OnFromChanged();
			}
		}
		private System.DateTime _from;
		partial void OnFromReading();
		partial void OnFromChanging(ref bool handled, ref System.DateTime _from);
		partial void OnFromChanged();
		public System.DateTime? To
		{
			get
			{
				OnToReading();
				return _to;
			}
			set
			{
				bool handled = false;
				OnToChanging(ref handled, ref _to);
				if (handled == false)
				{
					this._to = value;
				}
				OnToChanged();
			}
		}
		private System.DateTime? _to;
		partial void OnToReading();
		partial void OnToChanging(ref bool handled, ref System.DateTime? _to);
		partial void OnToChanged();
		public System.String Location
		{
			get
			{
				OnLocationReading();
				return _location;
			}
			set
			{
				bool handled = false;
				OnLocationChanging(ref handled, ref _location);
				if (handled == false)
				{
					this._location = value;
				}
				OnLocationChanged();
			}
		}
		private System.String _location;
		partial void OnLocationReading();
		partial void OnLocationChanging(ref bool handled, ref System.String _location);
		partial void OnLocationChanged();
		public System.String Description
		{
			get
			{
				OnDescriptionReading();
				return _description;
			}
			set
			{
				bool handled = false;
				OnDescriptionChanging(ref handled, ref _description);
				if (handled == false)
				{
					this._description = value;
				}
				OnDescriptionChanged();
			}
		}
		private System.String _description;
		partial void OnDescriptionReading();
		partial void OnDescriptionChanging(ref bool handled, ref System.String _description);
		partial void OnDescriptionChanged();
		public QnSHolidayCalendar.Contracts.Modules.App.HolidayType HolidayType
		{
			get
			{
				OnHolidayTypeReading();
				return _holidayType;
			}
			set
			{
				bool handled = false;
				OnHolidayTypeChanging(ref handled, ref _holidayType);
				if (handled == false)
				{
					this._holidayType = value;
				}
				OnHolidayTypeChanged();
			}
		}
		private QnSHolidayCalendar.Contracts.Modules.App.HolidayType _holidayType;
		partial void OnHolidayTypeReading();
		partial void OnHolidayTypeChanging(ref bool handled, ref QnSHolidayCalendar.Contracts.Modules.App.HolidayType _holidayType);
		partial void OnHolidayTypeChanged();
		public QnSHolidayCalendar.Contracts.Modules.App.RepeatType RepeatType
		{
			get
			{
				OnRepeatTypeReading();
				return _repeatType;
			}
			set
			{
				bool handled = false;
				OnRepeatTypeChanging(ref handled, ref _repeatType);
				if (handled == false)
				{
					this._repeatType = value;
				}
				OnRepeatTypeChanged();
			}
		}
		private QnSHolidayCalendar.Contracts.Modules.App.RepeatType _repeatType;
		partial void OnRepeatTypeReading();
		partial void OnRepeatTypeChanging(ref bool handled, ref QnSHolidayCalendar.Contracts.Modules.App.RepeatType _repeatType);
		partial void OnRepeatTypeChanged();
		public void CopyProperties(QnSHolidayCalendar.Contracts.Business.App.IHolidayEntry other)
		{
			if (other == null)
			{
				throw new System.ArgumentNullException(nameof(other));
			}
			bool handled = false;
			BeforeCopyProperties(other, ref handled);
			if (handled == false)
			{
				Id = other.Id;
				Timestamp = other.Timestamp;
				From = other.From;
				To = other.To;
				Location = other.Location;
				Description = other.Description;
				HolidayType = other.HolidayType;
				RepeatType = other.RepeatType;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSHolidayCalendar.Contracts.Business.App.IHolidayEntry other, ref bool handled);
		partial void AfterCopyProperties(QnSHolidayCalendar.Contracts.Business.App.IHolidayEntry other);
	}
}
namespace QnSHolidayCalendar.Transfer.Business.App
{
	partial class HolidayEntry : IdentityModel
	{
	}
}
namespace QnSHolidayCalendar.Transfer.Business.Account
{
	using System.Text.Json.Serialization;
	public partial class AppAccess : QnSHolidayCalendar.Contracts.Business.Account.IAppAccess
	{
		static AppAccess()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public AppAccess()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		[JsonIgnore]
		public QnSHolidayCalendar.Contracts.Persistence.Account.IIdentity Identity
		{
			get
			{
				OnIdentityReading();
				return _identity;
			}
			set
			{
				bool handled = false;
				OnIdentityChanging(ref handled, ref _identity);
				if (handled == false)
				{
					this._identity = value;
				}
				OnIdentityChanged();
			}
		}
		private QnSHolidayCalendar.Contracts.Persistence.Account.IIdentity _identity;
		partial void OnIdentityReading();
		partial void OnIdentityChanging(ref bool handled, ref QnSHolidayCalendar.Contracts.Persistence.Account.IIdentity _identity);
		partial void OnIdentityChanged();
		[JsonIgnore]
		public System.Collections.Generic.IEnumerable<QnSHolidayCalendar.Contracts.Persistence.Account.IRole> Roles
		{
			get
			{
				OnRolesReading();
				return _roles;
			}
			set
			{
				bool handled = false;
				OnRolesChanging(ref handled, ref _roles);
				if (handled == false)
				{
					this._roles = value;
				}
				OnRolesChanged();
			}
		}
		private System.Collections.Generic.IEnumerable<QnSHolidayCalendar.Contracts.Persistence.Account.IRole> _roles;
		partial void OnRolesReading();
		partial void OnRolesChanging(ref bool handled, ref System.Collections.Generic.IEnumerable<QnSHolidayCalendar.Contracts.Persistence.Account.IRole> _roles);
		partial void OnRolesChanged();
		public void CopyProperties(QnSHolidayCalendar.Contracts.Business.Account.IAppAccess other)
		{
			if (other == null)
			{
				throw new System.ArgumentNullException(nameof(other));
			}
			bool handled = false;
			BeforeCopyProperties(other, ref handled);
			if (handled == false)
			{
				Id = other.Id;
				Timestamp = other.Timestamp;
				Identity = other.Identity;
				Roles = other.Roles;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSHolidayCalendar.Contracts.Business.Account.IAppAccess other, ref bool handled);
		partial void AfterCopyProperties(QnSHolidayCalendar.Contracts.Business.Account.IAppAccess other);
	}
}
namespace QnSHolidayCalendar.Transfer.Business.Account
{
	partial class AppAccess : IdentityModel
	{
	}
}
