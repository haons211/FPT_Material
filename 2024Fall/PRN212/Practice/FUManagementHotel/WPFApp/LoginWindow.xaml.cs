using BusinessObjects;
using Services;
using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Extensions.Configuration;

namespace WPFApp;

public partial class LoginWindow : Window
{
    private readonly IConfiguration _configuration;
    public LoginWindow()
    {
        InitializeComponent();
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        _configuration = builder.Build();
    }
    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
        string email = txtUserName.Text;
        string password = txtPassWord.Password;

        // Read admin account details from appsettings.json
        string defaultAdminEmail = _configuration["DefaultAdminAccount:Email"];
        string defaultAdminPassword = _configuration["DefaultAdminAccount:Password"];

        if (email == defaultAdminEmail && password == defaultAdminPassword)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
        else
        {
            CustomerWindow customerWindow = new CustomerWindow();
            customerWindow.Show();
        }
        this.Close();
        
        
    }
}