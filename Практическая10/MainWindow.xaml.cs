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
using System.Drawing;


namespace Практическая10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.Width = 1000; this.Height = 600;
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Color.FromRgb(240, 230, 140));           
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            UserTextBlock1.FontFamily = new FontFamily("Wide Latin");
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            UserTextBlock1.Text = "Bye";
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            UserTextBlock1.Foreground = new SolidColorBrush(Color.FromRgb(220, 20, 20));
        }
    }
}
