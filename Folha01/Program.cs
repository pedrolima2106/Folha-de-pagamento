using Folha01.Data;
using Folha01.Repositorio;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao contêiner de injeção de dependência.
builder.Services.AddControllersWithViews();

// Configura o acesso ao banco de dados usando o Entity Framework Core.
builder.Services.AddDbContext<Context>
    (options => options.UseSqlServer("Data Source=NICHOLAS\\NICHOLASBANCO;Initial Catalog=Folha_de_Pagamento;User ID=sa;Password=1404039217nbea")); // Substitua pela string de conexão do seu banco de dados

builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

var app = builder.Build();

// Configura o pipeline de solicitações HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

// Habilita o uso de arquivos estáticos, como CSS, JavaScript, imagens, etc.
app.UseStaticFiles();

app.UseRouting(); // Define as rotas para a aplicação.

app.UseAuthorization(); // Habilita a autorização, caso seja necessário.

// Mapeia as rotas de controladores com a rota padrão.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
