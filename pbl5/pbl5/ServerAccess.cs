using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl5
{
    public class ServerAccess
    {
        private string serverUrl= "http://192.168.71.176:5000";

        public ServerAccess()
        {
        }

        public async Task<List<string>> GetTables()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync($"{serverUrl}/tables");
                    response.EnsureSuccessStatusCode();

                    string jsonData = await response.Content.ReadAsStringAsync();

                    // Deserialize JSON response to list of table names
                    Dictionary<string, List<string>> tablesResponse = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(jsonData);
                    if (tablesResponse == null || !tablesResponse.ContainsKey("tables"))
                    {
                        return new List<string>();
                    }

                    // Extract tables from the response
                    return tablesResponse["tables"];
                }
                catch (Exception ex)
                {
                    // Log or handle the exception
                    return new List<string>();
                }
            }
        }
        private async Task LoadData(string table)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync($"{serverUrl}/{table}");
                    response.EnsureSuccessStatusCode();

                    string jsonData = await response.Content.ReadAsStringAsync();

                    // Deserialize the JSON data to a list of objects
                    List<dynamic> tableData = JsonConvert.DeserializeObject<List<dynamic>>(jsonData);



                    MessageBox.Show("Data loaded successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public async Task<List<User>> GetUserFromTable()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync($"{serverUrl}/users");
                    response.EnsureSuccessStatusCode();

                    string jsonData = await response.Content.ReadAsStringAsync();

                    // Deserialize the JSON response based on your data model
                    // For example, if your data model is a list of objects, you can do something like this:
                    return JsonConvert.DeserializeObject<List<User>>(jsonData);
                }
                catch (Exception ex)
                {
                    // Log or handle the exception
                    return new List<User>();
                }
            }
        }
        public async Task<List<History>> GetHistoryFromTable()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync($"{serverUrl}/history");
                    response.EnsureSuccessStatusCode();

                    string jsonData = await response.Content.ReadAsStringAsync();

             
                    return JsonConvert.DeserializeObject<List<History>>(jsonData);
                }
                catch (Exception ex)
                {
                    // Log or handle the exception
                    return new List<History>();
                }
            }
        }
        public async Task<List<Action>> GetActionFromTable()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync($"{serverUrl}/action");
                    response.EnsureSuccessStatusCode();

                    string jsonData = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<List<Action>>(jsonData);
                }
                catch (Exception ex)
                {
                    // Log or handle the exception
                    return new List<Action>();
                }
            }
        }

        public async Task<User> GetUserById(int userId)
        {
            try
            {
                List<User> users = await GetUserFromTable();
                return users.Find(user => user.UserID == userId);
            }
            catch (Exception ex)
            {
                
                return null;
            }
        }
        //public async Task<User> GetActionById(int userId)
        //{
        //    try
        //    {
        //        List<Action> actions = await GetActionFromTable();
        //        return actions.Find(action => action.UserID == userId);
        //    }
        //    catch (Exception ex)
        //    {

        //        return null;
        //    }
        //}
        public async Task<User> GetUserByUsername(string username)
        {
            try
            {
                List<User> users = await GetUserFromTable();
                return users.Find(user => user.Username == username);
            }
            catch (Exception ex)
            {

                return null;
            }
        }

    }
}
