using System.ComponentModel;
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

namespace Kocsik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string tulajdonsagNev)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(tulajdonsagNev));
        }

        private void search_BTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void new_BTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void modify_BTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void delete_BTN_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}