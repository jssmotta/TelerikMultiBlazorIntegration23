using Microsoft.AspNetCore.Localization;
using System.Globalization;
using TelerikBlazorAppMain.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddTelerikBlazor();
builder.Services.AddScoped<IDataService, DataService>();
builder.Services.Configure<IISOptions>(options =>
{
    options.ForwardClientCertificate = false;
});
#region Localization

builder.Services.AddControllers();
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    // define the list of cultures your app will support
    var supportedCultures = new List<CultureInfo>()
    {
        new("en-US"),
        new("de-DE"),
        new("es-ES"),
        new("bg-BG")
    };

    // set the default culture
    options.DefaultRequestCulture = new RequestCulture("en-US");

    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});

// the custom localizer service is registered later, after the Telerik services

#endregion

builder.Services.AddSingleton<HubConnector.Hub>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseRouting();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.MapRazorPages();
app.MapControllers();
app.MapBlazorHub();

app.MapFallbackToPage("/_Host");

app.Run();

 