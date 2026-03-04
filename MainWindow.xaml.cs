using lab3_rpm.Creators;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ColorComboBox.SelectedItem is not ComboBoxItem selectedItem)
                return;

            FiguresPanel.Children.Clear();

            CircleCreator circleCreator;
            SquareCreator squareCreator;
            TriangleCreator triangleCreator;

            switch (selectedItem.Content.ToString())
            {
                case "Красный":
                    circleCreator = new RedCircleCreator();
                    squareCreator = new RedSquareCreator();
                    triangleCreator = new RedTriangleCreator();
                    break;

                case "Синий":
                    circleCreator = new BlueCircleCreator();
                    squareCreator = new BlueSquareCreator();
                    triangleCreator = new BlueTriangleCreator();
                    break;

                case "Зелёный":
                    circleCreator = new GreenCircleCreator();
                    squareCreator = new GreenSquareCreator();
                    triangleCreator = new GreenTriangleCreator();
                    break;

                default:
                    return;
            }

            FiguresPanel.Children.Add(circleCreator.Create().CreateUIElement());
            FiguresPanel.Children.Add(squareCreator.Create().CreateUIElement());
            FiguresPanel.Children.Add(triangleCreator.Create().CreateUIElement());
        }
    }
}