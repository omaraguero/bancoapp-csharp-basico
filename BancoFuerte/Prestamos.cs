using System;
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
    public partial class Prestamos : Form
    {

        string nombre_cliente;
        string[] ciudades = { "Piedras Negras", "Nava", "Allende", "Acuna", "Saltillo", "Morelos", "Torreon", "Ramos Arizpe", "Ocampo" };
        int[] cuotas_disponibles = { 12, 24, 36, 60, 120, 180, 240 };
        string[] ocupaciones_disponibles;
        Dictionary<int, double> intereses_base;

        public Prestamos(string nombre)
        {
            InitializeComponent();
            nombre_cliente = nombre;

            string listado_ocupaciones = Properties.Resources.ocupaciones.ToString();
            ocupaciones_disponibles = listado_ocupaciones.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            intereses_base = new Dictionary<int, double>();
            int i;
            double interes;
            for (i = 0, interes = 3.0; i < cuotas_disponibles.Length; i++, interes += 0.5)
            {
                intereses_base[cuotas_disponibles[i]] = interes;
            }


        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            popularCuotas();
            popularCiudades();
            popularOcupaciones();
            saludo.Text += nombre_cliente;
        }

        void popularCuotas()
        {
            for (int i = 0; i < cuotas_disponibles.Length; i++)
            {
                cuotas.Items.Add(cuotas_disponibles[i]);
            }
        }

        void popularOcupaciones()
        {
            for (int i = 0; i < ocupaciones_disponibles.Length; i++)
            {
                ocupacion.Items.Add(ocupaciones_disponibles[i]);
            }
        }
        
        void popularCiudades()
        {
            for (int i = 0; i < ciudades.Length; i++)
            {
                ciudad.Items.Add(ciudades[i]);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double calcularInteres()
        {
            int cuotas_pedidas = (int)cuotas.SelectedItem;
            string ciudad_seleccionada = ciudad.SelectedItem.ToString().ToLower();
            string ocupacion_seleccionado = ocupacion.SelectedItem.ToString().ToLower();
            double interes = intereses_base[cuotas_pedidas];
            if (new[] { "piedras negras", "nava", "allende", "acuna", "saltillo" }.Contains(ciudad_seleccionada))
            {
                interes += 0.3;
            }
            if (new[] { "agricultor", "operador", "taxista", "vendedor" }.Contains(ocupacion_seleccionado))
            {
                interes -= 0.3;
            }
            return interes;
        }

        private void btnConfirmarSolicitud_Click(object sender, EventArgs e)
        {
            switch (validaciones())
            {
                case 0:
                    {
                        errorProvider1.SetError(datosPersonales, "");
                        errorProvider1.SetError(datosPrestamos, "");
                        double interes_mensual = calcularInteres();
                        double monto_pedido = double.Parse(monto.Text);
                        int cuotas_pedidas = (int)cuotas.SelectedItem;
                        double interes_total = monto_pedido * (interes_mensual / 100) * cuotas_pedidas;
                        double monto_a_pagar = monto_pedido + interes_total;
                        string mensaje = "Su préstamo por " + monto_pedido + " en " + cuotas_pedidas + " cuotas se concederá con un interés del " + interes_mensual + "% mensual.\nEl monto final asciende a " + monto_a_pagar;
                        MessageBoxButtons botones = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Cálculo de intereses", botones);
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(datosPersonales, "Debe completar todos los datos personales");
                        errorProvider1.SetError(datosPrestamos, "");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(datosPrestamos, "Debe ingresar un monto numérico y una cantidad de cuotas");
                        errorProvider1.SetError(datosPersonales, "");
                        break;
                    }

            }
        }


        int validaciones()
        {
            if ((ciudad.SelectedIndex <= -1) || (ocupacion.SelectedIndex <= -1))
            {
                return 1;
            }
            else
            {
                if (!(monto.Text.All(Char.IsDigit)) || (monto.Text == "") || (cuotas.SelectedIndex <= -1)) 
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }




    }
}
