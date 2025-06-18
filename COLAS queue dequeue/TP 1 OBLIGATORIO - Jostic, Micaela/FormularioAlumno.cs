using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1_OBLIGATORIO___Jostic__Micaela
{
    public partial class FormularioAlumno : Form
    {
        public string Resultado = "";
        public FormularioAlumno(string nombre)
        {
            InitializeComponent();
            lbl2.Text="¿Desea agregar a: "+ nombre.ToUpper() + " a la cola?";
            Resultado = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Resultado = "Aceptar";
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Resultado = "Cancelar";
            this.Close();
        }
    }
}
