using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace test
{
    public partial class Form1 : Form
    {
        private string serverUrl = "http://192.168.71.176:5000"; // Flask server IP address and port

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadTables();
            
        }

        private async Task LoadTables()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync($"{serverUrl}/tables");
                    response.EnsureSuccessStatusCode();

                    string jsonData = await response.Content.ReadAsStringAsync();

                    // Deserialize JSON response to dictionary
                    Dictionary<string, List<string>> tablesResponse = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(jsonData);
                    if (tablesResponse == null || !tablesResponse.ContainsKey("tables"))
                    {
                        MessageBox.Show("No tables found.");
                        return;
                    }

                    // Extract tables from the response
                    List<string> tables = tablesResponse["tables"];

                    // Bind table names to ComboBox
                    comboBox1.DataSource = tables;
                    MessageBox.Show("Connected successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    // Assuming you have a DataGridView named dataGridView1
                    
                    dataGridView1.DataSource = null; // Clear existing data
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = tableData;

                    MessageBox.Show("Data loaded successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
           // await LoadTables(); 
            string table = "Images";
            await LoadData(table);

        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = comboBox1.SelectedItem as string;
            if (selectedTable != null)
            {
                await LoadData(selectedTable);
            }
        }
    }
}

