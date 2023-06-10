using Microsoft.UI.Xaml.Media;
using Microsoft.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ALLCOM
{
    internal class DataBase
    {
        public ObservableCollection<SolidColorBrush> _ColorOptions; //数据颜色
        public ObservableCollection<String> _DecimalDigits;
        private static DataBase instance = null;

        // 定义一个静态变量来保存类的实例

        // 定义一个标识确保线程同步
        private static readonly object locker = new object();

        // 定义私有构造函数，使外界不能创建该类实例
        private DataBase()
        {



        }
        public static DataBase GetInstance()
        {
            // 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
            // 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
            // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
            // 双重锁定只需要一句判断就可以了
            if (instance == null)
            {
                lock (locker)
                {
                    // 如果类的实例不存在则创建，否则直接返回
                    if (instance == null)
                    {
                        instance = new DataBase();
                        instance._ColorOptions = new ObservableCollection<SolidColorBrush>();//数据颜色
                        instance._DecimalDigits = new ObservableCollection<String>();//显示的小数位数

                        instance._ColorOptions.Add(new SolidColorBrush(Colors.Black));
                        instance._ColorOptions.Add(new SolidColorBrush(Colors.Red));
                        instance._ColorOptions.Add(new SolidColorBrush(Colors.Orange));
                        instance._ColorOptions.Add(new SolidColorBrush(Colors.Yellow));
                        instance._ColorOptions.Add(new SolidColorBrush(Colors.Green));
                        instance._ColorOptions.Add(new SolidColorBrush(Colors.Blue));
                        instance._ColorOptions.Add(new SolidColorBrush(Colors.Indigo));
                        instance._ColorOptions.Add(new SolidColorBrush(Colors.Violet));
                        instance._ColorOptions.Add(new SolidColorBrush(Colors.White));
                        for (int i = 0; i < 18; ++i)
                        {
                            instance._DecimalDigits.Add(Convert.ToString(i));

                        }

                    }
                }
            }
            return instance;
        }
    }
}

