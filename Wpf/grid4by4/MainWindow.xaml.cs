using System.Windows;
using System.Windows.Controls;

namespace grid4by4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonGrid_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new GridWindow());  // Navigera till GridWindow 
        }

        private void ButtonStackPanel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new StackPanelWindow());  // Navigera till StackPanelWindow 
        }

        private void ButtonWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new WrapPanelWindow());  // Navigera till WrapPanelWindow 
        }

        private void ButtonDockPanel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DockPanelWindow());  // Navigera till DockPanelWindow 
        }
    }
}
