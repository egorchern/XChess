﻿using System;
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
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Project_ChessWithInterface
{
    /// <summary>
    /// Interaction logic for GameArchive.xaml
    /// </summary>
    public partial class GameArchive : Window
    {
        public GameArchive()
        {
            InitializeComponent();
        }

        private void Games_list_Loaded(object sender, RoutedEventArgs e)
        {
            string connectionString = MainWindow.GetConnectionStringForDatabase();
            SqlConnection gameArchive = new SqlConnection();
            SqlCommand command = new SqlCommand();
            gameArchive.ConnectionString = connectionString;
            gameArchive.Open();
            command.Connection = gameArchive;
            command.CommandText = "SELECT * FROM PlayedGames ORDER BY DatePlayed DESC";
            List<string> SqlToList = new List<string>();
            string pathToReferenceFolder = GetPathToReferenceFolder();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string gameText = $"Game {reader.GetValue(0)}: Move Count = {Convert.ToInt32(reader.GetValue(4)) - 1}; Winner = {reader.GetValue(1)}\nDate Played = {reader.GetValue(2)} ";
                gameText = Regex.Replace(gameText, @"00:00:00", "");
                referenceList.Add(Convert.ToString(reader.GetValue(3)));
                SqlToList.Add(gameText);
            }
            Games_lst.ItemsSource = SqlToList;
            
            
            
        }
        /*public List<string> ReferenceList
        {
            set { referenceList = value; }
            get { return referenceList; }
        }
        */
        private List<string> referenceList = new List<string>();
        public static string GetPathToReferenceFolder()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            var temp = path.Split('\\').ToList();
            temp.RemoveAt(temp.Count - 1);
            temp.RemoveAt(temp.Count - 1);
            temp.RemoveAt(temp.Count - 1);
            path = String.Join("\\", temp);
            path += "\\MoveRecord";
            return path;
        }

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DisplayRecord_btn.Content = new TextBlock
            {
                TextAlignment = TextAlignment.Center,
                TextWrapping = TextWrapping.Wrap,
                Text = $"Display\nrecord"

            };
        }

        private void DisplayRecord_btn_Click(object sender, RoutedEventArgs e)
        {
            if (Games_lst.SelectedIndex != -1)
            {


                int indexOfSelectedItem = Games_lst.SelectedIndex;
                string pathToRecord = GetPathToReferenceFolder() + referenceList[indexOfSelectedItem];
                Process.Start(pathToRecord);
            }


        }
    }
}
