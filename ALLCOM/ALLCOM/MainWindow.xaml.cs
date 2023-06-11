using CommunityToolkit.WinUI.UI;
using Microsoft.UI;
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
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ALLCOM
{
    internal class DataList_ItemsDroup
    {
        public ObservableCollection<String> decimalDigits;//显示的小数位数
        public String data = "ttt";//
        public ObservableCollection<SolidColorBrush> ColorOptions; //数据颜色

        public string Data { get => data; set => data = value; }

        public DataList_ItemsDroup(DataBase dataBase)
        {
            if (dataBase != null)
            {
                decimalDigits = dataBase._DecimalDigits;
                ColorOptions = dataBase._ColorOptions;

                Console.WriteLine("debug: DataList_ItemsDroup init");

            }
            else
            {
                Console.WriteLine("error: no database");
                ColorOptions = new ObservableCollection<SolidColorBrush>();
                ColorOptions.Add(new SolidColorBrush(Colors.Black));
                ColorOptions.Add(new SolidColorBrush(Colors.Red));
                ColorOptions.Add(new SolidColorBrush(Colors.Orange));
                ColorOptions.Add(new SolidColorBrush(Colors.Yellow));
                ColorOptions.Add(new SolidColorBrush(Colors.Green));
                ColorOptions.Add(new SolidColorBrush(Colors.Blue));
                ColorOptions.Add(new SolidColorBrush(Colors.Indigo));
                ColorOptions.Add(new SolidColorBrush(Colors.Violet));
                ColorOptions.Add(new SolidColorBrush(Colors.White));
            }

        }
    }
    internal class TableView_DataList
    {
    }
        /// <summary>
        /// An empty window that can be used on its own or navigated to within a Frame.
        /// </summary>
        public sealed partial class MainWindow : Window
    {
        DataBase dataBase = DataBase.GetInstance();
        static int page_index=1;
        ObservableCollection<DataList_ItemsDroup> Items = new ObservableCollection<DataList_ItemsDroup>();
        public static MainWindow firstpage;
        public MainWindow()
        {
            firstpage = this;
            this.InitializeComponent();
            for (int i = 0; i < 20; ++i)
            {
                Items.Add(new DataList_ItemsDroup(dataBase));

            }
            ScrollViewer.SetVerticalScrollBarVisibility(MultiShell, ScrollBarVisibility.Auto);
        }

        private void ComboBox_TextSubmitted(ComboBox sender, ComboBoxTextSubmittedEventArgs e)
        {


            // If the item is invalid, reject it and revert the text.
            // Mark the event as handled so the framework doesn't update the selected item.
            //sender.Text = sender.SelectedValue.ToString();
            e.Handled = true;

        }
        private void BrushButtonClick(object sender, object e)
        {
            // When the button part of the split button is clicked,
            // apply the selected color.
            //ChangeColor();
        }

        private void BrushSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // When the flyout part of the split button is opened and the user selects
            // an option, set their choice as the current color, apply it, then close the flyout.
            //CurrentColorBrush = (SolidColorBrush)e.AddedItems[0];
            //SelectedColorBorder.Background = CurrentColorBrush;
            //ChangeColor();
            //BrushFlyout.Hide();
        }

        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            // Only get results when it was a user typing,
            // otherwise assume the value got filled in by TextMemberPath
            // or the handler for SuggestionChosen.
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                //Set the ItemsSource to be your filtered dataset



                //sender.ItemsSource = dataset;
            }
        }


        private void AutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            // Set sender.Text. You can use args.SelectedItem to build your text string.
        }


        private void AutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            if (args.ChosenSuggestion != null)
            {
                sender.Text = "gdyuwuywgyu\r\nfef 0x2028 ";

                // User selected an item from the suggestion list, take an action on it here.
            }
            else
            {
                // Use args.QueryText to determine what to do.
                sender.Text = "gdyuwuywgyu\r\nfef 0x2028 ";


            }
        }
        // Add a new Tab to the TabView
        private void TabView_AddTabButtonClick(TabView sender, object args)
        {
            var newTab = new TabViewItem();
            newTab.IconSource = new SymbolIconSource() { Symbol = Symbol.Document };

            newTab.Header = "New Tab"+ Convert.ToString(page_index);
            page_index++;

            // The Content of a TabViewItem is often a frame which hosts a page.
            Frame frame = new Frame();
            //frame.Background = Colors.AliceBlue;
            newTab.Content = frame;
            frame.Navigate(typeof(TableViewPage_Main));
            
            sender.TabItems.Add(newTab);
        }

        // Remove the requested tab from the TabView
        private void TabView_TabCloseRequested(TabView sender, TabViewTabCloseRequestedEventArgs args)
        {
            sender.TabItems.Remove(args.Tab);
        }
        private void ChangeColorItem_Click(object sender, RoutedEventArgs e)
        {
            // Change the color from red to blue or blue to red.

        }
        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            // Change the color from red to blue or blue to red.
            //Console.WriteLine("yuwgfdyueg");

        }


        private void NavigationViewControl_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {

            if (args.IsSettingsInvoked)
            {

            }
            else
            {

            }

        }
        private void NavigationViewControl_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            NavigationViewItem Item = args.SelectedItem as NavigationViewItem;

            string itemid = Item.Tag.ToString();

            // The Content of a TabViewItem is often a frame which hosts a page.
            //frame.Background = Colors.AliceBlue;
            // frame.Navigate(typeof(NavigationPage_Link));

            if (Link.Tag.ToString().Equals(itemid))
            {
                Navigation_Frame.Navigate(typeof(NavigationPage_Link));
            }
            else if (Commends.Tag.ToString().Equals(itemid))
            {
                Navigation_Frame.Navigate(typeof(NavigationPage_Cmd));
            }
            else if (Parts.Tag.ToString().Equals(itemid))
            {
                Navigation_Frame.Navigate(typeof(NavigationPage_Parts));
            }
            else { Console.WriteLine("dd"); }
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void MultiShell_TextChanged(object sender, TextChangedEventArgs e)
        {
            // MultiShell.Text += "dd";
            MultiShellScrollViewer.ChangeView(null,double.MaxValue,null);
            MultiShell.SelectionStart = MultiShell.Text.Length;
            MultiShell.SelectionLength = 0;
        }

        private void MultiShell_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            //sender.Text += "tt";
        }
        public  DependencyObject FindDescendantByName( DependencyObject element, string name)
        {
            if (element == null || string.IsNullOrEmpty(name))
            {
                return null;
            }

            if (element is FrameworkElement fe && fe.Name == name)
            {
                return element;
            }

            int count = VisualTreeHelper.GetChildrenCount(element);
            for (int i = 0; i < count; i++)
            {
                var child = VisualTreeHelper.GetChild(element, i);
                var result = FindDescendantByName(child, name);
                if (result != null)
                {
                    return result;
                }
            }

            return null;
        }
        private void MainTableView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            var dd = sender as TabView;
            DataBase instance = DataBase.GetInstance();
            var page = dd.SelectedItem as TabViewItem; if (page != null) { }
            var frame = page.Content as Frame;
            var page1 = frame.Content as Page;
            var TableViewPageScrollViewer = page1.FindDescendant<ScrollViewer>() ;
            var TableViewCanvas = TableViewPageScrollViewer.FindDescendant<Canvas>() ;
            instance.usingTablePage = page;
            instance.usingTableViewCanvas = TableViewCanvas;

            if (instance.usingTablePage == null) MainWindow.firstpage.MultiShell.Text += "page is null ";
            if (TableViewCanvas == null) MainWindow.firstpage.MultiShell.Text += "TableViewCanvas is null ";
            if (TableViewPageScrollViewer == null) MainWindow.firstpage.MultiShell.Text += "TableViewPageScrollViewer is null ";

        }
    }
}
