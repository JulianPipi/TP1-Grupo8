using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_8
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
           // if()
           // {

           // }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if(TxtApellido.Text != ("") && TxtNombre.Text != ("") )
            {
                LblNombre.Text.Trim();
                LblApellido.Text.Trim();
                LbLista.Items.Add(TxtNombre.Text + " " + TxtApellido.Text);
                LbLista.Sorted = true;
            }
        }
    }
}
