using System.Windows;
using System.Windows.Controls;

namespace YetAnotherMinesweeper.View
{
    /// <summary>
    /// Interaction logic for GameSuperviser.xaml
    /// </summary>
    public partial class GameSuperviser : UserControl
    {
        public GameSuperviser()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModel.GameSuperviser)(DataContext)).CreateMinefield();
        }
    }
}
