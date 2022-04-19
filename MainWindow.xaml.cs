using GoldenTicket.Views;
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

namespace GoldenTicket
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

        private void TBShow(object sender, RoutedEventArgs e)
        {
            GridContent.Opacity = 0.5;
        }

        private void TBHide(object sender, RoutedEventArgs e)
        {
            GridContent.Opacity = 1;
        }

        private void PMLBDown(object sender, MouseButtonEventArgs e)
        {
            BtnShowHide.IsChecked = false;
        }

        private void Minimizar(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Cerrar(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Dashboard(object sender, RoutedEventArgs e)
        {
            DataContext = new Dashboard();
        }

        private void Info(object sender, RoutedEventArgs e)
        {
            Info ac = new Info();
            ac.ShowDialog();
        }

        private void AcercaDe(object sender, RoutedEventArgs e)
        {
            AcercaDe ac = new AcercaDe();
            ac.ShowDialog();
        }

        private void Calif_click(object sender, RoutedEventArgs e)
        {
            DataContext = new Calificacion();
        }

        private void Califau_click(object sender, RoutedEventArgs e)
        {
            DataContext = new Calificacionau();
        }
    }
}
