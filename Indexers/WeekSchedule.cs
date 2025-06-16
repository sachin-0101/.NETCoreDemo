using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    using System;
    using System.Collections.Generic;

    public class WeekSchedule
    {
        private readonly Dictionary<string, string> tasks = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { "Monday", "" },
        { "Tuesday", "" },
        { "Wednesday", "" },
        { "Thursday", "" },
        { "Friday", "" },
        { "Saturday", "" },
        { "Sunday", "" }
    };

        // Indexer
        public string this[string day]
        {
            get
            {
                if (tasks.ContainsKey(day))
                    return tasks[day];
                else
                    throw new ArgumentException("Invalid day: " + day);
            }

            set
            {
                if (tasks.ContainsKey(day))
                    tasks[day] = value;
                else
                    throw new ArgumentException("Invalid day: " + day);
            }
        }
    }

}
