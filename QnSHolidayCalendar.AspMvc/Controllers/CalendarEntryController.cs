using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model = QnSHolidayCalendar.AspMvc.Models.Persistence.App.CalendarEntry;
using Contract = QnSHolidayCalendar.Contracts.Persistence.App.ICalendarEntry;

namespace QnSHolidayCalendar.AspMvc.Controllers
{
    public class CalendarEntryController : AccessController
    {
        public CalendarEntryController(IFactoryWrapper factoryWrapper) : base(factoryWrapper)
        {
        }

        [ActionName("Edit")]
        public async Task<IActionResult> EditAsync(int id)
        {
            using var ctrl = Factory.Create<Contract>(SessionWrapper.SessionToken);
            var entity = await ctrl.GetByIdAsync(id);

            return View(ConvertTo<Model, Contract>(entity));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Edit")]
        public async Task<IActionResult> EditAsync(int id, Model model)
        {
            if (ModelState.IsValid == false)
            {
                model.ActionError = GetModelStateError();
                return View(model);
            }
            try
            {
                using var ctrl = Factory.Create<Contract>(SessionWrapper.SessionToken);

                await ctrl.UpdateAsync(model);
            }
            catch (Exception ex)
            {
                model.ActionError = GetExceptionError(ex);
                return View(model);
            }
            return RedirectToAction("Index", "Home");
        }
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteAsync(int id, string error = null)
        {
            using var ctrl = Factory.Create<Contract>(SessionWrapper.SessionToken);
            var entity = await ctrl.GetByIdAsync(id);
            var model = ConvertTo<Model, Contract>(entity);

            model.ActionError = error;
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteAsync(int id, Model model)
        {
            if (ModelState.IsValid == false)
            {
                return RedirectToAction("Delete", new { id, error = GetModelStateError() });
            }
            try
            {
                using var ctrl = Factory.Create<Contract>(SessionWrapper.SessionToken);

                if (model.DeleteGroup)
                {
                    var qry = await ctrl.QueryAllAsync($"{nameof(model.HolidayGroup)}={model.HolidayGroup}");

                    foreach (var item in qry)
                    {
                        await ctrl.DeleteAsync(item.Id);
                    }
                }
                else
                {
                    await ctrl.DeleteAsync(id);
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Delete", new { id, error = GetExceptionError(ex) });
            }
            return RedirectToAction("Index", "Home");
        }
    }
}