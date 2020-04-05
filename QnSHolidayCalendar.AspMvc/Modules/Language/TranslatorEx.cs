using System;
using System.Reflection;
using CommonBase.Helpers;

namespace QnSHolidayCalendar.AspMvc.Modules.Language
{
    public partial class Translator
    {
        static partial void BeginInit()
        {
            Translations.Clear();

            try
            {
                Adapters.Connector.BaseUri = "https://localhost:5001/api";
                var connector = Adapters.Connector.Create<Contracts.Modules.Language.ITranslation, Models.Modules.Language.Translation>();
                var tranlations = AsyncHelper.RunSync(() => connector.QueryAllAsync($"AppName.Equals(\"{nameof(QnSHolidayCalendar)}\")"));

                foreach (var translation in tranlations)
                {
                    Translations.Add(translation.Key, translation.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in {MethodBase.GetCurrentMethod().Name}: {ex.Message}");
            }
        }
    }
}
