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

namespace ResetIsland.Pages
{
    /// <summary>
    /// Page2.xaml 的交互逻辑
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            this.Loaded += delegate
            {
                // 时间同步任务
                Task.Run(async () =>
                {
                    while (true)
                    {
                        Dispatcher.Invoke(() => // 使用 UI 线程同步时间
                        {
                            TimeText.Text = DateTime.Now.ToString("HH:mm");
                        });
                        await Task.Delay(10);
                    }
                });
            };
        }
    }
}
