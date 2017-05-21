using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayToDay
{
    class Timeline
    {
        private List<Day> days = new List<Day>();

        public void SetDays(List<Day> list)
        {
            days = list;
        }
    }
}
