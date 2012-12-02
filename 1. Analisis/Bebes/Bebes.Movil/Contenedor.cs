using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Bebes.Movil
{
    public class Contenedor: INotifyPropertyChanged
    {
        private ObservableCollection<Registro> listaRegistros = new ObservableCollection<Registro>();

        public ObservableCollection<Registro> ListaRegistros
        {
            get { return listaRegistros; }
            set
            {
                ListaRegistros = value;
                Notificarcambio("ListaRegistros");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public void Notificarcambio(string propiedad)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            
            
            
        }
    }
}
