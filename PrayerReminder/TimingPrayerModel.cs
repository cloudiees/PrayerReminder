using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrayerReminder
{
    public class TimingPrayerModel
    {
        public DateTime Fajr { get; set; }
        public DateTime Sunrise { get; set; }
        public DateTime Dhuhr { get; set; }
        public DateTime Asr { get; set; }
        public DateTime Maghrib { get; set; }
        public DateTime Isha { get; set; }
    }
}
