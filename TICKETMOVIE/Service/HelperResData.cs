using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;


namespace TICKETMOVIE
 
{
    class MovieResData : Client
    {
        

        private static readonly HttpClient client = new HttpClient();
        

       public MovieResData()
        {
          
        }

        public async Task<ResData> GetResData(String urlapi)
        {
             urlapi = urlmovie + urlapi;
            try
            {
                
                var response = await client.GetAsync(urlapi);
                response.EnsureSuccessStatusCode(); // Đảm bảo kết quả trả 
                var jsonString = await response.Content.ReadAsStringAsync();
                var resdata =  JsonConvert.DeserializeObject<ResData>(jsonString);

                return resdata;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        // requestwithbody
        public async Task<ResData> GetResDataWithBody(string url, StringContent content)
        {
            url = urlmovie + url; // Kết hợp URL cơ sở với URL cụ thể
            try
            {
                var response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode(); // Đảm bảo kết quả trả về là thành công

                var jsonString = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(jsonString))
                {
                    var resdata = JsonConvert.DeserializeObject<ResData>(jsonString);
                    return resdata;
                }
                else
                {
                    // Xử lý khi jsonString rỗng hoặc null
                    Console.WriteLine("Empty response from server.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null; // Xử lý ngoại lệ và trả về null
            }
        }


        public async Task<ResData> DeleteResData(string url)
        {
            url = urlmovie + url;

            try
            {
                var response = await client.DeleteAsync(url);
                response.EnsureSuccessStatusCode(); // Đảm bảo kết quả trả về thành công

                var jsonString = await response.Content.ReadAsStringAsync();
                var resdata = JsonConvert.DeserializeObject<ResData>(jsonString);

                return resdata;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HttpRequestException: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return null;
            }
        }

        public async Task<ResData> GetResDataUser(String urlapi)
        {
            urlapi = urluser + urlapi;
            try
            {

                var response = await client.GetAsync(urlapi);
                response.EnsureSuccessStatusCode(); // Đảm bảo kết quả trả 
                var jsonString = await response.Content.ReadAsStringAsync();
                var resdata = JsonConvert.DeserializeObject<ResData>(jsonString);

                return resdata;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public async Task<ResData> GetResDataTicket(String urlapi)
        {
            urlapi = urlticket + urlapi;
            try
            {

                var response = await client.GetAsync(urlapi);
                response.EnsureSuccessStatusCode(); // Đảm bảo kết quả trả 
                var jsonString = await response.Content.ReadAsStringAsync();
                var resdata = JsonConvert.DeserializeObject<ResData>(jsonString);

                return resdata;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        public async Task<ResData> GetResDataWithBodyUser(string url, StringContent content)
        {
            url = urluser + url; // Kết hợp URL cơ sở với URL cụ thể
            try
            {
                var response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode(); // Đảm bảo kết quả trả về là thành công

                var jsonString = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(jsonString))
                {
                    var resdata = JsonConvert.DeserializeObject<ResData>(jsonString);
                    return resdata;
                }
                else
                {
                   
                    Console.WriteLine("Empty response from server.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null; // Xử lý ngoại lệ và trả về null
            }
        }
        public async Task<ResData> GetResDataWithBodyTicket(string url, StringContent content)
        {
            url = urlticket + url; // Kết hợp URL cơ sở với URL cụ thể
            try
            {
                var response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode(); // Đảm bảo kết quả trả về là thành công

                var jsonString = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(jsonString))
                {
                    var resdata = JsonConvert.DeserializeObject<ResData>(jsonString);
                    return resdata;
                }
                else
                {
                    // Xử lý khi jsonString rỗng hoặc null
                    Console.WriteLine("Empty response from server.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null; // Xử lý ngoại lệ và trả về null
            }
        }

    }
}
