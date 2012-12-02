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
using System.Linq;





namespace Bebes.Movil
{
    public partial class MainPage : PhoneApplicationPage
    {
        
        public MainPage()

        {
            InitializeComponent();
            this.DataContext = App.Contexto;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            using (BaseDatosDataContext contexto = new BaseDatosDataContext("isostore:/db.sdf"))
            {
                (from i in contexto.Registro select i).ToList().ForEach(p => App.Contexto.ListaRegistros.Add(p));

                }
        }

        private void btnagregar_Click(object sender, System.EventArgs e)
        {
        	
			// TODO: Agregar implementación de controlador de eventos aquí.
            NavigationService.Navigate(new Uri("/IniciarSesion.xaml", UriKind.Relative));
        }

        private void btnAcercaDE_Click(object sender, System.EventArgs e)
        {
        	// TODO: Agregar implementación de controlador de eventos aquí.
            NavigationService.Navigate(new Uri("/AcercaDE.xaml", UriKind.Relative));
        }
    }
}