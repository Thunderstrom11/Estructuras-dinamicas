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
    public partial class FrmPilas : Form
    {
        Stack<int> pila = new Stack<int>(); // creación de la pila
        public FrmPilas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int elemento = int.Parse(tbNumero.Text);
            pila.Push(elemento); // agregar un elemento a la pila
            lblPilas.Text = MostrarElementos();
        }

        private string MostrarElementos()
        {
            string msn = "";

            foreach (int i in pila)
            {
                msn += " " + i.ToString() + " |";
            }
            return msn;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                pila.Pop(); // quitar el elemento superior de la pila
                lblPilas.Text = MostrarElementos();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Estimado usuarrio, no se puede eliminar elementos, porque la pila esta vacía.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                          // ^ burro  
            }
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"{pila.Peek()}", "Ultimo elemento ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information); // ver el elemento superior de la pila
                lblPilas.Text = MostrarElementos();

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Estimado usuarrio, no se puede seleccionar un elemento inexcistente, porque la pila esta vacía.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}   
