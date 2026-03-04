
using lab3_rpm.Factories;
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

namespace lab3_rpm
{
    public partial class MainWindow : Window
    {
        private IFigureFactory currentFactory;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ColorComboBox.SelectedItem is not ComboBoxItem selectedItem)
                return;

            FiguresPanel.Children.Clear();

            switch (selectedItem.Content.ToString())
            {
                case "Красный":
                    currentFactory = new RedFactory();
                    break;

                case "Синий":
                    currentFactory = new BlueFactory();
                    break;

                case "Зелёный":
                    currentFactory = new GreenFactory();
                    break;

                default:
                    return;
            }

            FiguresPanel.Children.Add(currentFactory.CreateCircle().CreateUIElement());
            FiguresPanel.Children.Add(currentFactory.CreateSquare().CreateUIElement());
            FiguresPanel.Children.Add(currentFactory.CreateTriangle().CreateUIElement());
        }
    }
}