using System;
using System.Collections.Generic;
using System.IO.Packaging;
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

namespace Oefening6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.SizeChanged += OnSizeChanged;
            InitializeLeftTopRectangle();
            InitializeLeftBottomRectangle();
            InitializeRightBottomRectangle();
            InitializeRightTopRectangle();
        }

        private void InitializeLeftTopRectangle()
        {
            leftTopRectangle.Fill = new SolidColorBrush(Colors.Aqua);
            leftTopRectangle.Margin = new Thickness(5);
        }

        private void InitializeLeftBottomRectangle()
        {
            leftBottomRectangle.Fill = new SolidColorBrush(Colors.AliceBlue);
            leftBottomRectangle.Margin = new Thickness(5);
        }
        private void InitializeRightBottomRectangle()
        {
            rightBottomRectangle.Fill = new SolidColorBrush(Colors.Red);
            rightBottomRectangle.Margin = new Thickness(5);
        }
        private void InitializeRightTopRectangle()
        {
            rightTopRectangle.Fill = new SolidColorBrush(Colors.Green);
            rightTopRectangle.Margin = new Thickness(5);
        }

        private void OnSizeChanged(object sender, SizeChangedEventArgs sizeChangedEventArgs)
        {
           double resWidth =  (this.Width - 140) / 2;
           double resHeight = (this.Height - 60) / 2; 
            if (resWidth < 0)
            {
                resWidth = 0;
            }

            if (resHeight < 0)
            {
                resHeight = 0;
            }

            leftTopRectangle.Width = resWidth;
            leftTopRectangle.Height = resHeight;
            leftBottomRectangle.Width = resWidth;
            leftBottomRectangle.Height = resHeight;
            rightTopRectangle.Width = resWidth;
            rightTopRectangle.Height = resHeight;
            rightBottomRectangle.Width = resWidth;
            rightBottomRectangle.Height = resHeight;
        }


        private void AboutMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            statusBarTextBlock.Text = "Created by Toon, Wouter";
        }

        private void ExitMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void changeColorButton_Click(object sender, RoutedEventArgs e)
        {
            leftTopRectangle.Fill = rightTopRectangle.Fill;
        }

        private void changeWindowButton_Click(object sender, RoutedEventArgs e)
        {
            this.Height -= 5;
            this.Width -= 5;
            statusBarTextBlock.Text = Convert.ToString(this.Width);
        }

        private void deleteRectanglesButton_Click(object sender, RoutedEventArgs e)
        {
            rectangleGrid.Children.Clear();
           
        }
    }
}
