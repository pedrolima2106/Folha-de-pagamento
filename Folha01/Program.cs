using Folha01.Data;
using Folha01.Repositorio;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

var builder = WebApplication.CreateBuilder(args);

// Adiciona servi�os ao cont�iner de inje��o de depend�ncia.
builder.Services.AddControllersWithViews();

// Configura o acesso ao banco de dados usando o Entity Framework Core.
builder.Services.AddDbContext<Context>
    (options => options.UseSqlServer("Data Source=NICHOLAS\\NICHOLASBANCO;Initial Catalog=Folha_de_Pagamento;User ID=sa;Password=1404039217nbea")); // Substitua pela string de conex�o do seu banco de dados

builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

var app = builder.Build();

// Configura o pipeline de solicita��es HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

// Habilita o uso de arquivos est�ticos, como CSS, JavaScript, imagens, etc.
app.UseStaticFiles();

app.UseRouting(); // Define as rotas para a aplica��o.

app.UseAuthorization(); // Habilita a autoriza��o, caso seja necess�rio.

// Mapeia as rotas de controladores com a rota padr�o.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
