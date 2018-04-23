using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Windows.Media.Animation;
using System.Diagnostics;

namespace AcheronClient
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

        #region MainMenuLaunchButton 
        private void image9_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Process app = new Process();
            app.StartInfo.FileName = "C:/Users/Craig/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/BlackJackCTI/BlackJackCTI";
            app.Start();
        }
        private void image9_MouseEnter(object sender, MouseEventArgs e)
        {
            image9.Source = new BitmapImage(new Uri("/Images/btnLanchHighlighted.jpg", UriKind.RelativeOrAbsolute));
        }

        private void image9_MouseLeave(object sender, MouseEventArgs e)
        {
            image9.Source = new BitmapImage(new Uri("/Images/btnLaunchStandard.jpg", UriKind.RelativeOrAbsolute));
        }
        #endregion 
        #region MainMenuNavigationButtons 

        private void image10_MouseUp(object sender, MouseButtonEventArgs e)
        {
            CardAnimation AnimateClass = new CardAnimation(CardOne);

            Grid.SetZIndex(CardOne, 3);
            AnimateClass.AnimateLeft(CardOne);

            Grid.SetZIndex(CardTwo, 3);
            AnimateClass.AnimateLeft(CardTwo);

            Grid.SetZIndex(CardThree, 3);
            AnimateClass.AnimateLeft(CardThree);

            Grid.SetZIndex(CardFour, 3);
            AnimateClass.AnimateLeft(CardFour);

            Grid.SetZIndex(CardFive, 0);
            AnimateClass.AnimateLeft(CardFive);
        }

        private void image11_MouseUp(object sender, MouseButtonEventArgs e)
        {
            CardAnimation AnimateClass = new CardAnimation(CardOne);

            Grid.SetZIndex(CardOne, 0);
            AnimateClass.AnimateRight(CardOne);

            Grid.SetZIndex(CardTwo, 3);
            AnimateClass.AnimateRight(CardTwo);

            Grid.SetZIndex(CardThree, 3);
            AnimateClass.AnimateRight(CardThree);

            Grid.SetZIndex(CardFour, 3);
            AnimateClass.AnimateRight(CardFour);

            Grid.SetZIndex(CardFive, 3);
            AnimateClass.AnimateRight(CardFive);
        }
        private void image11_MouseEnter(object sender, MouseEventArgs e)
        {
            image11.Source = new BitmapImage(new Uri("/Images/ArrowRightMouseOver.jpg", UriKind.RelativeOrAbsolute));
        }

        private void image11_MouseLeave(object sender, MouseEventArgs e)
        {
            image11.Source = new BitmapImage(new Uri("/Images/ArrowRight.jpg", UriKind.RelativeOrAbsolute));
        }
        #endregion 


        private void CardOne_MouseEnter(object sender, MouseEventArgs e)
        {
            CardAnimation animate = new CardAnimation(CardOne);
            animate.MouseOverAnimation(CardOne, CardTwo, CardThree, CardFour, CardFive , false);
        }

        private void CardTwo_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void CardThree_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void CardFour_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void CardFive_MouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}
