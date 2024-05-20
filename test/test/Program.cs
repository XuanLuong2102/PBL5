using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace pbl5
{
    internal class Class1
    {
        static async Task Main(string[] args) // Đánh dấu phương thức Main là "async" và kiểu trả về là "Task"
        {
            string serverUrl = "http://192.168.201.176:5000"; // Địa chỉ IP và cổng của máy chủ Flask
            List<string> tables = new List<string> { "users", "history", "action" };

            using (HttpClient client = new HttpClient())
            {
                foreach (string table in tables)
                {
                    try
                    {
                        HttpResponseMessage response = await client.GetAsync($"{serverUrl}/{table}");
                        response.EnsureSuccessStatusCode(); // Đảm bảo yêu cầu được thực hiện thành công

                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Data from table '{table}':");
                        Console.WriteLine(responseBody);
                    }
                    catch (HttpRequestException e)
                    {
                        Console.WriteLine($"Error connecting to server for table '{table}': {e.Message}");
                    }
                }
            }
        }
    }
}
