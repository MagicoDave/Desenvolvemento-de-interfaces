using ejercicio2;

namespace ejer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aula prueba = new Aula(new string[] {"Pepe", "Maria", "Jose", "Rigoberto", "Eustaquio" });
            prueba.tablaNotas();
        }
    }
}