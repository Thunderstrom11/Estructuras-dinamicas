using Estructuras_dinamicas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras_dinamicas.Formularios
{
    public partial class FrmPila2 : Form
    {
        Stack <Expediente> pila = new Stack<Expediente>();
        public FrmPila2()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Expediente est = new Expediente();
            est.Nombres = tbNombre.Text;
            est.Apellidos = tbApellido.Text;
            est.promedio = int.Parse(tbPromedio.Text);

            pila.Push(est);

        }
        private void LlenarList()
        {
            lstPromedios.Items.Clear();
        }
    }
}
