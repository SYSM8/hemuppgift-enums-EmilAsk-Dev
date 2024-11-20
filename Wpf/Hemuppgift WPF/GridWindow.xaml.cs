using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Hemuppgift_WPF
{
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
            CreateGridCells(); 
        }

        private void CreateGridCells()
        {
            
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    // Create a border for the cell
                    Border border = new Border
                    {
                        BorderBrush = Brushes.Black,
                        BorderThickness = new Thickness(1),
                        Background = Brushes.Transparent 
                    };

                   
                    Grid.SetRow(border, row);
                    Grid.SetColumn(border, col);

                   
                    MainGrid.Children.Add(border);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (int.TryParse(RowInput.Text, out int row) && int.TryParse(ColumeInput.Text, out int column))
            {
                
                if (row >= 0 && row < 6 && column >= 0 && column < 6) 
                {
                    
                    var cell = GetCell(row, column);
                    if (cell != null)
                    {
                        cell.Background = new SolidColorBrush(Colors.LightGreen);

                      
                        TextBlock textBlock = new TextBlock
                        {
                            Text = $"Row: {row}, Col: {column}",
                            VerticalAlignment = VerticalAlignment.Center,
                            HorizontalAlignment = HorizontalAlignment.Center
                        };

                        
                        cell.Child = textBlock;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid row and column numbers.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter numeric values.");
            }
        }

        private Border GetCell(int row, int column)
        {
            foreach (var child in MainGrid.Children)
            {
                if (child is Border border && Grid.GetRow(border) == row && Grid.GetColumn(border) == column)
                {
                    return border;
                }
            }
            return null;
        }
    }
}
