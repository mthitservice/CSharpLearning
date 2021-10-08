using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SQLFensterAnwendung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Server;
        string Benutzer;
        string Passwort;
        public MainWindow()
        {
            InitializeComponent();
            Server = ConfigurationManager.AppSettings.Get("SQLServer");
            Benutzer = ConfigurationManager.AppSettings.Get("SQLServerBenutzer");
            Passwort = ConfigurationManager.AppSettings.Get("SQLServerPasswort");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // SQL Verindung
            // Öffnen der Verbindung
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = Server;
            builder.UserID = Benutzer;
            builder.Password = Passwort;
            builder.InitialCatalog = "dbCanon";
            txt_Connection.Text = builder.ConnectionString;
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {

                // Senden einer Anweisung (Command)
                using (SqlCommand command = new SqlCommand(txt_SQL.Text, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader= command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txt_Result.Text += txt_Result.Text += reader.GetInt32(0).ToString()+ " ; " +reader.GetString(1);

                        }

                    }



                }

            }
            // Schließen der Verbindung

        }
    }
}
