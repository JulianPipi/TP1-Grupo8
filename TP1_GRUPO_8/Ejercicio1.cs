﻿using System;
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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txtNombre.Text.Trim();
            bool iguales = false;

            foreach(string n in lbNombres1.Items)
            {
                if(nuevoNombre.ToUpper() == n.ToUpper())
                {
                    iguales = true;
                    break;
                }
            }

            if(nuevoNombre == "")
            {
                MessageBox.Show("Ingrese un nombre");
                txtNombre.Clear();
            }else if(iguales)
            {
                MessageBox.Show("No se pueden repetir los nombres");
                txtNombre.Clear();
            }
            else
            {
                lbNombres1.Items.Add(nuevoNombre);
                txtNombre.Clear();
            }
        }

        //Al apretar > , pasar el nombre a la segunda lista y eliminar de la primera
        private void btnUno_Click(object sender, EventArgs e)
        {
            //faltaria verificar que haya un elemento seleccionado

            lbNombres2.Items.Add (lbNombres1.SelectedItem.ToString());

            lbNombres1.Items.Remove(lbNombres1.SelectedItem);
        }
    }
}
