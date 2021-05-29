using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorPro.BlazorSize;

namespace BoardWatcherClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<ChessGameStateService>();
            builder.Services.AddSingleton<RoutingService>();
            builder.Services.AddMediaQueryService();
            // builder.Services.UseCors(policy =>
            //     policy.WithOrigins("http://localhost:5000", "https://localhost:5001")
            //     .AllowAnyMethod()
            //     .WithHeaders(HeaderNames.ContentType));
            await builder.Build().RunAsync();
        }
    }
}
