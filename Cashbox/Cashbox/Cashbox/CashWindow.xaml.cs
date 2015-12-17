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
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;

namespace Cashbox
{
    /// <summary>
    /// Логика взаимодействия для CashWindow.xaml
    /// </summary>
    public partial class CashWindow : Window
    {
        private string connStr = "server=localhost; user=root; database=kassa; port=3306; password=;";
        public struct MyData
        {
            public int id { set; get; }
            public string title { set; get; }
            public int jobint { set; get; }
        }

        public CashWindow()
        {
            DataGridTextColumn col1 = new DataGridTextColumn();
            DataGridTextColumn col2 = new DataGridTextColumn();
            DataGridTextColumn col3 = new DataGridTextColumn();
            DataGridTextColumn col4 = new DataGridTextColumn();
            DataGridTextColumn col5 = new DataGridTextColumn();
            GridProductsPay.Columns.Add(col1);
           GridProductsPay.Columns.Add(col2);
           GridProductsPay.Columns.Add(col3);
           GridProductsPay.Columns.Add(col4);
            GridProductsPay.Columns.Add(col5);
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

           GridProductsPay.Items.Add(new MyData { id = 1, title = "Test", jobint = 2 });
            GridProductsPay.Items.Add(new MyData { id = 12, title = "Test2", jobint = 24 });
            InitializeComponent();
        }



        public void DeleteAll()
        {
            try
            {
                string insertRowQuery = "DELETE from checkinfo where ch is null";
                MySqlConnection connection = new MySqlConnection(connStr);


                MySqlCommand QueryCom = new MySqlCommand(insertRowQuery, connection);
                MySqlDataReader MyReader2;
                connection.Open();
                MyReader2 = QueryCom.ExecuteReader();
                connection.Close();

                PrintTable("checkinfo", "product,price,amount,sum", connection, GridProductsPay);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void PrintTable(string table, string col, MySqlConnection connection, DataGrid dataGrid)
        {

            string selectQuery = "SELECT " + col + " FROM " + table + ";"; // Строка запрос
            MySqlCommand sqlCom = new MySqlCommand(selectQuery, connection);
            connection.Open();
            sqlCom.ExecuteNonQuery();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCom);
            DataTable dt = new DataTable(table);
            dataAdapter.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            dataAdapter.Update(dt);
            connection.Close();
        }

        private void AddButton_OnClick(object sender, RoutedEventArgs e)
        {
            //string query = "select id from kassa.products where id=1;";
            //MySqlConnection connection = new MySqlConnection(connStr);


            //MySqlCommand QueryCom = new MySqlCommand(query, connection);
            //MySqlDataReader MyReader2;
            //connection.Open();
            //MyReader2 = QueryCom.ExecuteReader();

            //connection.Close();

            //connection.Open();
            //int id = (int)QueryCom.ExecuteScalar();
            //connection.Close();
            //Products product = (new Products("Milk", id, 2.31));
            var data = new CheckItems
            {
                Amount = 1,
                Id = 2,
                Price = 3,
                Product = "Milk",
                Sum = 2
            };
            GridProductsPay.Items.Add(new CheckItems {Amount = 1, Id = 1, Price = 2.2, Product = "Milk", Sum = 2.2});






            //if (GridProducts.SelectedItems.Count == 0) MessageBox.Show("Select product in table");
            //else
            //{
            //    try
            //    {
            //        var prodName = ((DataRowView)GridProducts.SelectedItems[0]).Row["name"].ToString();
            //        var prodPrice = ((DataRowView)GridProducts.SelectedItems[0]).Row["price"].ToString();
            //        var prodAmount = double.Parse(AmountBox.Text);
            //        var doublePrice = double.Parse(prodPrice);
            //        var prodSum = doublePrice * prodAmount;

            //        string insertRowQuery = "insert into checkinfo(product, amount, sum, price) values('" + prodName + "','" + prodAmount + "','" + prodSum + "','" + doublePrice + "');";
            //        MySqlConnection connection = new MySqlConnection(connStr);


            //        MySqlCommand QueryCom = new MySqlCommand(insertRowQuery, connection);
            //        MySqlDataReader MyReader2;
            //        connection.Open();
            //        MyReader2 = QueryCom.ExecuteReader();
            //        connection.Close();
            //        PrintTable("checkinfo", "product,price,amount,sum", connection, GridProductsPay);



            //        string getQuery = "select sum(sum) from kassa.checkinfo;";

            //        MySqlCommand sqlCom = new MySqlCommand(getQuery, connection);
            //        connection.Open();
            //        sqlCom.ExecuteNonQuery();
            //        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCom);
            //        DataTable dt = new DataTable();
            //        dataAdapter.Fill(dt);
            //        var myData = dt.Select();
            //        var record = myData[0].ItemArray[0];
            //        string recString = record.ToString();
            //        if (recString == string.Empty)
            //        {
            //            recString = "0";
            //        }
            //        TotalPrice.Text = recString;
            //        connection.Close();

            //    }
            //    catch (Exception exception)
            //    {
            //        MessageBox.Show(exception.ToString());
            //    }

            //}


        }

        private void CashWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DeleteAll();
                MySqlConnection connection = new MySqlConnection(connStr);
                PrintTable("products", "*", connection, GridProducts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GridProducts_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GridProducts.SelectedItems.Count == 0) return;
            var clientName = ((DataRowView)GridProducts.SelectedItems[0]).Row["id"].ToString();
            IdBox.Text = clientName;
        }

        private void Logout_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void IdBox_Search_OnKeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                if (IdBox_Search.Text != string.Empty)
                {
                    try
                    {
                        string selectById = "SELECT * FROM products WHERE id =" + int.Parse(IdBox_Search.Text) + ";";
                        MySqlConnection connection = new MySqlConnection(connStr);
                        MySqlCommand sqlCom = new MySqlCommand(selectById, connection);
                        connection.Open();
                        sqlCom.ExecuteNonQuery();
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCom);
                        DataTable dt = new DataTable("Products");
                        dataAdapter.Fill(dt);
                        GridProducts.ItemsSource = dt.DefaultView;
                        dataAdapter.Update(dt);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Id does not exist");
                    }
                }
                else
                {
                    MessageBox.Show("TexBox is empty");
                }
            }
           
        }

        private void Discard_OnClick(object sender, RoutedEventArgs e)
        {
            DeleteAll();
        }

        private void Undo_OnClick(object sender, RoutedEventArgs e)
        {
            string insertRowQuery = "delete from kassa.checkinfo where number = last_insert_id();";
            MySqlConnection connection = new MySqlConnection(connStr);


            MySqlCommand QueryCom = new MySqlCommand(insertRowQuery, connection);
            MySqlDataReader MyReader2;
            connection.Open();
            MyReader2 = QueryCom.ExecuteReader();
            connection.Close();

            PrintTable("checkinfo", "product,price,amount,sum", connection, GridProductsPay);
        }

        private void Refresh_OnClick(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connStr);
            PrintTable("products", "*", connection, GridProducts);

        }
    }
}
