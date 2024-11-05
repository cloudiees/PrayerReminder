namespace PrayerReminder
{
    public class PrayerData<T1, T2, T3, T4>
    {
        public T1 checkBox { set; get; }
        public T2 label { set; get; }
        public T3 timing { set; get; }
        public T4 panel { set; get; }
        public PrayerData() { }
        public PrayerData(T1 checkBox, T2 label, T3 timing, T4 panel)
        {
            this.checkBox = checkBox;
            this.label = label;
            this.timing = timing;
            this.panel = panel;
        }

    }
}
