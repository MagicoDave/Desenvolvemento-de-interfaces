using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Ejer7
{

    public partial class Form1 : Form
    {

        private int[,] notas;
        private string[] alumnos;
        public string[] asignaturas = {"Pociones","Quidditch","Criaturas","Artes Oscuras"};
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
            foreach (string asignatura in asignaturas)
            {
                cboxAsignatura.Items.Add(asignatura);
            }

            //Rellenar notas con datos aleatorios
            Notas = new int[Alumnos.Length, asignaturas.Length];
            Random generador = new Random();
            for (int i = 0; i < Notas.GetLength(0); i++)
            {
                for (int j = 0; j < Notas.GetLength(1); j++)
                {
                    Notas[i, j] = generador.Next(0, 11);
                }
            }

            //Generar la tabla
            //Generar cabeceras
            int x = 100;
            int y = 50;


            for (int i = 0; i < asignaturas.Length; i++)
            {
                Label lbl = new Label();
                lbl.Text = asignaturas[i];
                lbl.Location = new Point(x, y);
                lbl.Size = new Size(80, 20);
                panel1.Controls.Add(lbl);

                x += 100;
            }

        }


    }
}