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
using System.Windows.Shapes;

namespace GoldenTicket.Views
{
    /// <summary>
    /// Lógica de interacción para Sonic2Audiencia.xaml
    /// </summary>
    public partial class Sonic2Audiencia : Window
    {
        public Sonic2Audiencia()
        {
            InitializeComponent();
        }

        private void Cerrar(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
