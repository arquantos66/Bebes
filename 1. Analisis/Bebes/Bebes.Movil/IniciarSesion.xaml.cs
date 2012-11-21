using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Bebes.Movil
{
    public partial class NuevaActividad : PhoneApplicationPage
    {
         public NuevaActividad()
         {
            InitializeComponent();
         }

         private void btnBorrar_Click(object sender, System.EventArgs e)
         {
        	// TODO: Agregar implementación de controlador de eventos aquí.
         }

         private void btnguardar_Click(object sender, System.EventArgs e)
         {
        	// TODO: Agregar implementación de controlador de eventos aquí.
         }

         private void btnCrearPerfil_Click(object sender, System.EventArgs e)
         {
        	// TODO: Agregar implementación de controlador de eventos aquí.
            NavigationService.Navigate(new Uri("/CrearPerfil.xaml", UriKind.Relative));
         }

        }
    }
