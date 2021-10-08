using SQLFensterAnwendung.Models;
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
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Threading;

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
            Progress1.Maximum = 100;
            Progress1.Value = 0;
         


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // THreadverwaltung instanziieren

            BackgroundWorker worker;
            Progress1.Value = 0;
            List<string> IpList = new List<string>() { "ftp.dlptest.com", "217.160.26.87", "192.168.1.1", "google.de", "bing.de" ,"canon.de"};
          

            //max = IpList.Count;
            foreach (var s in IpList)
            {
                worker= new BackgroundWorker();
                worker.WorkerReportsProgress = true;
                worker.DoWork += Worker_DoWork;
                worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
                Progress1.Maximum = IpList.Count();

                IPInfo i = new IPInfo();
                i.ip=s;
                i.TestPort = 21;
                // Weil ein Objektarray übergeben werden muss
                object[] parameters = new object[] { i };
                worker.RunWorkerAsync(parameters);
                   
              }


          





            return;



            // SQL Verindung
            // Öffnen der Verbindung
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = Server;
            builder.UserID = Benutzer;
            builder.Password = Passwort;
            builder.InitialCatalog = "dbCanon";
            txt_Connection.Text = builder.ConnectionString;

          zugriffueberEF();
            return;
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

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            IPInfo i = (IPInfo)e.Result;
            // Text wird ausgegeben weil in Klasse toString überladen ist
            lbResults.Items.Add(i);
            Progress1.Value++;
        }



        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {   //für zwei Prozesse (IP und port Prüfung)



            object[] parameters = e.Argument as object[];

            IPInfo adresse = ((IPInfo)parameters[0]);

            adresse.ttl = Ping(adresse.ip);

            if (adresse.ttl >= 0) { 
            adresse.portchechk = IsPortOpen(adresse.ip, adresse.TestPort, 10);
        }
           
            e.Result = adresse; 
           
            
            

        }

      


    public static bool IsPortOpen(string host, int port, int timeoutInSeconds)
    {
        try
        {
            TimeSpan timeout = new TimeSpan(0, 0, timeoutInSeconds);
            using (var client = new System.Net.Sockets.TcpClient())
            {
                var result = client.BeginConnect(host, port, null, null);
                var success = result.AsyncWaitHandle.WaitOne(timeout);
                if (!success)
                    return false;
                client.EndConnect(result);
            }
        }
        catch
        {
            return false;
        }
        return true;
    }

    public static long Ping(string hostName, int timeout = 5000, int retrys = 0)
    {

        long retVal = -1;
        for (int i = 0; i <= retrys; i++)
        {
            //logV("PingTryNr." + i);
            try
            {
                Ping pingSender = new Ping();
                PingOptions options = new PingOptions();
                // Use the default Ttl value which is 128,
                // but change the fragmentation behavior.
                options.DontFragment = true;
                // Create a buffer of 32 bytes of data to be transmitted.
                string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);

                PingReply reply = pingSender.Send(hostName, timeout, buffer, options);
                if (reply.Status == IPStatus.Success)
                {
                    //Debug.Print("Host: " + hostName);
                    //Debug.Print(reply.Status.ToString());
                    retVal = reply.RoundtripTime;
                }
            }
            catch (PingException e)
            {
                retVal = -1;
            }
            catch (Exception e)
            {
                retVal = -1;
                //Debug.Print(ex.Message);
            }
            if (retVal != -1)
            {
                break;
            }
        }

        return retVal;
    }




    public void zugriffueberEF()
        {

            var context = new dbCanonContext();
            var Adressen = context.Addresses.ToList();
            // Parametrisierter Aufruf
            int? id = 185;
           
            var ad = context.Addresses.FromSqlRaw("SELECT *  FROM [SalesLT].[Address] where AddressId={0}",id).ToList();
         //   List<SqlParameter> plist = new List<SqlParameter>();
         //   plist.Add(param);

         //   var daten = context.Database.ExecuteSqlRaw("SELECT *  FROM [SalesLT].[Address] where AddressId=@id", plist.ToArray());
           // var ad = context.Addresses.Where(r => r.AddressId == id).FirstOrDefault();







            //using (var context = new dbCanonContext())
            //{
            //    var DieAdresse = new Address()
            //    { AddressLine1 ="Wilhelm Külz", City ="Kamenz" , PostalCode="01917"

            //     };
            //    context.Addresses.Add(DieAdresse);
            //    context.SaveChanges();




            //}



        }


    }
}
