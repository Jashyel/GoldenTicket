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
    /// Lógica de interacción para Calificacionau.xaml
    /// </summary>
    public partial class Calificacionau : UserControl
    {
        public Calificacionau()
        {
            InitializeComponent();
        }

        private void BatmanAudiencia(object sender, RoutedEventArgs e)
        {
            BatmanAudiencia ac = new BatmanAudiencia();
            ac.ShowDialog();
        }

        private void MorbiusAudiencia(object sender, RoutedEventArgs e)
        {
            MorbiusAudiencia ac = new MorbiusAudiencia();
            ac.ShowDialog();
        }

        private void FantasticBeastsAudiencia(object sender, RoutedEventArgs e)
        {
            FantasticBeastsAudiencia ac = new FantasticBeastsAudiencia();
            ac.ShowDialog();
        }

        private void Sonic2Audiencia(object sender, RoutedEventArgs e)
        {
            Sonic2Audiencia ac = new Sonic2Audiencia();
            ac.ShowDialog();
        }
    }
}
