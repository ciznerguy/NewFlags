using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewFlags
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        // Method to set Italian flag colors
        private void SetItalianFlagColors()
        {
            // Hide other borders
            border1.Visibility = Visibility.Visible;
            border2.Visibility = Visibility.Hidden;
            border3.Visibility = Visibility.Hidden;

            rec1.Fill = new SolidColorBrush(Colors.Green);
            rec2.Fill = new SolidColorBrush(Colors.White);
            rec3.Fill = new SolidColorBrush(Colors.Red);
        }

        private void SetGermanFlagColors()
        {
            // Hide other borders
            border1.Visibility = Visibility.Hidden;
            border2.Visibility = Visibility.Visible;
            border3.Visibility = Visibility.Hidden;

            // Show the German flag colors by setting the Rectangle fills
            row1.Fill = new SolidColorBrush(Colors.Black);
            row2.Fill = new SolidColorBrush(Colors.Red);
            row3.Fill = new SolidColorBrush(Colors.Yellow);
        }

        private void italyBTN_Click(object sender, RoutedEventArgs e)
        {
            SetItalianFlagColors();
        }
        private void franceBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void belgiumBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void germanBTN_Click(object sender, RoutedEventArgs e)
        {
       
            SetGermanFlagColors();
    
        }

        private void israelBTN_Click(object sender, RoutedEventArgs e)
        {

        }


        private void mainCombo_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Check if an item is selected
            if (mainCombo.SelectedItem != null)
            {
                // Retrieve the selected item's content as a string
                string selectedCountry = (mainCombo.SelectedItem as ComboBoxItem)?.Content.ToString();

                // Handle Italy selection
                if (selectedCountry == "Italy")
                {
                   
                    SetItalianFlagColors();
                    
                }
                // Handle France selection
                else if (selectedCountry == "France")
                {
                    // Add your logic for France here
                    // For example, display a message or perform some action
                    MessageBox.Show("France selected!");
                    // Proceed to the next stage
                    // Ask if there's anything specific to be done next.
                }
                // You can add similar conditions for other countries if needed
            }
            // If no item is selected, you may want to handle this case.
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                string selectedCountry = radioButton.Content.ToString();

                // You can perform different actions based on the selected radio button
                switch (selectedCountry)
                {
                    case "Italy":
                        SetItalianFlagColors();
                        break;
                    case "France":
                       // SetFrenchFlagColors();
                        break;
                    case "Belgium":
                       // SetBelgiumFlagColors();
                        break;
                    case "Germany":
                       SetGermanFlagColors();
                        break;
                    case "Israel":
                        // Add your logic for Israel here
                        // For example, display a message or perform some action
                        MessageBox.Show("Israel selected!");
                        break;
                    // Add cases for other radio buttons if needed
                    default:
                        break;
                }
            }
        }

    }
}
