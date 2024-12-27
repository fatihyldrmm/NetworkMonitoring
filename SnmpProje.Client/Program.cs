using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SnmpProje.Client;
using SnmpProje.Client.Extensions;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);


builder.RootComponents.Add<App>("#app");

builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddServiceRegistration();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped(sp =>
{
    var clientFactory = sp.GetRequiredService<IHttpClientFactory>();

    return clientFactory.CreateClient("ApiHttpClient");
});

builder.Services.AddHttpClient("ApiHttpClient", client =>
{
    client.BaseAddress = new Uri("https://localhost:7289/");
});

await builder.Build().RunAsync();
