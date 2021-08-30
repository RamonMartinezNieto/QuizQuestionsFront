using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using QuizQuestionsFront.Services;
using QuizQuestionsFront.Services.QuestionsApiRest;
using QuizQuestionsFront.Services.Storage;

namespace QuizQuestionsFront
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            //Blazorise
            builder.Services
              .AddBlazorise(options =>
              {
                  options.ChangeTextOnKeyPress = true;
              })
              .AddBootstrapProviders()
              .AddFontAwesomeIcons();

            builder.Services.AddSingleton(new HttpClient
            {
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
            });

            builder.Services.AddHttpClient("QuestionsApi", client =>
                {
                    client.BaseAddress = new Uri("https://simple-rest-api-questions.herokuapp.com");
                }
            );

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            
            //Injects
            builder.Services.AddSingleton<ISessionStorageService, SessionStorageService>();
            builder.Services.AddSingleton<IRestApiQuestions, RestApiQuestions>();
            builder.Services.AddSingleton<ILocalStorage, LocalStorage>();


            builder.RootComponents.Add<App>("#app");

            await builder.Build().RunAsync();
        }
    }
}
