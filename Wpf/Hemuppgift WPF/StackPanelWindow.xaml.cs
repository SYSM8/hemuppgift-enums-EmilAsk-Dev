using System.Windows;
using System.Windows.Controls;

namespace Hemuppgift_WPF
{
    public partial class StackPanelWindow : Window
    {
        public StackPanelWindow()
        {
            InitializeComponent(); 
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
            if (MainStackPanel != null)
            {
                
                if (VerticalRadioButton.IsChecked == true)
                {
                    MainStackPanel.Orientation = Orientation.Vertical; 
                }
                else
                {
                    MainStackPanel.Orientation = Orientation.Horizontal; 
                }
            }
            
        }
    }
}
