using MetalBake.Interfaces;
using MetalBake.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake
{
   public class Containers
    {
        public static IServiceProvider Build()
        {           
            var services = new ServiceCollection()
                .AddSingleton<IAccountable, AccountService>();
              
            return services.BuildServiceProvider();
        }
    }
}
