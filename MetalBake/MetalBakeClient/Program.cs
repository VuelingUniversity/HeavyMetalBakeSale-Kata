using MetalBake.Servicios;

namespace MetalBake {
    class Program {
        static void Main(string[] args) {
            var MenuManager = new MenuWithInterface();
            MenuManager.Display();
        }
    }
}
