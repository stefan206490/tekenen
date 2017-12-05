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

namespace tekenen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Point point1;
        public Point point2;
        public Point point3;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPoligon_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush DarkBlueBrush = new SolidColorBrush();
            DarkBlueBrush.Color = Colors.DarkBlue;
            SolidColorBrush GreenBrush = new SolidColorBrush();
            GreenBrush.Color = Colors.Green;

            Polygon Mypoligon = new Polygon();
            Mypoligon.Fill = GreenBrush;
            Mypoligon.Stroke = DarkBlueBrush;
            Mypoligon.StrokeThickness = 5;

            Point point1 = new Point(50, 100);
            Point point2 = new Point(200, 100);
            Point point3 = new Point(200, 200);
            PointCollection polygonPoints = new PointCollection();
            polygonPoints.Add(point1);
            polygonPoints.Add(point2);
            polygonPoints.Add(point3);

            Mypoligon.Points = polygonPoints;

            draw.Children.Add(Mypoligon);
        }

        private void btnSquare_Click(object sender, RoutedEventArgs e)
        {
            Rectangle Myrectangle = new Rectangle();
            Myrectangle.Stroke = Brushes.Black;
            Myrectangle.Fill = Brushes.Blue;
            Myrectangle.Height = 200;
            Myrectangle.Width = 200;
            Myrectangle.RadiusX = 50;
            Myrectangle.RadiusY = 50;
            draw.Children.Add(Myrectangle);
        }

        private void btnLine_Click(object sender, RoutedEventArgs e)
        {
            Line Line1 = new Line();
            Line1.X1 = 100;
            Line1.Y1 = 100;
            Line1.X2 = 200;
            Line1.Y2 = 200;
            Line1.Stroke = Brushes.Black;
            Line1.StrokeThickness = 5;
            draw.Children.Add(Line1);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            draw.Children.Clear();
            scroll.Visibility = Visibility.Hidden;
        }

        private void btnimage_Click(object sender, RoutedEventArgs e)
        {
            scroll.Visibility = Visibility.Visible;
        }
    }
}
