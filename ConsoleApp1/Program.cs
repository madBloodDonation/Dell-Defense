using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;
using System.Data.Common;
using System.Data.SqlClient;
using log4net;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dell Defense");
            Console.WriteLine("----------------------");
            Console.WriteLine("Please enter the path:");
            string fileName = Console.ReadLine();
            Console.WriteLine("Path selected : {0}", fileName);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Now we need Database Details");
            Console.Write("Please Enter the Database Source:");
            string DataSource = "dcm.uhcl.edu";
            Console.Write("Please Enter the Database Name:");
            string DBName = "capfa18g3";
            Console.Write("Please Enter the User Id:");
            string UserId = "capfa18g3";

            string password = "3163345";
            //Console.Write("Enter password: ");
            //ConsoleKeyInfo keyInfo;

            //do
            //{
            //    keyInfo = Console.ReadKey(true);
            //    // Skip if Backspace or Enter is Pressed
            //    if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
            //    {
            //        password += keyInfo.KeyChar;
            //        Console.Write("*");
            //    }
            //    else
            //    {
            //        if (keyInfo.Key == ConsoleKey.Backspace && password.Length > 0)
            //        {
            //            // Remove last charcter if Backspace is Pressed
            //            password = password.Substring(0, (password.Length - 1));
            //            Console.Write("\b \b");
            //        }
            //    }
            //}
            //while (keyInfo.Key != ConsoleKey.Enter);
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("{0} ,{1} , {2}, {3}", DataSource, DBName, UserId, password);

            Console.WriteLine("Now connecting to the Database:");

            SqlConnection con = null; //con1, compareConnection = null;
            string connectionString = "Data Source =" + DataSource + ";Initial Catalog=" + DBName + ";User ID =" + UserId + ";Password=" + password;
            Console.WriteLine("{0}", connectionString);
            con = new SqlConnection(connectionString);
            try
            {
             ///   log.Info("Trying to connect to DataBase");
                con.Open();
              ///  log.Info("Connected to DataBase");
                Console.WriteLine("Connection Sccessful");
               /// log.Info("Closing DataBase connection");
                con.Close();
            }
            catch (Exception ex)
            {
              ///  log.Error("Connection to Database failed with exception " + ex);
                Console.WriteLine("Connection not established. Exception " + ex);
            }
        
           Console.ReadKey(true);
        }
    }
}


////private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
////CommonOpenFileDialog dialog = new CommonOpenFileDialog();
//public void Connection()
//{
//    Console.WriteLine("hello world");
//    SqlConnection con, con1, compareConnection = null;
//    Console.WriteLine("hello");
//    Console.ReadKey(true);
//}