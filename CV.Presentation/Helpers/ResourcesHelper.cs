using Newtonsoft.Json;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Resources;

namespace CV.Presentation.Helpers
{
    public class ResourcesHelper
    {

        public static string ToJSON(ResourceManager resMng)
        {
            var resSet = resMng.GetResourceSet(CultureInfo.CurrentUICulture, true, true)
            .Cast<DictionaryEntry>()
            .ToDictionary(x => x.Key.ToString(),
                    x => x.Value.ToString());

            return JsonConvert.SerializeObject(resSet);
        }

    }
}