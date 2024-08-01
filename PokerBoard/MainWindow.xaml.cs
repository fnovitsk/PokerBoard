using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PokerBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new BoardViewModel();
            
        }


        #region FLOP TURN RIVER BUTTONS
        private void FlopButton_Click(object sender, RoutedEventArgs e)
        {
            var t = (BoardViewModel)DataContext;
            foreach (var card in t.Cards.Where(card => card.CardType == CardType.Flop))
            {
                card.Visability = Visibility.Visible;
            }
        }

        private void TurnButton_Click(object sender, RoutedEventArgs e)
        {
            var t = (BoardViewModel)DataContext;
            foreach (var card in t.Cards.Where(card => card.CardType == CardType.Turn))
            {
                card.Visability = Visibility.Visible;
            }
        }

        private void RiverButton_Click(object sender, RoutedEventArgs e)
        {
            var t = (BoardViewModel)DataContext;
            foreach (var card in t.Cards.Where(card => card.CardType == CardType.River))
            {
                card.Visability = Visibility.Visible;
            }
        }
        #endregion
    }
}