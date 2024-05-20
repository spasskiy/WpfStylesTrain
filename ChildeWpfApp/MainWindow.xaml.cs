using System.IO;
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

namespace ChildeWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _nightModeOn = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            _nightModeOn = !_nightModeOn;
            string currentStyle;
            if (_nightModeOn)
            {
                currentStyle = "/Styles/StyleDictionaryNight.xaml";
            }
            else
            {
                currentStyle = "/Styles/StyleDictionaryDay.xaml";
            }

            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri(currentStyle, UriKind.Relative) });
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("/Styles/MainDictionary.xaml", UriKind.Relative) });
        }
    }
}