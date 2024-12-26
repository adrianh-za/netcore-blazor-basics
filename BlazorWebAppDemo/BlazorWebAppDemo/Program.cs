using Blazored.LocalStorage;
using Blazored.SessionStorage;
using BlazorWebAppDemo;
using BlazorWebAppDemo.Client.Pages;
using BlazorWebAppDemo.Components;
using BlazorWebAppDemo.Components.Demo.Cascade;
using BlazorWebAppDemo.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

//This will allow site wide updates
builder.Services.AddCascadingValue(sp =>
{
    var model = new CascadingModel();
    model.SomeText = "Hello from CascadingValue";
    var source = new CascadingValueSource<CascadingModel>(model, isFixed: false);
    model.PropertyChanged += (sender, args) =>
    {
        source.NotifyChangedAsync();
    };
    return source;
});

builder.Services.AddScoped<IMyService, MyService>();
builder.Services.AddTransient<IStateService, StateService>();
builder.Services.AddScoped<ISuperheroService, SuperheroService>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredSessionStorage();

builder.Services.AddMudServices();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorWebAppDemo.Client._Imports).Assembly);

app.Run();