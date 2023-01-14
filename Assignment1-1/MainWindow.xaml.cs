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

namespace Assignment1_KorbinDansie
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

        /// <summary>
        /// Display a message box when the top button is clicked
        /// Also display which button in the message box was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOne_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Your clicked the top button\nYou typed: " + TextBoxOne.Text, "Button One", MessageBoxButton.OK, MessageBoxImage.Error);
            LbResult.Content = $"top button's {result} button";
            SetVisablityForResults();
        }

        /// <summary>
        /// Display a message box when the middle button is clicked
        /// Also display which button in the message box was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTwo_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Your clicked the middle button\nYou typed: " + TextBoxTwo.Text, "Button Two", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            LbResult.Content = $"middle button's {result} button";
            SetVisablityForResults();
        }

        /// <summary>
        /// Display a message box when the bottom button is clicked
        /// Also display which button in the message box was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnThree_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Your clicked the bottom button\nYou typed: " + TextBoxThree.Text, "Button Three", MessageBoxButton.YesNo, MessageBoxImage.Information);
            LbResult.Content = $"bottom button's {result} button";
            SetVisablityForResults();
        }

        /// <summary>
        /// Set the result sections visiblity to Visible 
        /// </summary>
        private void SetVisablityForResults()
        {
            LbResultIntroText.Visibility = Visibility.Visible;
            LbResult.Visibility = Visibility.Visible;
        }
    }
}
