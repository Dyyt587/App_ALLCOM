using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace App2
{
    public class LinkItemsDatas
    {
        public string Text = "ee";
        //public ICommand Command { get; set; }
    }

    public sealed partial class NavigationPage_Link : Page
    {
        public ObservableCollection<String> BoudDatas = new ObservableCollection<String>();
        public ObservableCollection<String> LinkDatas = new ObservableCollection<String>();
        public ObservableCollection<String> DataLengthDatas = new ObservableCollection<String>();
        public ObservableCollection<String> VerifyDatas = new ObservableCollection<String>();
        public ObservableCollection<String> FluidControlDatas = new ObservableCollection<String>();

        public ObservableCollection<String> LinkItemsData = new ObservableCollection<String>();

        public NavigationPage_Link()
        {
            BoudDatas.Add(Convert.ToString(9600));
            BoudDatas.Add(Convert.ToString(115200));
            BoudDatas.Add(Convert.ToString(921600));

            LinkDatas.Add("UART COM1");
            LinkDatas.Add("UART COM5");
            LinkDatas.Add("UART COM6");
            LinkDatas.Add("UART COM9");

            DataLengthDatas.Add(Convert.ToString(8));
            DataLengthDatas.Add(Convert.ToString(7));
            DataLengthDatas.Add(Convert.ToString(6));
            DataLengthDatas.Add(Convert.ToString(5));

            VerifyDatas.Add(Convert.ToString(1));
            VerifyDatas.Add(Convert.ToString(1 / 2));
            VerifyDatas.Add(Convert.ToString(2));

            FluidControlDatas.Add("none");
            FluidControlDatas.Add("hard");
            FluidControlDatas.Add("soft");

            LinkItemsData.Add("COM12 CH340-USB 新办法");
            LinkItemsData.Add("COM12 CH340");

            this.InitializeComponent();
        }
        private void ComboBox_TextSubmitted_boud(ComboBox sender, ComboBoxTextSubmittedEventArgs args)
        {

        }

        private void ShowMenu(bool isTransient)
        {
            FlyoutShowOptions myOption = new FlyoutShowOptions();
            myOption.ShowMode =  FlyoutShowMode.Transient ;
            CommandBarFlyout1.ShowAt(ListViewLink, myOption);
        }


        private void MyImageButton_Click(object sender, RoutedEventArgs e)
        {
            // Show a context menu in transient mode
            // Focus will not move to the menu
            ShowMenu(true);
        }

        private void ListViewLink_ContextRequested(UIElement sender, ContextRequestedEventArgs args)
        {
            // Show a context menu in standard mode
            // Focus will move to the menu
            //ShowMenu(true);

            ShowMenu(false);
        }

        private void OnElementClicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
