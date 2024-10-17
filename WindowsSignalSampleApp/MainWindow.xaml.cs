using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WindowsSignalSampleApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Monitor monitor = new Monitor();
            monitor.Show();
        }
        private void UpdateValue(string parameter)
        {
        }
        private void ChangingParameter(object sender, RoutedEventArgs e)
        {
            // Note: Task.Run()はスレッドの使いまわし？それとも作っては捨ててる？
            Task.Run(() =>
            {
                this.Dispatcher.Invoke((Action)(() =>
                {
                    string parameter = "";
                    UpdateValue(parameter);
                }));
            });
        }
    }
}
