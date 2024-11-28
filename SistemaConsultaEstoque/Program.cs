using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços necessários para o ASP.NET Core
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura o pipeline de requisição HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization(); // Se houver autenticação, ela deve ser aplicada

app.UseEndpoints(endpoints =>
{
    // Rota padrão para acessar o Estoque
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Estoque}/{action=Index}/{id?}");

    // Rota para Relatorios
    endpoints.MapControllerRoute(
        name: "relatorios",
        pattern: "Relatorios/{action=RelatorioVendas}/{id?}");
});

app.Run();
