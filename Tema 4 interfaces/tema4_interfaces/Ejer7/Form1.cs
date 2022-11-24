using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Ejer7
{

    public partial class Form1 : Form
    {

        private int[,] notas;
        private string[] alumnos;
        public enum Asignaturas
        {
            Pociones,
            Quidditch,
            Criaturas,
            ArtesOscuras
        }
        public int[,] Notas
        {
            set => notas = value;
            get => notas;
        }
        public string[] Alumnos
        {
            set => alumnos = value;
            get => alumnos;
        }

        public Form1()
        {
            InitializeComponent();

            //Lectura de datos de alumnos.txt en homepath
            string homepath, separador;
            if (Environment.OSVersion.Platform == PlatformID.Unix)
            {
                homepath = Environment.GetEnvironmentVariable("HOME");
                separador = "/";
            }
            else
            {
                homepath = Environment.GetEnvironmentVariable("homepath");
                separador = "\\";
            }
            string ruta = homepath + separador + "alumnos.txt";
            string aux = "";
            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    aux = sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            //Rellenar datos de Alumno
            Alumnos = aux.Split(",");

            //Rellenar los combobox
            foreach (string alumno in Alumnos)
            {
                cboxAlumno.Items.Add(alumno);
            }
            foreach (string asignatura in Enum.GetNames(typeof(Asignaturas)))
            {
                cboxAsignatura.Items.Add(asignatura);
            }

            //Rellenar notas con datos aleatorios
            //TODO

        }


    }
}