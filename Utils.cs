using Microsoft.Extensions.DependencyInjection;
using Roman015API.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePageToys
{
    public static class Utils
    {
        public static void AddHomePageToys(this IServiceCollection ServiceCollection)
        {
            ServiceCollection.AddSingleton<StarWarsHub>(sp => {
                return StarWarsHub.GetSingletonInstance();
            });
        }
    }
}
