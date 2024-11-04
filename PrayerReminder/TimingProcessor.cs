using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PrayerReminder
{
    public class TimingProcessor
    {
        public static async Task<TimingPrayerModel> LoadTimings(string city = "Chicago", string country = "US", int school = 1)
        {
            string url = $"http://api.aladhan.com/v1/timingsByCity/%7Bdate%7D?city={city}&country={country}&school={school}";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    TimingDataModel data = await response.Content.ReadAsAsync<TimingDataModel>();
                    return data.Data.Timings;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
