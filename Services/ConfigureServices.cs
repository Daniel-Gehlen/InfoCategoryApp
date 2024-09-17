namespace InfoCategoryApp.Services
{
	public static class ConfigureServices
	{
		// Este método pode ser chamado para configurar serviços
		public static void AddCustomServices(IServiceCollection services)
		{
			services.AddScoped<CategoryService>();
			// Adicione outros serviços necessários
		}
	}
}
