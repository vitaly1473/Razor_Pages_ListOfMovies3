// Program.cs

using Razor_Pages_ListOfMovies3.Services;

var builder = WebApplication.CreateBuilder(args);

// ��������� � ���������� ������� Razor Pages
builder.Services.AddRazorPages();

// ����������� ������� ��� Singleton
builder.Services.AddSingleton<Films>();

var app = builder.Build();

// ��������� ��������� ������������� ��� Razor Pages
app.MapRazorPages();

app.Run();