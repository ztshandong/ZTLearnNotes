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
using System.Windows.Shapes;
using DevExpress.Xpf.Ribbon;


namespace WPF
{
    /// <summary>
    /// Interaction logic for DXRibbonWindow1.xaml
    /// </summary>
    public partial class DXRibbonWindow1 : DXRibbonWindow
    {
        public DXRibbonWindow1()
        {
            InitializeComponent();
        }

        private void dxrwin_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (RibbonPageGroup pg in ribbonPage1.Groups)
            {
                if (pg.Items.Count <= 0) pg.IsVisible=false;
            }
        }
    }
}
