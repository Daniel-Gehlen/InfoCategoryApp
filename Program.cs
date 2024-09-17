using InfoCategoryApp;
using InfoCategoryApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Adiciona o componente raiz (App) na página index.html
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Registra o CategoryService como Scoped para ser injetado nos componentes
builder.Services.AddScoped<CategoryService>();

// Registra o HttpClient para requisições HTTP
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Constrói a aplicação e a executa no cliente
await builder.Build().RunAsync();
