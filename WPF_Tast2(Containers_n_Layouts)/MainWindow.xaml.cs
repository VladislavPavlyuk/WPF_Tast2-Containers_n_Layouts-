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

namespace WPF_Tast2_Containers_n_Layouts_
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

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Result.Text += button.Content.ToString();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Result.Text += button.Content.ToString();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Result.Text += button.Content.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Result.Text += button.Content.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Result.Text += button.Content.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Result.Text += button.Content.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Result.Text += button.Content.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Result.Text += button.Content.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Result.Text += button.Content.ToString();
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Result.Text += button.Content.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text.Remove(Result.Text.Length - 1);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Result.Text = button.Content.ToString();
        }
    }
}