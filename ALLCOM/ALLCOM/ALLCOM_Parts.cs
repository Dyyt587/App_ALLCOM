using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALLCOM
{
    class ALLCOM_PartsBase { 
        public string Name { get; set; }
        public Grid grid { get; set; }
        public Button button;
        public object content;
        Thickness Thickness;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // MainPage.MultiShell.Text += "dd";
            MainWindow.firstpage.MultiShell.Text += "ff";

        }
        protected ALLCOM_PartsBase(){
            Thickness.Left = 0;
            Thickness.Right = 0;
            Thickness.Top = 0;
            Thickness.Bottom = 0;
            grid = new Grid();
            button = new Button
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Background = Brush.FromAbi((IntPtr)0xfbfbfb),
                BorderThickness = Thickness,
                Width = 100,
                Height = 100,
                //Click = Button_Click,
            };

            //HorizontalAlignment = "Stretch" VerticalAlignment = "Stretch" Background = "Azure" BorderThickness = "0" Click = "Button_Click"

            grid.Children.Add(button);


        }
    }
    class ALLCOM_Parts : ALLCOM_PartsBase
    {
        ALLCOM_Parts() { 
        
        }
    }
}
