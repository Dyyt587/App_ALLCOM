using CommunityToolkit.WinUI.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WinRT;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ALLCOM
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TableViewPage_Main : Page
    {
        public TableViewPage_Main()
        {
            this.InitializeComponent();
        }

        private void Rectangle_DragStarting(UIElement sender, DragStartingEventArgs args)
        {
            MainWindow.firstpage.MultiShell.Text += "DragStarting ";
            args.AllowedOperations = Windows.ApplicationModel.DataTransfer.DataPackageOperation.Move;

        }

        private void Rectangle_DragEnter(object sender, DragEventArgs e)
        {
            MainWindow.firstpage.MultiShell.Text += "DragEnter ";
           

        }

        private void Rectangle_DragLeave(object sender, DragEventArgs e)
        {
            MainWindow.firstpage.MultiShell.Text += "DragLeave ";
            
            //args.Handled = true;

            ////Point point =
            //Point point = btnb.CoordinatesTo(btnb);


            //double x = (double)btnb.GetValue(Canvas.LeftProperty);
            //double y = (double)btnb.GetValue(Canvas.TopProperty);
            //x += point.X - btnb.ActualWidth / 2.0;
            //y += point.Y - btnb.ActualHeight / 2.0;
            // point.X += x;
            // point.Y += y;
            //// Canvas.SetLeft(btnb, point.X);
            //// Canvas.SetTop(btnb, point.Y);
            // MainWindow.firstpage.MultiShell.Text += point.X.ToString();
            // MainWindow.firstpage.MultiShell.Text += " ";
            // MainWindow.firstpage.MultiShell.Text += point.Y.ToString();
            // MainWindow.firstpage.MultiShell.Text += "\n";
        }



        private void btnb_Drop(object sender, DragEventArgs e)
        {
            //MainWindow.firstpage.MultiShell.Text += "btnb_Drop ";

        }
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
            var parent = VisualTreeHelper.GetParent(textbox) as FrameworkElement ;
            if (parent == null) MainWindow.firstpage.MultiShell.Text += "error";
  
            if (left < 0)
            {
                left = 0;
            }
            if(top < 0)
            {
                top = 0;
            }
            if (top+ textbox.ActualSize.Y> parent.Height)
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
    }
}
