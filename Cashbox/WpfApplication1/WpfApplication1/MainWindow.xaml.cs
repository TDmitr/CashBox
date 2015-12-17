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

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public struct MyData
        {
            public int id { set; get; }
            public string title { set; get; }
            public int jobint { set; get; }
        }
        public MainWindow()
        {
            InitializeComponent();
            DataGridTextColumn col1 = new DataGridTextColumn();
            DataGridTextColumn col2 = new DataGridTextColumn();
            DataGridTextColumn col3 = new DataGridTextColumn();
            DataGridTextColumn col4 = new DataGridTextColumn();
            DataGridTextColumn col5 = new DataGridTextColumn();
            myDataGrid.Columns.Add(col1);
            myDataGrid.Columns.Add(col2);
            myDataGrid.Columns.Add(col3);
            myDataGrid.Columns.Add(col4);
            myDataGrid.Columns.Add(col5);
            col1.Binding = new Binding("id");
            col2.Binding = new Binding("title");
            col3.Binding = new Binding("jobint");
            col4.Binding = new Binding("lastrun");
            col5.Binding = new Binding("nextrun");
            col1.Header = "ID";
            col2.Header = "title";
            col3.Header = "jobint";
            col4.Header = "lastrun";
            col5.Header = "nextrun";

            myDataGrid.Items.Add(new MyData { id = 1, title = "Test", jobint = 2 });
            myDataGrid.Items.Add(new MyData { id = 12, title = "Test2", jobint = 24 });
        }
    }
}
