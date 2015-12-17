using System;
using System.Collections.Generic;
using System.Data;
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

namespace Cashbox
{
    /// <summary>
    /// Логика взаимодействия для PrintCheck.xaml
    /// </summary>
    public partial class PrintCheck : Window
    {
        public PrintCheck()
        {
            InitializeComponent();
        }
        private string connStr = "server=localhost; user=root; database=kassa; port=3306; password=;";

        private void PrintCheck_OnLoaded(object sender, RoutedEventArgs e)
        {
            CashWindow cash = new CashWindow();
            TotalResult.Text = cash.TotalPrice.Text;

            string getQuery = "select count(*) from kassa.checkinfo;";
            MySqlConnection connection = new MySqlConnection(connStr);
            MySqlCommand sqlCom = new MySqlCommand(getQuery, connection);
            connection.Open();
            sqlCom.ExecuteNonQuery();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCom);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            var myData = dt.Select();
            var record = myData[0].ItemArray[0];
            string recString = record.ToString();
            if (recString == string.Empty)
            {
                recString = "0";
            }
            NumberResult.Text = recString;
            connection.Close();


        }

        private void PABox_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (PABox.Text != string.Empty)
                {
                    if (double.Parse(PABox.Text) >= double.Parse(TotalResult.Text))
                    {
                        double a = double.Parse(PABox.Text);
                        double b = double.Parse(TotalResult.Text);
                        MessageBox.Show("Change:" + (a - b));
                    }
                    else
                    {
                        MessageBox.Show("Not enough funds for payment");
                    }
                }
                else
                {
                    MessageBox.Show("Field is empty");
                }
            }
        }

        private void Pay_OnClick(object sender, RoutedEventArgs e)
        {
            if (PABox.Text != string.Empty)
            {
                if (double.Parse(PABox.Text) >= double.Parse(TotalResult.Text))
                {
                    double a = double.Parse(PABox.Text);
                    double b = double.Parse(TotalResult.Text);
                    MessageBox.Show("Change:" + (a - b));
                }
                else
                {
                    MessageBox.Show("Not enough funds for payment");
                }
            }
            else
            {
                MessageBox.Show("Field is empty");
            }
        }
    }
}
