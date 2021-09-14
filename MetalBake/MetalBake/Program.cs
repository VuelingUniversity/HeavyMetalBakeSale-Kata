using MetalBake.Interfaces;
using System;
using System.ComponentModel;

namespace MetalBake {
    class Program {
        static void Main(string[] args) {
            var ContainerProvider = Container.Build();
            var MenuManager = ContainerProvider.GetService<IMenu>();
            MenuManager.Display();
        }
    }
}
