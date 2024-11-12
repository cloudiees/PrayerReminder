namespace PrayerReminder
{
    public class PrayerData<T1, T2, T3>
    {
        public T1 checkBox { set; get; }
        public T2 label { set; get; }
        public T3 timing { set; get; }
        public PrayerData() { }
        public PrayerData(T1 checkBox, T2 label, T3 timing)
        {
            this.checkBox = checkBox;
            this.label = label;
            this.timing = timing;
        }

    }
}
