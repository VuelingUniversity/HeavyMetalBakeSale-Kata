using MetalBake.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Servicios {
    class Container {
        public static IServiceProvider Build() {
            var Container = new ServiceCollection()
          .AddSingleton<IMenu, MenuService>()
          .AddSingleton<IPay, PayService>()
          .AddSingleton<IReader, ReaderService>();
            return Container.BuildServiceProvider();
        }
    }
}