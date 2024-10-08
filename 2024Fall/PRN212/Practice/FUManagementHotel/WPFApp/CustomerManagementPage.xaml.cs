using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using BusinessObjects;

namespace WPFApp
{
    public partial class CustomerManagementPage : Page
    {
        public ObservableCollection<Customer> Customers { get; set; }
        private ObservableCollection<Customer> _allCustomers;
        private Customer _selectedCustomer;

        public CustomerManagementPage()
        {
            InitializeComponent();
            Customers = new ObservableCollection<Customer>
            {
                new Customer { Id = 1, Name = "John Doe", Email = "john@example.com", PhoneNumber = "1234567890", CustomerBirthday = new DateTime(1990, 1, 1) },
                new Customer { Id = 2, Name = "Jane Smith", Email = "jane@example.com", PhoneNumber = "0987654321", CustomerBirthday = new DateTime(1992, 2, 2) }
            };
            _allCustomers = new ObservableCollection<Customer>(Customers);
            CustomerDataGrid.ItemsSource = Customers;
        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            _selectedCustomer = null;
            ShowPopup();
        }

        private void UpdateCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (CustomerDataGrid.SelectedItem is Customer selectedCustomer)
            {
                _selectedCustomer = selectedCustomer;
                ShowPopup(selectedCustomer);
            }
        }

        private void DeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (CustomerDataGrid.SelectedItem is Customer selectedCustomer)
            {
                var result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    Customers.Remove(selectedCustomer);
                    _allCustomers.Remove(selectedCustomer);
                }
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var searchText = SearchTextBox.Text.ToLower();
            var filteredCustomers = _allCustomers.Where(c => c.Name.ToLower().Contains(searchText)).ToList();
            Customers.Clear();
            foreach (var customer in filteredCustomers)
            {
                Customers.Add(customer);
            }
        }

        private void SearchTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SearchTextBox.Text == "Search...")
            {
                SearchTextBox.Text = string.Empty;
                SearchTextBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void SearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                SearchTextBox.Text = "Search...";
                SearchTextBox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void ShowPopup(Customer customer = null)
        {
            if (customer != null)
            {
                PopupName.Text = customer.Name;
                PopupEmail.Text = customer.Email;
                PopupPhoneNumber.Text = customer.PhoneNumber;
                PopupBirthday.SelectedDate = customer.CustomerBirthday;
            }
            else
            {
                PopupName.Text = string.Empty;
                PopupEmail.Text = string.Empty;
                PopupPhoneNumber.Text = string.Empty;
                PopupBirthday.SelectedDate = null;
            }
            CustomerPopup.IsOpen = true;
        }

        private void SaveCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedCustomer == null)
            {
                var newCustomer = new Customer
                {
                    Id = Customers.Count + 1,
                    Name = PopupName.Text,
                    Email = PopupEmail.Text,
                    PhoneNumber = PopupPhoneNumber.Text,
                    CustomerBirthday = PopupBirthday.SelectedDate ?? DateTime.Now
                };
                Customers.Add(newCustomer);
                _allCustomers.Add(newCustomer);
            }
            else
            {
                _selectedCustomer.Name = PopupName.Text;
                _selectedCustomer.Email = PopupEmail.Text;
                _selectedCustomer.PhoneNumber = PopupPhoneNumber.Text;
                _selectedCustomer.CustomerBirthday = PopupBirthday.SelectedDate ?? DateTime.Now;
                CustomerDataGrid.Items.Refresh();
            }
            CustomerPopup.IsOpen = false;
        }

        private void CancelCustomer_Click(object sender, RoutedEventArgs e)
        {
            CustomerPopup.IsOpen = false;
        }
    }
}