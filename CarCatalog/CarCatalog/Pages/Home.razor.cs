using Microsoft.AspNetCore.Components;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;

namespace CarCatalog.Pages
{
    public partial class Home : ComponentBase
    {
        public class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
        }

        public List<Car> Cars { get; set; } = new List<Car>();

        [Inject]
        public HttpClient HttpClient { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Cars = await GetCarsAsync();
        }

        private async Task<List<Car>> GetCarsAsync()
        {
            var response = await HttpClient.GetFromJsonAsync<List<Car>>("https://carcatalog-hqe6bkfra4c0d7fy.southafricanorth-01.azurewebsites.net/api/cars", new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return response ?? new List<Car>();
        }
    }
}
