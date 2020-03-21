//@QnSCustomizeCode
//MdStart
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CommonBase.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QnSHolidayCalendar.AspMvc.Models;

namespace QnSHolidayCalendar.AspMvc.Controllers
{
    public partial class HomeController : MvcController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IFactoryWrapper factoryWrapper)
            : base(factoryWrapper)
        {
            Constructing();
            _logger = logger;
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();

        private static Models.Persistence.App.CalendarEntry ConvertTo(Contracts.Persistence.App.ICalendarEntry entity)
        {
            entity.CheckArgument(nameof(entity));

            var result = new Models.Persistence.App.CalendarEntry();

            result.CopyProperties(entity);
            return result;
        }
        [ActionName("Index")]
        public async Task<IActionResult> IndexAsync()
        {
            using var ctrl = Factory.Create<Contracts.Persistence.App.ICalendarEntry>();
            var entities = await ctrl.GetAllAsync();

            return View("CalendarEntryIndex", entities.Select(e => ConvertTo(e)).OrderByDescending(e => e.Date));
        }
        [ActionName("Create")]
        public IActionResult Create()
        {
            return RedirectToAction("Create", "HolidayEntry");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
//MdEnd
