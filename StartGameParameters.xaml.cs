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

namespace Project_ChessWithInterface
{
    /// <summary>
    /// Interaction logic for StartGameParameters.xaml
    /// </summary>
    public partial class StartGameParameters : Window
    {
        public StartGameParameters()
        {
            InitializeComponent();
           
            ParametersWindow.Icon = new BitmapImage(new Uri(Globals.pathToResources + "\\ChessIcon.png"));
            OpponentSelection_list.FontSize = 18;
            OpponentSelection_list.FontWeight = FontWeights.Bold;
            OpponentSelection_list.Items.Add("AI");
            OpponentSelection_list.Items.Add("Local play(both sides playable)");
            GameModeSelection_list.Items.Add("Classical chess");
            GameModeSelection_list.FontSize = 18;
            GameModeSelection_list.FontWeight = FontWeights.Bold;
            submit_btn.Click += Submit_btn_Click;
            
        }

        private void Submit_btn_Click(object sender, RoutedEventArgs e)
        {
            if(OpponentSelection_list.SelectedItem != null && GameModeSelection_list.SelectedItem != null)
            {
                if(OpponentSelection_list.SelectedItem.ToString() == "AI")
                {
                    PlayerColorSelectionDialog playerColorSelection = new PlayerColorSelectionDialog();
                    playerColorSelection.ShowDialog();

                }
                else
                {
                    Globals.AI = null;
                }
                MainWindow.InitializeBoard();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();


            }
            else
            {
                MessageBox.Show("Not all setting were selected.");
            }
            
        }
    }
}