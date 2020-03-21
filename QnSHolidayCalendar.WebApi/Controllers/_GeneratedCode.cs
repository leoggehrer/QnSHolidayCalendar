namespace QnSHolidayCalendar.WebApi.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using Contract = QnSHolidayCalendar.Contracts.Persistence.App.ICalendarEntry;
	using Model = Transfer.Persistence.App.CalendarEntry;
	[ApiController]
	[Route("Controller")]
	public partial class CalendarEntryController : GenericController<Contract, Model>
	{
		[HttpGet("/api/[controller]/MaxPage")]
		public Task<int> GetMaxPageAsync()
		{
			return GetMaxPageAsync();
		}
		[HttpGet("/api/[controller]/Count")]
		public Task<int> GetCountAsync()
		{
			return CountAsync();
		}
		[HttpGet("/api/[controller]/Get")]
		public Task<IEnumerable<Model>> GetAsync()
		{
			return GetModelsAsync();
		}
		[HttpGet("/api/[controller]/Get/{index}/{size}")]
		public Task<IEnumerable<Model>> GetPageListAsync(int index, int size)
		{
			return GetPageModelsAsync(index, size);
		}
		[HttpGet("/api/[controller]/Get/{index}/{size}")]
		public Task<IEnumerable<Model>> QueryPageListAsync(string predicate, int index, int size)
		{
			return QueryPageModelsAsync(predicate, index, size);
		}
		[HttpGet("/api/[controller]/Get/{id}")]
		public Task<Model> GetAsync(int id)
		{
			return GetModelByIdAsync(id);
		}
		[HttpGet("/api/[controller]/Create")]
		public Task<Model> GetCreateAsync(int id)
		{
			return CreateModelAsync();
		}
		[HttpPost("/api/[controller]")]
		public Task<Model> PostAsync(Model model)
		{
			return InsertModelAsync(model);
		}
		[HttpPut("/api/[controller]")]
		public Task<Model> PutAsync(Model model)
		{
			return UpdateModelAsync(model);
		}
		[HttpDelete("/api/[controller]/{id}")]
		public Task DeleteAsync(int id)
		{
			return DeleteModelAsync(id);
		}
	}
}
namespace QnSHolidayCalendar.WebApi.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using Contract = QnSHolidayCalendar.Contracts.Persistence.Account.IActionLog;
	using Model = Transfer.Persistence.Account.ActionLog;
	[ApiController]
	[Route("Controller")]
	public partial class ActionLogController : GenericController<Contract, Model>
	{
		[HttpGet("/api/[controller]/MaxPage")]
		public Task<int> GetMaxPageAsync()
		{
			return GetMaxPageAsync();
		}
		[HttpGet("/api/[controller]/Count")]
		public Task<int> GetCountAsync()
		{
			return CountAsync();
		}
		[HttpGet("/api/[controller]/Get")]
		public Task<IEnumerable<Model>> GetAsync()
		{
			return GetModelsAsync();
		}
		[HttpGet("/api/[controller]/Get/{index}/{size}")]
		public Task<IEnumerable<Model>> GetPageListAsync(int index, int size)
		{
			return GetPageModelsAsync(index, size);
		}
		[HttpGet("/api/[controller]/Get/{index}/{size}")]
		public Task<IEnumerable<Model>> QueryPageListAsync(string predicate, int index, int size)
		{
			return QueryPageModelsAsync(predicate, index, size);
		}
		[HttpGet("/api/[controller]/Get/{id}")]
		public Task<Model> GetAsync(int id)
		{
			return GetModelByIdAsync(id);
		}
		[HttpGet("/api/[controller]/Create")]
		public Task<Model> GetCreateAsync(int id)
		{
			return CreateModelAsync();
		}
		[HttpPost("/api/[controller]")]
		public Task<Model> PostAsync(Model model)
		{
			return InsertModelAsync(model);
		}
		[HttpPut("/api/[controller]")]
		public Task<Model> PutAsync(Model model)
		{
			return UpdateModelAsync(model);
		}
		[HttpDelete("/api/[controller]/{id}")]
		public Task DeleteAsync(int id)
		{
			return DeleteModelAsync(id);
		}
	}
}
namespace QnSHolidayCalendar.WebApi.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using Contract = QnSHolidayCalendar.Contracts.Persistence.Account.IIdentity;
	using Model = Transfer.Persistence.Account.Identity;
	[ApiController]
	[Route("Controller")]
	public partial class IdentityController : GenericController<Contract, Model>
	{
		[HttpGet("/api/[controller]/MaxPage")]
		public Task<int> GetMaxPageAsync()
		{
			return GetMaxPageAsync();
		}
		[HttpGet("/api/[controller]/Count")]
		public Task<int> GetCountAsync()
		{
			return CountAsync();
		}
		[HttpGet("/api/[controller]/Get")]
		public Task<IEnumerable<Model>> GetAsync()
		{
			return GetModelsAsync();
		}
		[HttpGet("/api/[controller]/Get/{index}/{size}")]
		public Task<IEnumerable<Model>> GetPageListAsync(int index, int size)
		{
			return GetPageModelsAsync(index, size);
		}
		[HttpGet("/api/[controller]/Get/{index}/{size}")]
		public Task<IEnumerable<Model>> QueryPageListAsync(string predicate, int index, int size)
		{
			return QueryPageModelsAsync(predicate, index, size);
		}
		[HttpGet("/api/[controller]/Get/{id}")]
		public Task<Model> GetAsync(int id)
		{
			return GetModelByIdAsync(id);
		}
		[HttpGet("/api/[controller]/Create")]
		public Task<Model> GetCreateAsync(int id)
		{
			return CreateModelAsync();
		}
		[HttpPost("/api/[controller]")]
		public Task<Model> PostAsync(Model model)
		{
			return InsertModelAsync(model);
		}
		[HttpPut("/api/[controller]")]
		public Task<Model> PutAsync(Model model)
		{
			return UpdateModelAsync(model);
		}
		[HttpDelete("/api/[controller]/{id}")]
		public Task DeleteAsync(int id)
		{
			return DeleteModelAsync(id);
		}
	}
}
namespace QnSHolidayCalendar.WebApi.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using Contract = QnSHolidayCalendar.Contracts.Persistence.Account.IIdentityXRole;
	using Model = Transfer.Persistence.Account.IdentityXRole;
	[ApiController]
	[Route("Controller")]
	public partial class IdentityXRoleController : GenericController<Contract, Model>
	{
		[HttpGet("/api/[controller]/MaxPage")]
		public Task<int> GetMaxPageAsync()
		{
			return GetMaxPageAsync();
		}
		[HttpGet("/api/[controller]/Count")]
		public Task<int> GetCountAsync()
		{
			return CountAsync();
		}
		[HttpGet("/api/[controller]/Get")]
		public Task<IEnumerable<Model>> GetAsync()
		{
			return GetModelsAsync();
		}
		[HttpGet("/api/[controller]/Get/{index}/{size}")]
		public Task<IEnumerable<Model>> GetPageListAsync(int index, int size)
		{
			return GetPageModelsAsync(index, size);
		}
		[HttpGet("/api/[controller]/Get/{index}/{size}")]
		public Task<IEnumerable<Model>> QueryPageListAsync(string predicate, int index, int size)
		{
			return QueryPageModelsAsync(predicate, index, size);
		}
		[HttpGet("/api/[controller]/Get/{id}")]
		public Task<Model> GetAsync(int id)
		{
			return GetModelByIdAsync(id);
		}
		[HttpGet("/api/[controller]/Create")]
		public Task<Model> GetCreateAsync(int id)
		{
			return CreateModelAsync();
		}
		[HttpPost("/api/[controller]")]
		public Task<Model> PostAsync(Model model)
		{
			return InsertModelAsync(model);
		}
		[HttpPut("/api/[controller]")]
		public Task<Model> PutAsync(Model model)
		{
			return UpdateModelAsync(model);
		}
		[HttpDelete("/api/[controller]/{id}")]
		public Task DeleteAsync(int id)
		{
			return DeleteModelAsync(id);
		}
	}
}
namespace QnSHolidayCalendar.WebApi.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using Contract = QnSHolidayCalendar.Contracts.Persistence.Account.ILoginSession;
	using Model = Transfer.Persistence.Account.LoginSession;
	[ApiController]
	[Route("Controller")]
	public partial class LoginSessionController : GenericController<Contract, Model>
	{
		[HttpGet("/api/[controller]/MaxPage")]
		public Task<int> GetMaxPageAsync()
		{
			return GetMaxPageAsync();
		}
		[HttpGet("/api/[controller]/Count")]
		public Task<int> GetCountAsync()
		{
			return CountAsync();
		}
		[HttpGet("/api/[controller]/Get")]
		public Task<IEnumerable<Model>> GetAsync()
		{
			return GetModelsAsync();
		}
		[HttpGet("/api/[controller]/Get/{index}/{size}")]
		public Task<IEnumerable<Model>> GetPageListAsync(int index, int size)
		{
			return GetPageModelsAsync(index, size);
		}
		[HttpGet("/api/[controller]/Get/{index}/{size}")]
		public Task<IEnumerable<Model>> QueryPageListAsync(string predicate, int index, int size)
		{
			return QueryPageModelsAsync(predicate, index, size);
		}
		[HttpGet("/api/[controller]/Get/{id}")]
		public Task<Model> GetAsync(int id)
		{
			return GetModelByIdAsync(id);
		}
		[HttpGet("/api/[controller]/Create")]
		public Task<Model> GetCreateAsync(int id)
		{
			return CreateModelAsync();
		}
		[HttpPost("/api/[controller]")]
		public Task<Model> PostAsync(Model model)
		{
			return InsertModelAsync(model);
		}
		[HttpPut("/api/[controller]")]
		public Task<Model> PutAsync(Model model)
		{
			return UpdateModelAsync(model);
		}
		[HttpDelete("/api/[controller]/{id}")]
		public Task DeleteAsync(int id)
		{
			return DeleteModelAsync(id);
		}
	}
}
namespace QnSHolidayCalendar.WebApi.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using Contract = QnSHolidayCalendar.Contracts.Persistence.Account.IRole;
	using Model = Transfer.Persistence.Account.Role;
	[ApiController]
	[Route("Controller")]
	public partial class RoleController : GenericController<Contract, Model>
	{
		[HttpGet("/api/[controller]/MaxPage")]
		public Task<int> GetMaxPageAsync()
		{
			return GetMaxPageAsync();
		}
		[HttpGet("/api/[controller]/Count")]
		public Task<int> GetCountAsync()
		{
			return CountAsync();
		}
		[HttpGet("/api/[controller]/Get")]
		public Task<IEnumerable<Model>> GetAsync()
		{
			return GetModelsAsync();
		}
		[HttpGet("/api/[controller]/Get/{index}/{size}")]
		public Task<IEnumerable<Model>> GetPageListAsync(int index, int size)
		{
			return GetPageModelsAsync(index, size);
		}
		[HttpGet("/api/[controller]/Get/{index}/{size}")]
		public Task<IEnumerable<Model>> QueryPageListAsync(string predicate, int index, int size)
		{
			return QueryPageModelsAsync(predicate, index, size);
		}
		[HttpGet("/api/[controller]/Get/{id}")]
		public Task<Model> GetAsync(int id)
		{
			return GetModelByIdAsync(id);
		}
		[HttpGet("/api/[controller]/Create")]
		public Task<Model> GetCreateAsync(int id)
		{
			return CreateModelAsync();
		}
		[HttpPost("/api/[controller]")]
		public Task<Model> PostAsync(Model model)
		{
			return InsertModelAsync(model);
		}
		[HttpPut("/api/[controller]")]
		public Task<Model> PutAsync(Model model)
		{
			return UpdateModelAsync(model);
		}
		[HttpDelete("/api/[controller]/{id}")]
		public Task DeleteAsync(int id)
		{
			return DeleteModelAsync(id);
		}
	}
}
namespace QnSHolidayCalendar.WebApi.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using Contract = QnSHolidayCalendar.Contracts.Business.App.IHolidayEntry;
	using Model = Transfer.Business.App.HolidayEntry;
	[ApiController]
	[Route("Controller")]
	public partial class HolidayEntryController : GenericController<Contract, Model>
	{
		[HttpGet("/api/[controller]/MaxPage")]
		public Task<int> GetMaxPageAsync()
		{
			return GetMaxPageAsync();
		}
		[HttpGet("/api/[controller]/Count")]
		public Task<int> GetCountAsync()
		{
			return CountAsync();
		}
		[HttpGet("/api/[controller]/Get")]
		public Task<IEnumerable<Model>> GetAsync()
		{
			return GetModelsAsync();
		}
		[HttpGet("/api/[controller]/Get/{index}/{size}")]
		public Task<IEnumerable<Model>> GetPageListAsync(int index, int size)
		{
			return GetPageModelsAsync(index, size);
		}
		[HttpGet("/api/[controller]/Get/{index}/{size}")]
		public Task<IEnumerable<Model>> QueryPageListAsync(string predicate, int index, int size)
		{
			return QueryPageModelsAsync(predicate, index, size);
		}
		[HttpGet("/api/[controller]/Get/{id}")]
		public Task<Model> GetAsync(int id)
		{
			return GetModelByIdAsync(id);
		}
		[HttpGet("/api/[controller]/Create")]
		public Task<Model> GetCreateAsync(int id)
		{
			return CreateModelAsync();
		}
		[HttpPost("/api/[controller]")]
		public Task<Model> PostAsync(Model model)
		{
			return InsertModelAsync(model);
		}
		[HttpPut("/api/[controller]")]
		public Task<Model> PutAsync(Model model)
		{
			return UpdateModelAsync(model);
		}
		[HttpDelete("/api/[controller]/{id}")]
		public Task DeleteAsync(int id)
		{
			return DeleteModelAsync(id);
		}
	}
}
namespace QnSHolidayCalendar.WebApi.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using Contract = QnSHolidayCalendar.Contracts.Business.Account.IAppAccess;
	using Model = Transfer.Business.Account.AppAccess;
	[ApiController]
	[Route("Controller")]
	public partial class AppAccessController : GenericController<Contract, Model>
	{
		[HttpGet("/api/[controller]/MaxPage")]
		public Task<int> GetMaxPageAsync()
		{
			return GetMaxPageAsync();
		}
		[HttpGet("/api/[controller]/Count")]
		public Task<int> GetCountAsync()
		{
			return CountAsync();
		}
		[HttpGet("/api/[controller]/Get")]
		public Task<IEnumerable<Model>> GetAsync()
		{
			return GetModelsAsync();
		}
		[HttpGet("/api/[controller]/Get/{index}/{size}")]
		public Task<IEnumerable<Model>> GetPageListAsync(int index, int size)
		{
			return GetPageModelsAsync(index, size);
		}
		[HttpGet("/api/[controller]/Get/{index}/{size}")]
		public Task<IEnumerable<Model>> QueryPageListAsync(string predicate, int index, int size)
		{
			return QueryPageModelsAsync(predicate, index, size);
		}
		[HttpGet("/api/[controller]/Get/{id}")]
		public Task<Model> GetAsync(int id)
		{
			return GetModelByIdAsync(id);
		}
		[HttpGet("/api/[controller]/Create")]
		public Task<Model> GetCreateAsync(int id)
		{
			return CreateModelAsync();
		}
		[HttpPost("/api/[controller]")]
		public Task<Model> PostAsync(Model model)
		{
			return InsertModelAsync(model);
		}
		[HttpPut("/api/[controller]")]
		public Task<Model> PutAsync(Model model)
		{
			return UpdateModelAsync(model);
		}
		[HttpDelete("/api/[controller]/{id}")]
		public Task DeleteAsync(int id)
		{
			return DeleteModelAsync(id);
		}
	}
}