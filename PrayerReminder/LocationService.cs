using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PrayerReminder
{
    public class LocationService
    {
        public static async Task<LocationModel> ApproxLocation()
        {
            string url = "http://ip-api.com/json/";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    LocationModel data = await response.Content.ReadAsAsync<LocationModel>();
                    return data;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
