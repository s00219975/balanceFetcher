using Google.Cloud.Functions.Framework;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HelloHttp;

public class Program
{
    private static async Task Main()
    {
        // var httpClient = new HttpClient();
        //
        // var request = new HttpRequestMessage(HttpMethod.Post, "https://app.prepaypower.ie:2019/api/Login");
        //
        // request.Headers.Add("Authorization", "Basic dGFwX3JlbW90ZTpydVlHejVybFNSSDRPRGR4Q0tXMzZvaHd4N0Vz");
        // request.Headers.Add("User-Agent", "okhttp/4.12.0");
        // request.Headers.Add("X-Http-originid", "3");
        // request.Headers.Add("X-Http-signature", "3:c845f36999bd583ce7a2eb55f41705c531297f98");
        // request.Headers.Add("Accept-Encoding", "gzip");
        //
        // string jsonPayload = "{\"email\":\"F6ew+mN7ag3H3TO9vCqOCHYPmiG1g8Q3kThhTIij53060VqCyoyZDO3+b9hjTzMYa1XxLwXpQSMjP6uEVcr7u/xbGFdkcM9TbLLCEnGMvp8Df5CMPSuG4fZn2N1jXqYCpQfo1TZD3sIf4gv5yltJr1vKXuvOOlxam/N2R/h4i4RDETkl6cLBYg9xRqAnyyGCnRZsus4NXLNMQndpeaWOX0nU64Bb/eB9a+oDQwQmmJF+qOeMcm/0LUJuWkXF0+g+I+gyYtgiBG+Ba3twtfg+djt/0XXW4onrdt98MstOotzDstXVrbVAduexzxXYnSNycZF+iMQRXfY5I2TX4IHvXg==\",\"isPersistent\":true,\"password\":\"KK3sIg7Kf+zcnxVGIDIV4V+DhlMz+TmKMwkTUI+Vc/OFQqUg/a8ZDSY0myvJR7r/Y+IvCB0TQfgMdomks8XA5Po4STyYz4DJFBi63sYZ27W5PUcAojwFCrg+cXk02MCcG/S5nqSJEaUql1xZCt7dO+UBkIit8DDCELInxpVDJGAQ1UG/HhcQMVju3qjbruxZo0ZlP9/Zrea0HgRGdpZIec5MWFnod29eNr6+/FmZwwfplJs6NEuqfOqM73h/LP6z9YMWtgc6Yr/8DAIHRs4Kpw+hzCYpFsX/J8GkwomyBybITBL56KTA2/wzkE5vPDfstHpsvx1KQcfyiqIy2XXfkQ==\"}";
        //
        // request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
        //
        // Console.WriteLine("Sending request...");
        //
        // var response = await httpClient.SendAsync(request);
        // string responseBody = await response.Content.ReadAsStringAsync();
        //
        // if (!response.IsSuccessStatusCode)
        // {
        //     Console.WriteLine($"Error: {response.StatusCode}");
        //     Console.WriteLine(responseBody);
        //     return;
        // }
        //
        // try
        // {
        //     JsonDocument doc = JsonDocument.Parse(responseBody);
        //     var root = doc.RootElement;
        //
        //     if (root.TryGetProperty("appRegisteredUser", out JsonElement userElement))
        //     {
        //         if (userElement.TryGetProperty("balance", out JsonElement balanceElement))
        //         {
        //             double balance = balanceElement.GetDouble();
        //             double euros = balance / 100.0;
        //             //string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        //             Console.WriteLine($"Balance: {euros:F2}");
        //         }
        //         else
        //         {
        //             Console.WriteLine("Could not find balance inside appRegisteredUser.");
        //         }
        //     }
        //     else
        //     {
        //         Console.WriteLine("Could not find appRegisteredUser in response.");
        //     }
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine($"Error reading JSON: {ex.Message}");
        // }
        
        string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Console.WriteLine($"Time: {time}");
        Console.WriteLine($"Balance: 45.06");
    }
}
