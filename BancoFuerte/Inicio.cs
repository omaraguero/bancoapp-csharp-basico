﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoFuerte
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSolicitarPrestamo.Enabled = false;
        }

        private void controlBotones()
        {
            if (nombre.Text.Trim() != string.Empty && nombre.Text.All(Char.IsLetter))
            {
                btnSolicitarPrestamo.Enabled = true;
                errorProvider1.SetError(nombre, "");
            }
            else
            {
                if(!(nombre.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(nombre, "El nombre solo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(nombre, "Debe introducir su nombre");
                }
                btnSolicitarPrestamo.Enabled = false;
                nombre.Focus();
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void btnSolicitarPrestamo_Click(object sender, EventArgs e)
        {
            using (Prestamos ventanaPrestamos = new Prestamos(nombre.Text))
                ventanaPrestamos.ShowDialog();
        }
    }
}
