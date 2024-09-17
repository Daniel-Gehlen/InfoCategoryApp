using System.Threading.Tasks;

namespace InfoCategoryApp.Services
{
    public class CategoryService
    {
        public async Task<string> GetCategoryMessage(int categoryId)
        {
            await Task.Delay(500); // Simula um atraso de rede

            return categoryId switch
            {
                1 => "Weather forecast",
                2 => "Traffic updates",
                3 => "Sports scores",
                4 => "Exiting...",
                _ => "Unknown category"
            };
        }
    }
        public class CategoryResponse
        {
            public string Message { get; set; } = string.Empty;
        }


}
