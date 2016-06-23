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
using DevExpress.Xpf.Core;
using System.Data;
using ZTERP.CommonClass;

namespace WPF
{
    /// <summary>
    /// Interaction logic for DXWindow3.xaml
    /// </summary>
    public partial class DXWindow3 : DXWindow
    {
        public DXWindow3()
        {
            InitializeComponent();
        }

        private void xw1_Loaded(object sender, RoutedEventArgs e)
        {
            PropertyGrid1.SelectedObject = pg;
            DataTable dt = CommonClass.GetTable();
            pe.DataContext = dt;
            
            pg.DataSource = dt;
            
            
            for (int i = 0; i < 10; i++)
            {
                //ColumnDefinition col = new ColumnDefinition();
                //col.Name = "col" + i;
                //grid1.ColumnDefinitions.Add(col);
                //RowDefinition row = new RowDefinition();
                //col.Name = "row" + i;
                //grid1.RowDefinitions.Add(row);
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //SimpleButton btn = new SimpleButton();
                    //btn.Content = i + "," + j;
                    //Grid.SetRow(btn,i);
                    //Grid.SetColumn(btn,j);

                    //grid1.Children.Add(btn);
                    Image img = new Image();
                    img.Source = new BitmapImage(new Uri("1.jpg",UriKind.Relative));
                    Grid.SetRow(img, i);
                    Grid.SetColumn(img, j);

                    //grid1.Children.Add(img);
                }
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            PropertyGrid1.SelectedObject = btn1;
            progrid.SelectedObject = btn1;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            PropertyGrid1.SelectedObject = btn2;
            progrid.SelectedObject = btn2;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            PropertyGrid1.SelectedObject = btn3;
            progrid.SelectedObject = btn3;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            PropertyGrid1.SelectedObject = btn4;
            progrid.SelectedObject = btn4;
        }

        private void pg_GotFocus(object sender, RoutedEventArgs e)
        {
            PropertyGrid1.SelectedObject = pg;
            progrid.SelectedObject = pg;
        }
    }
}
