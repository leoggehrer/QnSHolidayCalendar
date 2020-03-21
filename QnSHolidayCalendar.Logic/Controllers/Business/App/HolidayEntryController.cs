using System;
using System.Threading.Tasks;
using CommonBase.Extensions;
using QnSHolidayCalendar.Contracts.Business.App;
using QnSHolidayCalendar.Logic.Controllers.Persistence.App;

namespace QnSHolidayCalendar.Logic.Controllers.Business.App
{
    partial class HolidayEntryController
    {
        private CalendarEntryController calendarEntryController;

        partial void Constructed()
        {
            calendarEntryController = new CalendarEntryController(this);
        }

        private void AppAccessController_ChangedSessionToken(object sender, EventArgs e)
        {
            calendarEntryController.SessionToken = SessionToken;
        }

        public override Task<IHolidayEntry> CreateAsync()
        {
            return Task.Run<IHolidayEntry>(() => new Entities.Business.App.HolidayEntry() { From = DateTime.Now, To = DateTime.Now });
        }
        public override async Task<IHolidayEntry> InsertAsync(IHolidayEntry entity)
        {
            entity.CheckArgument(nameof(entity));

            DateTime run = entity.From;
            long group = run.Year * 10000 + run.Month + run.Day;

            calendarEntryController.SessionToken = SessionToken;
            while (run <= entity.To)
            {
                var newItem = await calendarEntryController.CreateAsync().ConfigureAwait(false);

                newItem.Date = run;
                newItem.HolidayGroup = group;
                newItem.Location = entity.Location;
                newItem.Description = entity.Description;
                newItem.Type = entity.HolidayType;
                await calendarEntryController.InsertAsync(newItem).ConfigureAwait(false);
                if (entity.RepeatType == Contracts.Modules.App.RepeatType.Weekly)
                {
                    run = run.AddDays(7);
                }
                else if (entity.RepeatType == Contracts.Modules.App.RepeatType.Monthly)
                {
                    run = run.AddMonths(1);
                }
                else if (entity.RepeatType == Contracts.Modules.App.RepeatType.Yearly)
                {
                    run = run.AddYears(1);
                }
                else
                {
                    run = run.AddDays(1);
                }
            }
            return entity;
        }
        public override Task SaveChangesAsync()
        {
            return calendarEntryController.SaveChangesAsync();
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            calendarEntryController.Dispose();
        }
    }
}
