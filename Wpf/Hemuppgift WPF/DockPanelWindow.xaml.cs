using System.Windows;

namespace Hemuppgift_WPF
{
    public partial class DockPanelWindow : Window
    {
        public DockPanelWindow()
        {
            InitializeComponent();
        }

        private void CenterButton_Click(object sender, RoutedEventArgs e)
        {
            
            CenterButton.Visibility = Visibility.Collapsed; 
            VictoryMessage.Visibility = Visibility.Visible; 
        }
    }
}
