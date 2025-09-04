using System.Data;
using System.Data.SqlClient; // Til at arbejde med SQL Server via ADO.NET
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
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient; // Til at arbejde med SQL Server via ADO.NET

namespace ReolMarkedTeam7;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        string? ConnectionString = config.GetConnectionString("DefaultConnection");

        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            MessageBox.Show("Database connection made");

        }


    }
}