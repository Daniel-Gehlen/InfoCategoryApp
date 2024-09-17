module InfoCategoryAppBE.Program

open System
open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting
open Microsoft.AspNetCore.Http

[<EntryPoint>]
let main args =
    // Cria o builder para o aplicativo
    let builder = WebApplication.CreateBuilder(args)

    // Adiciona servi�os ao cont�iner
    builder.Services.AddControllers() |> ignore

    // Configura CORS
    builder.Services.AddCors(fun options ->
        options.AddDefaultPolicy(fun policyBuilder ->
            policyBuilder.AllowAnyOrigin()
                         .AllowAnyMethod()
                         .AllowAnyHeader() |> ignore
        ) |> ignore
    ) |> ignore

    // Cria o aplicativo
    let app = builder.Build() 

    // Configura o pipeline de solicita��o HTTP
    if not (app.Environment.IsDevelopment()) then
        app.UseExceptionHandler("/Error") |> ignore
        app.UseHsts() |> ignore

    app.UseHttpsRedirection() |> ignore
    app.UseStaticFiles() |> ignore
    app.UseRouting() |> ignore
    app.UseAuthorization() |> ignore

    // Ativa o CORS
    app.UseCors() |> ignore

    // Mapeia rotas para controladores
    app.MapControllers() |> ignore

    // Mapeia uma rota padr�o
    app.MapGet("/", fun (context: HttpContext) -> context.Response.WriteAsync("Hello World!") |> ignore) |> ignore

    // Mapeia a rota da API para categorias
    app.MapControllerRoute(
        name = "default",
        pattern = "api/{controller}/{action}/{id?}"
    ) |> ignore

    // Executa o aplicativo
    app.Run() |> ignore

    0 // C�digo de sa�da
