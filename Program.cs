using ManejoJson;

internal class Program
{
    private static void Main(string[] args)
    {
        Controlador controller = new Controlador();
        bool isActive = false;
        int opc =0;

        do{
            Console.Clear();
            Console.WriteLine("1. Crear Registro 2. Editar");
            opc = Convert.ToInt16(Console.ReadLine());
            switch (opc){
                case 1:
                    controller.AddInfo();
                    break;
                case 2:
                    Console.WriteLine("Ingrese el código del equipo a modificar");
                    controller.AddPlayerToTeam();
                    break;
                default:
                break;
            }
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    
}