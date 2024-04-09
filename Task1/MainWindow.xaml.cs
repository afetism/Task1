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

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button? button = sender as Button;
            button.Background= new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 255)));
            MessageBox.Show($"I am {button.Content} and My Color is {button.Background}");
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Button? button = sender as Button;
            button.Visibility= Visibility.Collapsed;
            this.Title=button.Content.ToString();
        }
    }
}