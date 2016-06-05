using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using ZTERP.CommonClass;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            btnTest.Visibility = Visibility.Hidden;
            //gcSummary.DataContext = Common.GetTable();
            // gcSummary.ItemsSource= Common.GetTable();
            //simpleButton.Background = new SolidColorBrush(Colors.Red);
        }

        private void simpleButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(simpleButton.Width.ToString());
        }

        private void btnFirstbtn_Click(object sender, RoutedEventArgs e)
        {
            DXWindow1 dxw = new DXWindow1();
            dxw.ShowDialog();
        }
    }
}
