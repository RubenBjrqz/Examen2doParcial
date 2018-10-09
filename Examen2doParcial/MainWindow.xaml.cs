using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Examen2doParcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            //controlInformacionPersonal.Visibility = Visibility.Collapsed;
            //controlContacto.Visibility = Visibility.Collapsed;
            //controlInformaciondePago.Visibility = Visibility.Collapsed;

            if(controlInformacionPersonal.Visibility == Visibility.Visible)
            {
                if(controlInformacionPersonal.txtNombre.Text == "" || controlInformacionPersonal.txtApellidoP.Text == "" ||
                   controlInformacionPersonal.txtApellidoM.Text == "" || controlInformacionPersonal.txtEdad.Text == "")
                {
                    txtAlerta1.Visibility = Visibility.Visible;
                }
                else
                {
                    txtAlerta1.Visibility = Visibility.Collapsed;
                    controlInformacionPersonal.Visibility = Visibility.Collapsed;
                    controlContacto.Visibility = Visibility.Visible;
                }
            }
            else if (controlContacto.Visibility == Visibility.Visible)
            {
                if(controlContacto.txtCorreo.Text == "" || controlContacto.txtCelular.Text == "" || controlContacto.txtTelefono.Text == "")
                {
                    txtAlerta1.Visibility = Visibility.Visible;
                }
                else
                {
                    txtAlerta1.Visibility = Visibility.Collapsed;
                    controlContacto.Visibility = Visibility.Collapsed;
                    controlInformaciondePago.Visibility = Visibility.Visible;
                    btnSiguiente.Visibility = Visibility.Collapsed;
                    btnFinalizar.Visibility = Visibility.Visible;
                }
            }

        }

        private void btnFinalizar_Click(object sender, RoutedEventArgs e)
        {
             if (controlInformaciondePago.Visibility == Visibility.Visible)
             {
                if (controlInformaciondePago.txtNumeroTarjeta.Text == "" || controlInformaciondePago.txtCVV.Text == "" ||
                   controlInformaciondePago.txtMesExpiracion.Text == "" || controlInformaciondePago.txtAñoExpiracion.Text == "")
                {
                    txtAlerta2.Visibility = Visibility.Visible;
                    txtAlerta1.Visibility = Visibility.Visible;
                }
             }
        }
    }
}
