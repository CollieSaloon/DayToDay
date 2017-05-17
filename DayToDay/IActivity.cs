using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace DayToDay
{
    interface IActivity
    {
        Color color { get; }
        int duration { get; set; }
        string description { get; set; }
    }
}
