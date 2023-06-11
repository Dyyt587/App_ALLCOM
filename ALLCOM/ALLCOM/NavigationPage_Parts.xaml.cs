using ABI.Windows.Foundation;
using ABI.Windows.UI;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml;
using Windows.Foundation;
using Windows.Foundation.Collections;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ALLCOM
{

   
    public class Parts_Button
    {
        private void textbox_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            //MainWindow.firstpage.MultiShell.Text += "textbox_ManipulationDelta ";

            var textbox = sender as UIElement;

            var change = e.Delta.Translation;
            var left = Canvas.GetLeft(textbox);
            var top = Canvas.GetTop(textbox);
            left += change.X;
            top += change.Y;

            DataBase database = DataBase.GetInstance();
            //var frame = database.usingTablePage;
            //var canvas = frame.FindName("Table_Cancas") as Canvas; 
            var parent = VisualTreeHelper.GetParent(textbox) as FrameworkElement;
            if (parent == null) MainWindow.firstpage.MultiShell.Text += "error";

            if (left < 0)
            {
                left = 0;
            }
            if (top < 0)
            {
                top = 0;
            }
            if (top + textbox.ActualSize.Y > parent.Height)
            {
                parent.Height = top + textbox.ActualSize.Y;

            }
            if (left + textbox.ActualSize.X > parent.Width)
            {
                parent.Width = left + textbox.ActualSize.X;

            }
            Canvas.SetLeft(textbox, left);
            Canvas.SetTop(textbox, top);
            // MainWindow.firstpage.MultiShell.Text = left.ToString() + " " + top.ToString();
        }
        void Button_Click1(object sender, RoutedEventArgs e)
        {
            // throw new NotImplementedException();
        }

        public Parts_Button()
        {


            Button button = new Button
            {
                Height = 60,
                Width = 148,
                VerticalAlignment = VerticalAlignment.Stretch,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                Background = new SolidColorBrush(Colors.Azure),
                Content = "button",
                ManipulationMode = ManipulationModes.All,
                //button.BorderThickness = BorderThickness.;
            };
            button.ManipulationDelta += textbox_ManipulationDelta;
            button.Click += Button_Click1;
            DataBase dataBase = DataBase.GetInstance();
            var canvas = dataBase.usingTableViewCanvas;
            canvas.Children.Add(button);
            MainWindow.firstpage.MultiShell.Text += "add button";
        }


    }
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NavigationPage_Parts : Page
    {
        public NavigationPage_Parts()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // MainPage.MultiShell.Text += "dd";
            MainWindow.firstpage.MultiShell.Text += "ff";
            Parts_Button parts_Button = new Parts_Button(); 

        }
    }
}
