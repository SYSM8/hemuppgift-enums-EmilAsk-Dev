using System.Windows;
using System.Windows.Controls;

namespace Hemuppgift_WPF
{
    public partial class WrapPanelWindow : Window
    {
        public WrapPanelWindow()
        {
            InitializeComponent(); 
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
          
            if (MainWrapPanel != null)
            {
                
                if (VerticalRadioButton.IsChecked == true)
                {
                    MainWrapPanel.Orientation = Orientation.Vertical; 
                }
                else
                {
                    MainWrapPanel.Orientation = Orientation.Horizontal; 
                }
            }
            
        }
    }
}
