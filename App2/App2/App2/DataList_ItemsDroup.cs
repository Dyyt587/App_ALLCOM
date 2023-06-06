using Microsoft.UI;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace App_ALLCOM
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
                //ColorOptions.Add(new SolidColorBrush(Colors.Black));
                //ColorOptions.Add(new SolidColorBrush(Colors.Red));
                //ColorOptions.Add(new SolidColorBrush(Colors.Orange));
                //ColorOptions.Add(new SolidColorBrush(Colors.Yellow));
                //ColorOptions.Add(new SolidColorBrush(Colors.Green));
                //ColorOptions.Add(new SolidColorBrush(Colors.Blue));
                //ColorOptions.Add(new SolidColorBrush(Colors.Indigo));
                //ColorOptions.Add(new SolidColorBrush(Colors.Violet));
                //ColorOptions.Add(new SolidColorBrush(Colors.White));
                //for (int i = 0; i < 17; ++i)
                //{
                //    dataBase._DecimalDigits.Add(Convert.ToString(i));

                //}
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


            //for (int i = 0; i < 18; ++i)
            //{
            //    decimalDigits.Add(Convert.ToString(i));

            //}
            /*            dataItems.Add("tt0");
                        dataItems.Add("tt0");
                        dataItems.Add("tt0");
                        dataItems.Add("tt0");
                        dataItems.Add("tt0");
                        dataItems.Add("tt0");
                        dataItems.Add("tt0");*/
        }
        //ObservableCollection<String> DecimalDigits()
        //{
        //    return decimalDigits;
        //}
        //ObservableCollection<String> DataItems()
        //{
        //    return dataItems;
        //}
        //ObservableCollection<Color> ColorOptions()
        //{
        //    return colorOptions;
        //}

    }
}
