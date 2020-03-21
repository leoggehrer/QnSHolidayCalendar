using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Contract = QnSHolidayCalendar.Contracts.Business.App.IHolidayEntry;
using Model = QnSHolidayCalendar.AspMvc.Models.Business.App.HolidayEntry;

namespace QnSHolidayCalendar.AspMvc.Controllers
{
    public class HolidayEntryController : AccessController
    {
        public HolidayEntryController(IFactoryWrapper factoryWrapper)
            : base(factoryWrapper)
        {
        }

        [ActionName("Index")]
        public async Task<IActionResult> IndexAsync()
        {
            using var ctrl = Factory.Create<Contracts.Persistence.App.ICalendarEntry>(SessionWrapper.SessionToken);
            var entities = await ctrl.GetAllAsync();
            var models = entities.Select(e => ConvertTo<Models.Persistence.App.CalendarEntry, Contracts.Persistence.App.ICalendarEntry>(e))
                                 .OrderBy(e => e.Date);

            return View("CalendarEntryIndex", models);
        }
        [ActionName("Create")]
        public async Task<IActionResult> CreateAsync(string error = null)
        {
            using var ctrl = Factory.Create<Contract>(SessionWrapper.SessionToken);
            var entity = await ctrl.CreateAsync();
            var model = ConvertTo<Model, Contract>(entity);

            model.ActionError = error;
            return View("Create", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Create")]
        public async Task<IActionResult> CreateAsync(Model model)
        {
            using var ctrl = Factory.Create<Contract>(SessionWrapper.SessionToken);

            if (ModelState.IsValid == false)
            {
                model.ActionError = GetModelStateError();
                return View(model);
            }
            try
            {
                var entity = await ctrl.CreateAsync();

                entity.CopyProperties(model);
                await ctrl.InsertAsync(model);
            }
            catch (Exception ex)
            {
                model.ActionError = GetExceptionError(ex);
                return View(model);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}