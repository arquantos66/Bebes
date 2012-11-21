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
using System.Collections.ObjectModel;

namespace Bebes.Movil
{
    public class ClasePrincipal
    {
        private ObservableCollection<Registro> Lista = new ObservableCollection<Registro>();

        public ObservableCollection<Registro> Lista1
        {
            get { return Lista; }
            set { Lista = value; }
        }
    }
}
