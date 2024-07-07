// Program.cs

using Razor_Pages_ListOfMovies3.Services;

var builder = WebApplication.CreateBuilder(args);

// Добавляем в приложение сервисы Razor Pages
builder.Services.AddRazorPages();

// Регистрация сервиса как Singleton
builder.Services.AddSingleton<Films>();

var app = builder.Build();

// Добавляем поддержку маршрутизации для Razor Pages
app.MapRazorPages();

app.Run();