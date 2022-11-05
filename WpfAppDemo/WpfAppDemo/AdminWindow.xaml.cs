using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using WpfAppDemo.Classess;

namespace WpfAppDemo
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void Button_Shutdown_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }
     
        private void Boreder_Move_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BEnd_Click(object sender, RoutedEventArgs e)
        {
            if (CBAdmin.Text == "Заказы")
            {
                try
                {
                    var row_list = (OrderModel)DataGrid_ShowInfo.SelectedValue;

                }
                catch
                {
                    MessageBox.Show("Не выбран элемент изменения");
                    return;
                }
                try
                {
                    var lo = (OrderModel)DataGrid_ShowInfo.SelectedValue;
                    DataTable obj = querty($"UPDATE OrderModel SET Order_composition = '{lo.Order_composition}', Order_date = '{lo.Order_date}', Delivery_date = '{lo.Delivery_date}',point_of_issue = '{lo.Point_of_issue}', userName = '{lo.UserName}',code_to_get = '{lo.Code_to_get}',status_Order = '{lo.Status_Order}'  WHERE id = {lo.Id} ");

                }
                catch
                {
                    MessageBox.Show("Изменение не успешно, проверте правильность вводимых данных");
                    return;
                }
            }
            else if (CBAdmin.Text == "Товары")
            {
                try
                {
                    var row_list = (Perfume)DataGrid_ShowInfo.SelectedValue;

                }
                catch
                {
                    MessageBox.Show("Не выбран элемент изменения");
                    return;
                }
                try
                {
                    var lo = (Perfume)DataGrid_ShowInfo.SelectedValue;
                    DataTable obj = querty($"UPDATE Perfume SET Product_сategory = '{lo.Product_category}', Current_discount = '{lo.Current_discount}', Quantity_in_stock = '{lo.Quantity_in_stock}',Description = '{lo.Description}', Image_Ico = '{lo.Image}' WHERE id = {lo.Id} ");

                }
                catch
                {
                    MessageBox.Show("Изменение не успешно, проверте правильность вводимых данных");
                    return;
                }
            }
           
         
        }

        bool flag = false;

        private void BUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (flag == false)
            {
                BUpdate.Background = Brushes.Pink;
                DataGrid_ShowInfo.IsReadOnly = false;
            }
            else
            {
                BUpdate.Background = Brushes.LightGreen;
                DataGrid_ShowInfo.IsReadOnly = true;
            }
            flag = !flag;
            DataGrid_ShowInfo.Columns[0].IsReadOnly = true;
        }

        DBConnection database = new DBConnection();

        DataTable querty(string querty)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand(querty, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return table;
            }
        }

        public void RefreshInfoGoods()
        {
            DataTable obj = querty($"SELECT * FROM Perfume");
            var listStaff = new List<OrderModel>();
            var set = 0;
            while (set < obj.Rows.Count)
            {
                var staff = new OrderModel(Convert.ToInt32(obj.Rows[set][0]), Convert.ToString(obj.Rows[set][1]), Convert.ToDateTime(obj.Rows[set][2]), Convert.ToDateTime(obj.Rows[set][3]), Convert.ToInt32(obj.Rows[set][4]), Convert.ToString(obj.Rows[set][5]), Convert.ToString(obj.Rows[set][6]), Convert.ToString(obj.Rows[set][7]));
                listStaff.Add(staff);
                set++;
            }
            DataGrid_ShowInfo.ItemsSource = listStaff;
        }

        public void RefreshInfoOrder()
        {
            DataTable obj = querty($"SELECT * FROM OrderModel");
            var listStaff = new List<OrderModel>();
            var set = 0;
            while (set < obj.Rows.Count)
            {
                var staff = new OrderModel(Convert.ToInt32(obj.Rows[set][0]), Convert.ToString(obj.Rows[set][1]), Convert.ToDateTime(obj.Rows[set][2]), Convert.ToDateTime(obj.Rows[set][3]), Convert.ToInt32(obj.Rows[set][4]), Convert.ToString(obj.Rows[set][5]), Convert.ToString(obj.Rows[set][6]), Convert.ToString(obj.Rows[set][7]));
                listStaff.Add(staff);
                set++;
            }
            DataGrid_ShowInfo.ItemsSource = listStaff;
        }

        private void BEnter_Click(object sender, RoutedEventArgs e)
        {
            if(CBAdmin.Text == "Заказы")
            {
                RefreshInfoOrder();
            }
            else if(CBAdmin.Text == "Товары")
            {
                RefreshInfoGoods();           
            }
        }

        private void CBAdmin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid_ShowInfo.ItemsSource = null;
        }
    }
}
