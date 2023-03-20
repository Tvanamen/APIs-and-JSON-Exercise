using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class CallOfDutyAPI
    {
        public static async Task CallOfDuty()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://call-of-duty-modern-warfare.p.rapidapi.com/multiplayer/acidrain020/xbl"),
                Headers =
    {
        { "X-RapidAPI-Key", "f5d179e4c2msh8975a2ce7005ffbp11dbcbjsncd594945ea00" },
        { "X-RapidAPI-Host", "call-of-duty-modern-warfare.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var bestResponse = JObject.Parse(body).GetValue("main").ToString();
                Console.WriteLine(bestResponse);
            }     
        }
    }
}
