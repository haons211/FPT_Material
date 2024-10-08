using System.Windows;
using System.Windows.Controls;

namespace WPFApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ManageCustomers_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CustomerManagementPage());
        }

        private void ManageRooms_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new RoomManagementPage());
        }

        private void ManageBookings_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new BookingManagementPage());
        }

        private void CreateReport_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ReportPage());
        }
    }
}