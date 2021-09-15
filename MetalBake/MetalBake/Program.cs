using MetalBake.Interfaces;
using System;
using Microsoft.Extensions.DependencyInjection;
using MetalBake.Servicios;

namespace MetalBake {
    class Program {
        static void Main(string[] args) {
            var MenuManager = new MenuWithInterface();
            MenuManager.Display();
        }
    }
}
