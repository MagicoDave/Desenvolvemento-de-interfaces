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
            catch (Exception ex)//evitar execpcion generica
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
            int x = 150;
            int y = 50;

            for (int i = 0; i < asignaturas.Length; i++)
            {
                Label lbl = new Label();
                lbl.Text = asignaturas[i];
                lbl.Location = new Point(x, y);
                lbl.Size = new Size(90, 20);
                lbl.Font = new Font(lbl.Font, FontStyle.Bold);
                panel1.Controls.Add(lbl);

                x += 150;
            }

            //Generar alumnos
            x = 50;
            y = 100;

            for (int i = 0; i < Alumnos.Length; i++)
            {
                Label lbl = new Label();
                lbl.Text = Alumnos[i];
                lbl.Location = new Point(x, y);
                lbl.Size = new Size(80, 20);
                lbl.Font = new Font(lbl.Font, FontStyle.Italic);
                panel1.Controls.Add(lbl);

                y += 50;
            }

            //Generar notas
            x = 175;
            y = 100;

            for (int i = 0; i < Notas.GetLength(0); i++)
            {
                for (int j = 0; j < Notas.GetLength(1); j++)
                {
                    Label lbl = new Label();
                    lbl.Text = Notas[i,j].ToString();
                    lbl.Location = new Point(x, y);
                    lbl.Size = new Size(20, 20);
                    toolTip1.SetToolTip(lbl, "Alumno: " + Alumnos[i] + " | Asignatura: " + asignaturas[j]);
                    lbl.MouseEnter += new EventHandler(lblMouseEnter);
                    lbl.MouseLeave += new EventHandler(lblMouseLeave);
                    panel1.Controls.Add(lbl);

                    x += 150;
                }
                x = 175;
                y += 50;
            }

            //Poner el index de los combobox a cero
            cboxAlumno.SelectedIndex = 0;
            cboxAsignatura.SelectedIndex = 0;

            //Media de la tabla
            double media = 0;
            for (int i = 0; i < Notas.GetLength(0); i++)
            {
                for (int j = 0; j < Notas.GetLength(1); j++)
                {
                    media += Notas[i, j];
                }
                
            }
            lblMediaTabla.Text = string.Format("Media de la tabla: {0:0.00}", media / Notas.Length);
        }

        private void lblMouseEnter(Object sender, EventArgs e)
        {
            ((Label) sender).BackColor = Color.Yellow;
        }

        private void lblMouseLeave(Object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Transparent;
        }

        private void cboxAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            double media = 0;
            int maxima = 0;
            int minima = 10;
            for (int j = 0; j < Notas.GetLength(1); j++)
            {
                media += Notas[cboxAlumno.SelectedIndex, j];
                if (Notas[cboxAlumno.SelectedIndex, j] > maxima)
                {
                    maxima = Notas[cboxAlumno.SelectedIndex, j];
                }
                if (Notas[cboxAlumno.SelectedIndex, j] < minima)
                {
                    minima = Notas[cboxAlumno.SelectedIndex, j];
                }
            }
            lblMediaAlumno.Text = string.Format("Media del alumno: {0:0.00}", media / asignaturas.Length);
            lblNotaMaxima.Text = string.Format("Nota máxima: {0}", maxima);
            lblNotaMinima.Text = string.Format("Nota mínima: {0}", minima);
        }

        private void cboxAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            double media = 0;
            for (int j = 0; j < Notas.GetLength(0); j++)
            {
                media += Notas[j, cboxAsignatura.SelectedIndex];
            }
            lblMediaAsignatura.Text = string.Format("Media de la asignatura: {0:0.00}", media / Alumnos.Length);
        }
    }
}