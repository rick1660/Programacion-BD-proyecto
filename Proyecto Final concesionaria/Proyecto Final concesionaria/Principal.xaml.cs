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

namespace Proyecto_Final_concesionaria
{
    /// <summary>
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BtmPopupSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            BtnOpen.Visibility = Visibility.Collapsed;
            BtnClose.Visibility = Visibility.Visible;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            BtnOpen.Visibility = Visibility.Visible;
            BtnClose.Visibility = Visibility.Collapsed;
        }

        private void StackPanel_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void BtnOne_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}
