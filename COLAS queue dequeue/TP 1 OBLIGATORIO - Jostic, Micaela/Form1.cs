using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1_OBLIGATORIO___Jostic__Micaela
{
    public partial class Form1 : Form
    {
        Cola colaAlumnos = new Cola();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            if(nombre != "")
            {
                FormularioAlumno form = new FormularioAlumno(nombre);
                form.ShowDialog();
                if (form.Resultado == "Aceptar")
                {
                    Alumno nuevoAlumno = new Alumno(nombre);
                    colaAlumnos.encolar(nuevoAlumno);          //queue
                    MostrarCola();
                    txtNombre.Clear();
                    MessageBox.Show("Alumno agregado a la cola.");
                }
                else if (form.Resultado == "Cancelar")
                {
                    txtNombre.Clear();
                    MessageBox.Show("Alumno no agregado a la cola.");
                }
            }
        }

        private void btnTope_Click(object sender, EventArgs e)
        {
            Alumno tope = colaAlumnos.Tope();
            if(tope != null)
            {
                MessageBox.Show("Primer alumno: " + tope.Nombre);    //peek
            }
            else
            {
                MessageBox.Show("No hay alumnos en la cola.");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Alumno borrado = colaAlumnos.desencolar();
            if (borrado != null)
            {
                MessageBox.Show("Alumno borrado: " + borrado.Nombre);
                MostrarCola();        //dequeue
            }
            else
            {
                MessageBox.Show("No hay alumnos en la cola.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarCola()
        {
            listBox1.Items.Clear();
            Nodo aux = colaAlumnos.Inicio();
            while (aux != null)
            {
                listBox1.Items.Add(aux.Dato.Nombre);
                aux = aux.Siguiente;
            }
        }


    }

}
