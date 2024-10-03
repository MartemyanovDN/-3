using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Лаба_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            menu.Background = Brushes.Red;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            menu.Background = Brushes.Green;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            menu.Background = Brushes.Blue;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            menu.Background = Brushes.White;
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Дмитрий Николаевич.");
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Window.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Дмитрий Николаевич.");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            menu.Background = Brushes.Red;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            menu.Background = Brushes.Green;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            menu.Background = Brushes.Blue;
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            var btn = (sender as System.Windows.Controls.Primitives.ButtonBase);
            string btnContent = btn.Name.ToString().TrimStart('_');
            if (btnContent == "red" || btnContent == "green" || btnContent == "blue")
                status.Text = btnContent;
            else if (btnContent == "info") status.Text = "Developer info";
            else if (btnContent == "close") status.Text = "Hides the program";
        }
    }
}