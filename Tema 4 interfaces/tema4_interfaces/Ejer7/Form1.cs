using System.Diagnostics;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Ejer7
{

    public partial class Form1 : Form
    {
        private Aula aula;

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

            //Inicializar aula con alumnos
            aula = new Aula(aux);

            //Rellenar los combobox
            string[] asignaturas = Enum.GetNames(typeof(Aula.Asignaturas));
            foreach (string alumno in aula.Alumnos)
            {
                cboxAlumno.Items.Add(alumno);
            }
            foreach (string asignatura in asignaturas)
            {
                cboxAsignatura.Items.Add(asignatura);
            }

            //Generar la tabla
            //Generar cabeceras asignaturas
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

            //Generar cabeceras alumnos
            x = 50;
            y = 100;

            for (int i = 0; i < aula.Alumnos.Length; i++)
            {
                Label lbl = new Label();
                lbl.Text = aula.Alumnos[i];
                lbl.Location = new Point(x, y);
                lbl.Size = new Size(80, 20);
                lbl.Font = new Font(lbl.Font, FontStyle.Italic);
                panel1.Controls.Add(lbl);

                y += 50;
            }

            //Colocar notas
            x = 175;
            y = 100;

            for (int i = 0; i < aula.Notas.GetLength(0); i++)
            {
                for (int j = 0; j < aula.Notas.GetLength(1); j++)
                {
                    Label lbl = new Label();
                    lbl.Text = aula.Notas[i,j].ToString();
                    lbl.Location = new Point(x, y);
                    lbl.Size = new Size(20, 20);
                    toolTip1.SetToolTip(lbl, "Alumno: " + aula.Alumnos[i] + " | Asignatura: " + asignaturas[j]);
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
            lblMediaTabla.Text = string.Format("Media de la tabla: {0:0.00}", aula.mediaNotas());
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
            int maxima = 0;
            int minima = 0;
            aula.alumnoMaxMin(cboxAlumno.SelectedIndex, out maxima, out minima);
            lblMediaAlumno.Text = string.Format("Media del alumno: {0:0.00}", aula.mediaAlumno(cboxAlumno.SelectedIndex));
            lblNotaMaxima.Text = string.Format("Nota máxima: {0}", maxima);
            lblNotaMinima.Text = string.Format("Nota mínima: {0}", minima);
        }

        private void cboxAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMediaAsignatura.Text = string.Format("Media de la asignatura: {0:0.00}", aula.mediaAsignatura(cboxAsignatura.SelectedIndex));
        }
    }
}