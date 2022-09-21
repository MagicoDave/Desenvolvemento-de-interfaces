namespace ejercicio2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado vacio = new Empleado();
            Empleado conDatos = new Empleado("Dave", "Casal", 30, "77461003", 1000, "644888618");

            vacio.mostrarDatos();
            conDatos.mostrarDatos();
        }
    }

}