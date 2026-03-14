var builder = WebApplication.CreateBuilder(args);

// Adicionamos o serviço do Razor Pages (o "motor" do C#)
builder.Services.AddRazorPages();

var app = builder.Build();

// Permite ler arquivos de CSS, imagens, etc, dentro da wwwroot
app.UseStaticFiles();

// Mapeia a leitura do C# para as páginas HTML
app.MapRazorPages();

app.Run();