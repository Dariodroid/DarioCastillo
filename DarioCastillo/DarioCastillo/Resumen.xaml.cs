using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DarioCastillo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, string usuario, double total)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            txtNombre.Text = nombre;
            txtTotal.Text = total.ToString();
        }
    }
}