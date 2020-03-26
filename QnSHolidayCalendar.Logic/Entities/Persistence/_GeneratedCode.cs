namespace QnSHolidayCalendar.Logic.Entities.Persistence.App
{
	using System;
	partial class CalendarEntry : QnSHolidayCalendar.Contracts.Persistence.App.ICalendarEntry
	{
		static CalendarEntry()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public CalendarEntry()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public System.DateTime Date
		{
			get
			{
				OnDateReading();
				return _date;
			}
			set
			{
				bool handled = false;
				OnDateChanging(ref handled, ref _date);
				if (handled == false)
				{
					this._date = value;
				}
				OnDateChanged();
			}
		}
		private System.DateTime _date;
		partial void OnDateReading();
		partial void OnDateChanging(ref bool handled, ref System.DateTime _date);
		partial void OnDateChanged();
		public System.Int64 HolidayGroup
		{
			get
			{
				OnHolidayGroupReading();
				return _holidayGroup;
			}
			set
			{
				bool handled = false;
				OnHolidayGroupChanging(ref handled, ref _holidayGroup);
				if (handled == false)
				{
					this._holidayGroup = value;
				}
				OnHolidayGroupChanged();
			}
		}
		private System.Int64 _holidayGroup;
		partial void OnHolidayGroupReading();
		partial void OnHolidayGroupChanging(ref bool handled, ref System.Int64 _holidayGroup);
		partial void OnHolidayGroupChanged();
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
		public System.String Note
		{
			get
			{
				OnNoteReading();
				return _note;
			}
			set
			{
				bool handled = false;
				OnNoteChanging(ref handled, ref _note);
				if (handled == false)
				{
					this._note = value;
				}
				OnNoteChanged();
			}
		}
		private System.String _note;
		partial void OnNoteReading();
		partial void OnNoteChanging(ref bool handled, ref System.String _note);
		partial void OnNoteChanged();
		public QnSHolidayCalendar.Contracts.Modules.App.HolidayType Type
		{
			get
			{
				OnTypeReading();
				return _type;
			}
			set
			{
				bool handled = false;
				OnTypeChanging(ref handled, ref _type);
				if (handled == false)
				{
					this._type = value;
				}
				OnTypeChanged();
			}
		}
		private QnSHolidayCalendar.Contracts.Modules.App.HolidayType _type;
		partial void OnTypeReading();
		partial void OnTypeChanging(ref bool handled, ref QnSHolidayCalendar.Contracts.Modules.App.HolidayType _type);
		partial void OnTypeChanged();
		public void CopyProperties(QnSHolidayCalendar.Contracts.Persistence.App.ICalendarEntry other)
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
				Date = other.Date;
				HolidayGroup = other.HolidayGroup;
				Location = other.Location;
				Description = other.Description;
				Note = other.Note;
				Type = other.Type;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSHolidayCalendar.Contracts.Persistence.App.ICalendarEntry other, ref bool handled);
		partial void AfterCopyProperties(QnSHolidayCalendar.Contracts.Persistence.App.ICalendarEntry other);
		public override bool Equals(object obj)
		{
			if (!(obj is QnSHolidayCalendar.Contracts.Persistence.App.ICalendarEntry instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSHolidayCalendar.Contracts.Persistence.App.ICalendarEntry other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && Date == other.Date && HolidayGroup == other.HolidayGroup && IsEqualsWith(Location, other.Location) && IsEqualsWith(Description, other.Description) && IsEqualsWith(Note, other.Note) && Type == other.Type;
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, Date, HolidayGroup, Location, Description, HashCode.Combine(Note, Type));
		}
	}
}
namespace QnSHolidayCalendar.Logic.Entities.Persistence.App
{
	partial class CalendarEntry : IdentityObject
	{
	}
}
namespace QnSHolidayCalendar.Logic.Entities.Persistence.App
{
	partial class CalendarEntry
	{
	}
}
namespace QnSHolidayCalendar.Logic.Entities.Persistence.Account
{
	using System;
	partial class ActionLog : QnSHolidayCalendar.Contracts.Persistence.Account.IActionLog
	{
		static ActionLog()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public ActionLog()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public System.Int32 IdentityId
		{
			get
			{
				OnIdentityIdReading();
				return _identityId;
			}
			set
			{
				bool handled = false;
				OnIdentityIdChanging(ref handled, ref _identityId);
				if (handled == false)
				{
					this._identityId = value;
				}
				OnIdentityIdChanged();
			}
		}
		private System.Int32 _identityId;
		partial void OnIdentityIdReading();
		partial void OnIdentityIdChanging(ref bool handled, ref System.Int32 _identityId);
		partial void OnIdentityIdChanged();
		public System.DateTime Time
		{
			get
			{
				OnTimeReading();
				return _time;
			}
			set
			{
				bool handled = false;
				OnTimeChanging(ref handled, ref _time);
				if (handled == false)
				{
					this._time = value;
				}
				OnTimeChanged();
			}
		}
		private System.DateTime _time;
		partial void OnTimeReading();
		partial void OnTimeChanging(ref bool handled, ref System.DateTime _time);
		partial void OnTimeChanged();
		public System.String Subject
		{
			get
			{
				OnSubjectReading();
				return _subject;
			}
			set
			{
				bool handled = false;
				OnSubjectChanging(ref handled, ref _subject);
				if (handled == false)
				{
					this._subject = value;
				}
				OnSubjectChanged();
			}
		}
		private System.String _subject;
		partial void OnSubjectReading();
		partial void OnSubjectChanging(ref bool handled, ref System.String _subject);
		partial void OnSubjectChanged();
		public System.String Action
		{
			get
			{
				OnActionReading();
				return _action;
			}
			set
			{
				bool handled = false;
				OnActionChanging(ref handled, ref _action);
				if (handled == false)
				{
					this._action = value;
				}
				OnActionChanged();
			}
		}
		private System.String _action;
		partial void OnActionReading();
		partial void OnActionChanging(ref bool handled, ref System.String _action);
		partial void OnActionChanged();
		public System.String Info
		{
			get
			{
				OnInfoReading();
				return _info;
			}
			set
			{
				bool handled = false;
				OnInfoChanging(ref handled, ref _info);
				if (handled == false)
				{
					this._info = value;
				}
				OnInfoChanged();
			}
		}
		private System.String _info;
		partial void OnInfoReading();
		partial void OnInfoChanging(ref bool handled, ref System.String _info);
		partial void OnInfoChanged();
		public void CopyProperties(QnSHolidayCalendar.Contracts.Persistence.Account.IActionLog other)
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
				IdentityId = other.IdentityId;
				Time = other.Time;
				Subject = other.Subject;
				Action = other.Action;
				Info = other.Info;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSHolidayCalendar.Contracts.Persistence.Account.IActionLog other, ref bool handled);
		partial void AfterCopyProperties(QnSHolidayCalendar.Contracts.Persistence.Account.IActionLog other);
		public override bool Equals(object obj)
		{
			if (!(obj is QnSHolidayCalendar.Contracts.Persistence.Account.IActionLog instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSHolidayCalendar.Contracts.Persistence.Account.IActionLog other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && IdentityId == other.IdentityId && Time == other.Time && IsEqualsWith(Subject, other.Subject) && IsEqualsWith(Action, other.Action) && IsEqualsWith(Info, other.Info);
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, IdentityId, Time, Subject, Action, HashCode.Combine(Info));
		}
	}
}
namespace QnSHolidayCalendar.Logic.Entities.Persistence.Account
{
	partial class ActionLog : IdentityObject
	{
	}
}
namespace QnSHolidayCalendar.Logic.Entities.Persistence.Account
{
	partial class ActionLog
	{
		public QnSHolidayCalendar.Logic.Entities.Persistence.Account.Identity Identity
		{
			get;
			set;
		}
	}
}
namespace QnSHolidayCalendar.Logic.Entities.Persistence.Account
{
	using System;
	partial class Identity : QnSHolidayCalendar.Contracts.Persistence.Account.IIdentity
	{
		static Identity()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public Identity()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public System.String Guid
		{
			get
			{
				OnGuidReading();
				return _guid;
			}
			set
			{
				bool handled = false;
				OnGuidChanging(ref handled, ref _guid);
				if (handled == false)
				{
					this._guid = value;
				}
				OnGuidChanged();
			}
		}
		private System.String _guid;
		partial void OnGuidReading();
		partial void OnGuidChanging(ref bool handled, ref System.String _guid);
		partial void OnGuidChanged();
		public System.String Name
		{
			get
			{
				OnNameReading();
				return _name;
			}
			set
			{
				bool handled = false;
				OnNameChanging(ref handled, ref _name);
				if (handled == false)
				{
					this._name = value;
				}
				OnNameChanged();
			}
		}
		private System.String _name;
		partial void OnNameReading();
		partial void OnNameChanging(ref bool handled, ref System.String _name);
		partial void OnNameChanged();
		public System.String Email
		{
			get
			{
				OnEmailReading();
				return _email;
			}
			set
			{
				bool handled = false;
				OnEmailChanging(ref handled, ref _email);
				if (handled == false)
				{
					this._email = value;
				}
				OnEmailChanged();
			}
		}
		private System.String _email;
		partial void OnEmailReading();
		partial void OnEmailChanging(ref bool handled, ref System.String _email);
		partial void OnEmailChanged();
		public System.String Password
		{
			get
			{
				OnPasswordReading();
				return _password;
			}
			set
			{
				bool handled = false;
				OnPasswordChanging(ref handled, ref _password);
				if (handled == false)
				{
					this._password = value;
				}
				OnPasswordChanged();
			}
		}
		private System.String _password;
		partial void OnPasswordReading();
		partial void OnPasswordChanging(ref bool handled, ref System.String _password);
		partial void OnPasswordChanged();
		public System.Boolean EnableJwtAuth
		{
			get
			{
				OnEnableJwtAuthReading();
				return _enableJwtAuth;
			}
			set
			{
				bool handled = false;
				OnEnableJwtAuthChanging(ref handled, ref _enableJwtAuth);
				if (handled == false)
				{
					this._enableJwtAuth = value;
				}
				OnEnableJwtAuthChanged();
			}
		}
		private System.Boolean _enableJwtAuth;
		partial void OnEnableJwtAuthReading();
		partial void OnEnableJwtAuthChanging(ref bool handled, ref System.Boolean _enableJwtAuth);
		partial void OnEnableJwtAuthChanged();
		public System.Int32 AccessFailedCount
		{
			get
			{
				OnAccessFailedCountReading();
				return _accessFailedCount;
			}
			set
			{
				bool handled = false;
				OnAccessFailedCountChanging(ref handled, ref _accessFailedCount);
				if (handled == false)
				{
					this._accessFailedCount = value;
				}
				OnAccessFailedCountChanged();
			}
		}
		private System.Int32 _accessFailedCount;
		partial void OnAccessFailedCountReading();
		partial void OnAccessFailedCountChanging(ref bool handled, ref System.Int32 _accessFailedCount);
		partial void OnAccessFailedCountChanged();
		public QnSHolidayCalendar.Contracts.State State
		{
			get
			{
				OnStateReading();
				return _state;
			}
			set
			{
				bool handled = false;
				OnStateChanging(ref handled, ref _state);
				if (handled == false)
				{
					this._state = value;
				}
				OnStateChanged();
			}
		}
		private QnSHolidayCalendar.Contracts.State _state;
		partial void OnStateReading();
		partial void OnStateChanging(ref bool handled, ref QnSHolidayCalendar.Contracts.State _state);
		partial void OnStateChanged();
		public void CopyProperties(QnSHolidayCalendar.Contracts.Persistence.Account.IIdentity other)
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
				Guid = other.Guid;
				Name = other.Name;
				Email = other.Email;
				Password = other.Password;
				EnableJwtAuth = other.EnableJwtAuth;
				AccessFailedCount = other.AccessFailedCount;
				State = other.State;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSHolidayCalendar.Contracts.Persistence.Account.IIdentity other, ref bool handled);
		partial void AfterCopyProperties(QnSHolidayCalendar.Contracts.Persistence.Account.IIdentity other);
		public override bool Equals(object obj)
		{
			if (!(obj is QnSHolidayCalendar.Contracts.Persistence.Account.IIdentity instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSHolidayCalendar.Contracts.Persistence.Account.IIdentity other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && IsEqualsWith(Guid, other.Guid) && IsEqualsWith(Name, other.Name) && IsEqualsWith(Email, other.Email) && IsEqualsWith(Password, other.Password) && EnableJwtAuth == other.EnableJwtAuth && AccessFailedCount == other.AccessFailedCount && State == other.State;
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, Guid, Name, Email, Password, HashCode.Combine(EnableJwtAuth, AccessFailedCount, State));
		}
	}
}
namespace QnSHolidayCalendar.Logic.Entities.Persistence.Account
{
	partial class Identity : IdentityObject
	{
	}
}
namespace QnSHolidayCalendar.Logic.Entities.Persistence.Account
{
	partial class Identity
	{
		public System.Collections.Generic.ICollection<QnSHolidayCalendar.Logic.Entities.Persistence.Account.ActionLog> ActionLogs
		{
			get;
			set;
		}
		public System.Collections.Generic.ICollection<QnSHolidayCalendar.Logic.Entities.Persistence.Account.IdentityXRole> IdentityXRoles
		{
			get;
			set;
		}
		public System.Collections.Generic.ICollection<QnSHolidayCalendar.Logic.Entities.Persistence.Account.LoginSession> LoginSessions
		{
			get;
			set;
		}
	}
}
namespace QnSHolidayCalendar.Logic.Entities.Persistence.Account
{
	using System;
	partial class IdentityXRole : QnSHolidayCalendar.Contracts.Persistence.Account.IIdentityXRole
	{
		static IdentityXRole()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public IdentityXRole()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public System.Int32 IdentityId
		{
			get
			{
				OnIdentityIdReading();
				return _identityId;
			}
			set
			{
				bool handled = false;
				OnIdentityIdChanging(ref handled, ref _identityId);
				if (handled == false)
				{
					this._identityId = value;
				}
				OnIdentityIdChanged();
			}
		}
		private System.Int32 _identityId;
		partial void OnIdentityIdReading();
		partial void OnIdentityIdChanging(ref bool handled, ref System.Int32 _identityId);
		partial void OnIdentityIdChanged();
		public System.Int32 RoleId
		{
			get
			{
				OnRoleIdReading();
				return _roleId;
			}
			set
			{
				bool handled = false;
				OnRoleIdChanging(ref handled, ref _roleId);
				if (handled == false)
				{
					this._roleId = value;
				}
				OnRoleIdChanged();
			}
		}
		private System.Int32 _roleId;
		partial void OnRoleIdReading();
		partial void OnRoleIdChanging(ref bool handled, ref System.Int32 _roleId);
		partial void OnRoleIdChanged();
		public void CopyProperties(QnSHolidayCalendar.Contracts.Persistence.Account.IIdentityXRole other)
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
				IdentityId = other.IdentityId;
				RoleId = other.RoleId;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSHolidayCalendar.Contracts.Persistence.Account.IIdentityXRole other, ref bool handled);
		partial void AfterCopyProperties(QnSHolidayCalendar.Contracts.Persistence.Account.IIdentityXRole other);
		public override bool Equals(object obj)
		{
			if (!(obj is QnSHolidayCalendar.Contracts.Persistence.Account.IIdentityXRole instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSHolidayCalendar.Contracts.Persistence.Account.IIdentityXRole other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && IdentityId == other.IdentityId && RoleId == other.RoleId;
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, IdentityId, RoleId);
		}
	}
}
namespace QnSHolidayCalendar.Logic.Entities.Persistence.Account
{
	partial class IdentityXRole : IdentityObject
	{
	}
}
namespace QnSHolidayCalendar.Logic.Entities.Persistence.Account
{
	partial class IdentityXRole
	{
		public QnSHolidayCalendar.Logic.Entities.Persistence.Account.Identity Identity
		{
			get;
			set;
		}
		public QnSHolidayCalendar.Logic.Entities.Persistence.Account.Role Role
		{
			get;
			set;
		}
	}
}
namespace QnSHolidayCalendar.Logic.Entities.Persistence.Account
{
	using System;
	partial class LoginSession : QnSHolidayCalendar.Contracts.Persistence.Account.ILoginSession
	{
		static LoginSession()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public LoginSession()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public System.Int32 IdentityId
		{
			get
			{
				OnIdentityIdReading();
				return _identityId;
			}
			set
			{
				bool handled = false;
				OnIdentityIdChanging(ref handled, ref _identityId);
				if (handled == false)
				{
					this._identityId = value;
				}
				OnIdentityIdChanged();
			}
		}
		private System.Int32 _identityId;
		partial void OnIdentityIdReading();
		partial void OnIdentityIdChanging(ref bool handled, ref System.Int32 _identityId);
		partial void OnIdentityIdChanged();
		public System.Boolean IsRemoteAuth
		{
			get
			{
				OnIsRemoteAuthReading();
				return _isRemoteAuth;
			}
			set
			{
				bool handled = false;
				OnIsRemoteAuthChanging(ref handled, ref _isRemoteAuth);
				if (handled == false)
				{
					this._isRemoteAuth = value;
				}
				OnIsRemoteAuthChanged();
			}
		}
		private System.Boolean _isRemoteAuth;
		partial void OnIsRemoteAuthReading();
		partial void OnIsRemoteAuthChanging(ref bool handled, ref System.Boolean _isRemoteAuth);
		partial void OnIsRemoteAuthChanged();
		public System.String Origin
		{
			get
			{
				OnOriginReading();
				return _origin;
			}
			set
			{
				bool handled = false;
				OnOriginChanging(ref handled, ref _origin);
				if (handled == false)
				{
					this._origin = value;
				}
				OnOriginChanged();
			}
		}
		private System.String _origin;
		partial void OnOriginReading();
		partial void OnOriginChanging(ref bool handled, ref System.String _origin);
		partial void OnOriginChanged();
		public System.String Name
		{
			get
			{
				OnNameReading();
				return _name;
			}
			set
			{
				bool handled = false;
				OnNameChanging(ref handled, ref _name);
				if (handled == false)
				{
					this._name = value;
				}
				OnNameChanged();
			}
		}
		private System.String _name;
		partial void OnNameReading();
		partial void OnNameChanging(ref bool handled, ref System.String _name);
		partial void OnNameChanged();
		public System.String Email
		{
			get
			{
				OnEmailReading();
				return _email;
			}
			set
			{
				bool handled = false;
				OnEmailChanging(ref handled, ref _email);
				if (handled == false)
				{
					this._email = value;
				}
				OnEmailChanged();
			}
		}
		private System.String _email;
		partial void OnEmailReading();
		partial void OnEmailChanging(ref bool handled, ref System.String _email);
		partial void OnEmailChanged();
		public System.String JsonWebToken
		{
			get
			{
				OnJsonWebTokenReading();
				return _jsonWebToken;
			}
			set
			{
				bool handled = false;
				OnJsonWebTokenChanging(ref handled, ref _jsonWebToken);
				if (handled == false)
				{
					this._jsonWebToken = value;
				}
				OnJsonWebTokenChanged();
			}
		}
		private System.String _jsonWebToken;
		partial void OnJsonWebTokenReading();
		partial void OnJsonWebTokenChanging(ref bool handled, ref System.String _jsonWebToken);
		partial void OnJsonWebTokenChanged();
		public System.String SessionToken
		{
			get
			{
				OnSessionTokenReading();
				return _sessionToken;
			}
			set
			{
				bool handled = false;
				OnSessionTokenChanging(ref handled, ref _sessionToken);
				if (handled == false)
				{
					this._sessionToken = value;
				}
				OnSessionTokenChanged();
			}
		}
		private System.String _sessionToken;
		partial void OnSessionTokenReading();
		partial void OnSessionTokenChanging(ref bool handled, ref System.String _sessionToken);
		partial void OnSessionTokenChanged();
		public System.DateTime LoginTime
		{
			get
			{
				OnLoginTimeReading();
				return _loginTime;
			}
			set
			{
				bool handled = false;
				OnLoginTimeChanging(ref handled, ref _loginTime);
				if (handled == false)
				{
					this._loginTime = value;
				}
				OnLoginTimeChanged();
			}
		}
		private System.DateTime _loginTime;
		partial void OnLoginTimeReading();
		partial void OnLoginTimeChanging(ref bool handled, ref System.DateTime _loginTime);
		partial void OnLoginTimeChanged();
		public System.DateTime LastAccess
		{
			get
			{
				OnLastAccessReading();
				return _lastAccess;
			}
			set
			{
				bool handled = false;
				OnLastAccessChanging(ref handled, ref _lastAccess);
				if (handled == false)
				{
					this._lastAccess = value;
				}
				OnLastAccessChanged();
			}
		}
		private System.DateTime _lastAccess;
		partial void OnLastAccessReading();
		partial void OnLastAccessChanging(ref bool handled, ref System.DateTime _lastAccess);
		partial void OnLastAccessChanged();
		public System.DateTime? LogoutTime
		{
			get
			{
				OnLogoutTimeReading();
				return _logoutTime;
			}
			set
			{
				bool handled = false;
				OnLogoutTimeChanging(ref handled, ref _logoutTime);
				if (handled == false)
				{
					this._logoutTime = value;
				}
				OnLogoutTimeChanged();
			}
		}
		private System.DateTime? _logoutTime;
		partial void OnLogoutTimeReading();
		partial void OnLogoutTimeChanging(ref bool handled, ref System.DateTime? _logoutTime);
		partial void OnLogoutTimeChanged();
		public void CopyProperties(QnSHolidayCalendar.Contracts.Persistence.Account.ILoginSession other)
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
				IdentityId = other.IdentityId;
				IsRemoteAuth = other.IsRemoteAuth;
				Origin = other.Origin;
				Name = other.Name;
				Email = other.Email;
				JsonWebToken = other.JsonWebToken;
				SessionToken = other.SessionToken;
				LoginTime = other.LoginTime;
				LastAccess = other.LastAccess;
				LogoutTime = other.LogoutTime;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSHolidayCalendar.Contracts.Persistence.Account.ILoginSession other, ref bool handled);
		partial void AfterCopyProperties(QnSHolidayCalendar.Contracts.Persistence.Account.ILoginSession other);
		public override bool Equals(object obj)
		{
			if (!(obj is QnSHolidayCalendar.Contracts.Persistence.Account.ILoginSession instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSHolidayCalendar.Contracts.Persistence.Account.ILoginSession other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && IdentityId == other.IdentityId && IsRemoteAuth == other.IsRemoteAuth && IsEqualsWith(Origin, other.Origin) && IsEqualsWith(Name, other.Name) && IsEqualsWith(Email, other.Email) && IsEqualsWith(JsonWebToken, other.JsonWebToken) && IsEqualsWith(SessionToken, other.SessionToken) && LoginTime == other.LoginTime && LastAccess == other.LastAccess && LogoutTime == other.LogoutTime;
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, IdentityId, IsRemoteAuth, Origin, Name, HashCode.Combine(Email, JsonWebToken, SessionToken, LoginTime, LastAccess, LogoutTime));
		}
	}
}
namespace QnSHolidayCalendar.Logic.Entities.Persistence.Account
{
	partial class LoginSession : IdentityObject
	{
	}
}
namespace QnSHolidayCalendar.Logic.Entities.Persistence.Account
{
	partial class LoginSession
	{
		public QnSHolidayCalendar.Logic.Entities.Persistence.Account.Identity Identity
		{
			get;
			set;
		}
	}
}
namespace QnSHolidayCalendar.Logic.Entities.Persistence.Account
{
	using System;
	partial class Role : QnSHolidayCalendar.Contracts.Persistence.Account.IRole
	{
		static Role()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public Role()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public System.String Designation
		{
			get
			{
				OnDesignationReading();
				return _designation;
			}
			set
			{
				bool handled = false;
				OnDesignationChanging(ref handled, ref _designation);
				if (handled == false)
				{
					this._designation = value;
				}
				OnDesignationChanged();
			}
		}
		private System.String _designation;
		partial void OnDesignationReading();
		partial void OnDesignationChanging(ref bool handled, ref System.String _designation);
		partial void OnDesignationChanged();
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
		public void CopyProperties(QnSHolidayCalendar.Contracts.Persistence.Account.IRole other)
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
				Designation = other.Designation;
				Description = other.Description;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSHolidayCalendar.Contracts.Persistence.Account.IRole other, ref bool handled);
		partial void AfterCopyProperties(QnSHolidayCalendar.Contracts.Persistence.Account.IRole other);
		public override bool Equals(object obj)
		{
			if (!(obj is QnSHolidayCalendar.Contracts.Persistence.Account.IRole instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSHolidayCalendar.Contracts.Persistence.Account.IRole other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && IsEqualsWith(Designation, other.Designation) && IsEqualsWith(Description, other.Description);
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, Designation, Description);
		}
	}
}
namespace QnSHolidayCalendar.Logic.Entities.Persistence.Account
{
	partial class Role : IdentityObject
	{
	}
}
namespace QnSHolidayCalendar.Logic.Entities.Persistence.Account
{
	partial class Role
	{
		public System.Collections.Generic.ICollection<QnSHolidayCalendar.Logic.Entities.Persistence.Account.IdentityXRole> IdentityXRoles
		{
			get;
			set;
		}
	}
}
