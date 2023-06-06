using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.ObjectModel;
using Windows.Devices.Enumeration;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace App_ALLCOM
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        DataBase dataBase = DataBase.GetInstance();

        ObservableCollection<DataList_ItemsDroup> Items = new ObservableCollection<DataList_ItemsDroup>();

        public MainWindow()
        {
            this.InitializeComponent();
           // this.ExtendsContentIntoTitleBar = true;  // enable custom titlebar
           // this.SetTitleBar(AppTitleBar);      // set user ui element as titlebar


            Items.Add(new DataList_ItemsDroup(dataBase));
            Items.Add(new DataList_ItemsDroup(dataBase));
            Items.Add(new DataList_ItemsDroup(dataBase));

        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            //myButton.Content = "Clicked";
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
                // User selected an item from the suggestion list, take an action on it here.
            }
            else
            {
                // Use args.QueryText to determine what to do.
            }
        }
        // Add a new Tab to the TabView
        private void TabView_AddTabButtonClick(TabView sender, object args)
        {
            var newTab = new TabViewItem();
            newTab.IconSource = new SymbolIconSource() { Symbol = Symbol.Document };
            newTab.Header = "New Document";

            // The Content of a TabViewItem is often a frame which hosts a page.
            Frame frame = new Frame();
            newTab.Content = frame;
            //frame.Navigate(typeof(Page1));

            sender.TabItems.Add(newTab);
        }

        // Remove the requested tab from the TabView
        private void TabView_TabCloseRequested(TabView sender, TabViewTabCloseRequestedEventArgs args)
        {
            sender.TabItems.Remove(args.Tab);
        }

    }
}
