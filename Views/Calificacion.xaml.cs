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
namespace GoldenTicket.Views
{
    /// <summary>
    /// Lógica de interacción para Calificacion.xaml
    /// </summary>
    public partial class Calificacion : UserControl
    {
        public Calificacion()
        {
            InitializeComponent();
        }

        private void batman(object sender, RoutedEventArgs e)
        {
            batman ac = new batman();
            ac.ShowDialog();
        }

        private void morbius(object sender, RoutedEventArgs e)
        {
            morbius ac = new morbius();
            ac.ShowDialog();
        }


        private void fbd(object sender, RoutedEventArgs e)
        {
            fbd ac = new fbd();
            ac.ShowDialog();
        }

        private void sonicc(object sender, RoutedEventArgs e)
        {
            sonicc ac = new sonicc();
            ac.ShowDialog();
        }
    }
}
