namespace InfoCategoryApp.Services
{
	public static class ConfigureServices
	{
		// Este m�todo pode ser chamado para configurar servi�os
		public static void AddCustomServices(IServiceCollection services)
		{
			services.AddScoped<CategoryService>();
			// Adicione outros servi�os necess�rios
		}
	}
}
