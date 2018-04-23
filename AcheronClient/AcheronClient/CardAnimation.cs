using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows;


namespace AcheronClient
{
    class CardAnimation
    {
        Thickness location; 

        public CardAnimation(Image CardOne)
        {
            location = CardOne.Margin;
        }

        #region NavigationAnimation 

        public void AnimateRight (Image Card)
        {
 
            string CardHight;
            CardHight = Card.Margin.ToString();
            ThicknessAnimation LocationAni = new ThicknessAnimation();
            DoubleAnimation HeightAnimate = new DoubleAnimation();
            DoubleAnimation WidthAnimate = new DoubleAnimation();

            if (CardHight == "102,67,0,0")
            {
                LocationAni.From = new Thickness(102, 67, 0, 0);
                LocationAni.To = new Thickness(240, 43, 0, 0);

                HeightAnimate.From = (229);
                HeightAnimate.To = (278);

                WidthAnimate.From =(132); 
                WidthAnimate.To = (147);

                Grid.SetZIndex(Card, 2);
            }
            else if (CardHight == "240,43,0,0")
            {
                LocationAni.From = new Thickness(240, 43, 0, 0);
                LocationAni.To = new Thickness(393, 21, 0, 0);

                HeightAnimate.From = (278);
                HeightAnimate.To = (322);

                WidthAnimate.From = (147);
                WidthAnimate.To = (166);

                Grid.SetZIndex(Card, 2);
            }
            else if (CardHight == "393,21,0,0")
            {
                LocationAni.From = new Thickness(393,21,0,0);
                LocationAni.To = new Thickness(565, 43, 0, 0);

                HeightAnimate.From = (322);
                HeightAnimate.To = (278);

                WidthAnimate.From = (166);
                WidthAnimate.To = (147);

                Grid.SetZIndex(Card, 2);
            }
            else if (CardHight == "565,43,0,0")
            {
                LocationAni.From = new Thickness(565, 43, 0, 0);
                LocationAni.To = new Thickness(718, 67, 0, 0);

                HeightAnimate.From = (278);
                HeightAnimate.To = (229);

                WidthAnimate.From = (147);
                WidthAnimate.To = (132);

                Grid.SetZIndex(Card, 2);
            }
            else if (CardHight == "718,67,0,0")
            {
                LocationAni.From = new Thickness(718, 67, 0, 0);
                LocationAni.To = new Thickness(102, 67, 0, 0);

                HeightAnimate.From = (229);
                HeightAnimate.To = (229);

                WidthAnimate.From = (132);
                WidthAnimate.To = (132);

                Grid.SetZIndex(Card, 1);
   
            }

            WidthAnimate.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
            Storyboard.SetTargetName(WidthAnimate, Card.Name);
            Storyboard.SetTargetProperty(WidthAnimate, new PropertyPath(Image.WidthProperty));
            Storyboard WidthAni = new Storyboard();
            WidthAni.Children.Add(WidthAnimate);
            WidthAni.Begin(Card);

            HeightAnimate.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
            Storyboard.SetTargetName(HeightAnimate, Card.Name);
            Storyboard.SetTargetProperty(HeightAnimate, new PropertyPath(Image.HeightProperty));
            Storyboard HeightAni = new Storyboard();
            HeightAni.Children.Add(HeightAnimate);
            HeightAni.Begin(Card);

            LocationAni.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
            Storyboard.SetTargetName(LocationAni, Card.Name);
            Storyboard.SetTargetProperty(LocationAni, new PropertyPath(Image.MarginProperty));
            Storyboard myWidthAnimatedButtonStoryboard = new Storyboard();
            myWidthAnimatedButtonStoryboard.Children.Add(LocationAni);

            myWidthAnimatedButtonStoryboard.Begin(Card);
        }

        public void AnimateLeft(Image Card)
        {
            string CardHight;
            CardHight = Card.Margin.ToString();
            ThicknessAnimation LocationAni = new ThicknessAnimation();
            DoubleAnimation HeightAnimate = new DoubleAnimation();
            DoubleAnimation WidthAnimate = new DoubleAnimation();

            if (CardHight == "102,67,0,0")
            {
                LocationAni.From = new Thickness(102, 67, 0, 0);
                LocationAni.To = new Thickness(718, 67, 0, 0);

                HeightAnimate.From = (229);
                HeightAnimate.To = (229);

                WidthAnimate.From = (132);
                WidthAnimate.To = (132);

                Grid.SetZIndex(Card, 1);
            }
            else if (CardHight == "240,43,0,0")
            {
                LocationAni.From = new Thickness(240, 43, 0, 0);
                LocationAni.To = new Thickness(102, 67, 0, 0);

                HeightAnimate.From = (278);
                HeightAnimate.To = (229);

                WidthAnimate.From = (147);
                WidthAnimate.To = (132);

                Grid.SetZIndex(Card, 2);
            }
            else if (CardHight == "393,21,0,0")
            {
                LocationAni.From = new Thickness(393, 21, 0, 0);
                LocationAni.To = new Thickness(240, 43, 0, 0);

                HeightAnimate.From = (322);
                HeightAnimate.To = (278);

                WidthAnimate.From = (166);
                WidthAnimate.To = (147);

                Grid.SetZIndex(Card, 2);
            }
            else if (CardHight == "565,43,0,0")
            {
                LocationAni.From = new Thickness(565, 43, 0, 0);
                LocationAni.To = new Thickness(393, 21, 0, 0);

                HeightAnimate.From = (278);
                HeightAnimate.To = (322);

                WidthAnimate.From = (147);
                WidthAnimate.To = (166);

                Grid.SetZIndex(Card, 2);
            }
            else if (CardHight == "718,67,0,0")
            {
                LocationAni.From = new Thickness(718, 67, 0, 0);
                LocationAni.To = new Thickness(565, 43, 0, 0);

                HeightAnimate.From = (229);
                HeightAnimate.To = (278);

                WidthAnimate.From = (132);
                WidthAnimate.To = (147);

                Grid.SetZIndex(Card, 2);

            }

            WidthAnimate.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
            Storyboard.SetTargetName(WidthAnimate, Card.Name);
            Storyboard.SetTargetProperty(WidthAnimate, new PropertyPath(Image.WidthProperty));
            Storyboard WidthAni = new Storyboard();
            WidthAni.Children.Add(WidthAnimate);
            WidthAni.Begin(Card);

            HeightAnimate.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
            Storyboard.SetTargetName(HeightAnimate, Card.Name);
            Storyboard.SetTargetProperty(HeightAnimate, new PropertyPath(Image.HeightProperty));
            Storyboard HeightAni = new Storyboard();
            HeightAni.Children.Add(HeightAnimate);
            HeightAni.Begin(Card);

            LocationAni.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
            Storyboard.SetTargetName(LocationAni, Card.Name);
            Storyboard.SetTargetProperty(LocationAni, new PropertyPath(Image.MarginProperty));
            Storyboard myWidthAnimatedButtonStoryboard = new Storyboard();
            myWidthAnimatedButtonStoryboard.Children.Add(LocationAni);

            myWidthAnimatedButtonStoryboard.Begin(Card);
        }
#endregion 

        public void MouseOverAnimation(Image CardOver, Image CardOne , Image CardTwo , Image CardThree, Image CardFour, bool reverse)
        {
            string Margin = CardOver.Margin.ToString();

                //MainCard
                DoubleAnimation heightAni = new DoubleAnimation();
                DoubleAnimation widthAni = new DoubleAnimation();
                ThicknessAnimation marginAni = new ThicknessAnimation();

                widthAni.From = CardOver.Width;
                widthAni.To = 166;

                widthAni.Duration = new Duration(TimeSpan.FromMilliseconds(500));
                Storyboard.SetTargetName(widthAni, CardOver.Name);
                Storyboard.SetTargetProperty(widthAni, new PropertyPath(Image.WidthProperty));
                Storyboard widthAnimate = new Storyboard();
                widthAnimate.Children.Add(widthAni);
                widthAnimate.Begin(CardOver);

                heightAni.From = CardOver.Height;
                heightAni.To = 322;

                heightAni.Duration = new Duration(TimeSpan.FromMilliseconds(500));
                Storyboard.SetTargetName(heightAni, CardOver.Name);
                Storyboard.SetTargetProperty(heightAni, new PropertyPath(Image.HeightProperty));
                Storyboard heightAnimate = new Storyboard();
                heightAnimate.Children.Add(heightAni);
                heightAnimate.Begin(CardOver);

                if (Margin == "102,67,0,0")
                {
                    marginAni.From = CardOver.Margin;
                    marginAni.To = new Thickness(102, 21, 0, 0);
                }
                else if (Margin == "240,43,0,0")
                {
                    marginAni.From = CardOver.Margin;
                    marginAni.To = new Thickness(240, 21, 0, 0);
                }
                else if (Margin == "393,21,0,0")
                {
                    marginAni.From = CardOver.Margin;
                    marginAni.To = new Thickness(393, 21, 0, 0);
                }
                else if (Margin == "565,43,0,0")
                {
                    marginAni.From = CardOver.Margin;
                    marginAni.To = new Thickness(565, 21, 0, 0);
                }
                else if (Margin == "718,67,0,0")
                {
                    marginAni.From = CardOver.Margin;
                    marginAni.To = new Thickness(718, 21, 0, 0);
                }


                marginAni.Duration = new Duration(TimeSpan.FromMilliseconds(500));
                Storyboard.SetTargetName(marginAni, CardOver.Name);
                Storyboard.SetTargetProperty(marginAni, new PropertyPath(Image.MarginProperty));
                Storyboard marginAnimate = new Storyboard();
                marginAnimate.Children.Add(marginAni);
                marginAnimate.Begin(CardOver);

                //CardTwo 

                if (Margin == "102,67,0,0")
                {
                    marginAni.From = CardOne.Margin;
                    marginAni.To = new Thickness(275, 43, 0, 0);
                }
                else if (Margin == "240,43,0,0")
                {
                    marginAni.From = CardOne.Margin;
                    marginAni.To = new Thickness(413, 43, 0, 0);
                }
                else if (Margin == "393,21,0,0")
                {
                    marginAni.From = CardOne.Margin;
                    marginAni.To = new Thickness(565, 43, 0, 0);
                }
                else if (Margin == "565,43,0,0")
                {
                    marginAni.From = CardOne.Margin;
                    marginAni.To = new Thickness(718, 43, 0, 0);
                }
                else if (Margin == "718,67,0,0")
                {
                    marginAni.From = CardOne.Margin;
                    marginAni.To = new Thickness(102, 43, 0, 0);
                }

                marginAni.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
                Storyboard.SetTargetName(marginAni, CardOne.Name);
                Storyboard.SetTargetProperty(marginAni, new PropertyPath(Image.MarginProperty));
                marginAnimate.Children.Add(marginAni);
                marginAnimate.Begin(CardOne);

                widthAni.From = CardOne.Width;
                widthAni.To = 132;

                widthAni.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
                Storyboard.SetTargetName(widthAni, CardOne.Name);
                Storyboard.SetTargetProperty(widthAni, new PropertyPath(Image.WidthProperty));
                widthAnimate.Children.Add(widthAni);
                widthAnimate.Begin(CardOne);

                heightAni.From = CardOne.Height;
                heightAni.To = 229;

                heightAni.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
                Storyboard.SetTargetName(heightAni, CardOne.Name);
                Storyboard.SetTargetProperty(heightAni, new PropertyPath(Image.HeightProperty));
                heightAnimate.Children.Add(heightAni);
                heightAnimate.Begin(CardOne);

                //CardThree

                widthAni.From = CardTwo.Width;
                widthAni.To = 132;

                widthAni.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
                Storyboard.SetTargetName(widthAni, CardTwo.Name);
                Storyboard.SetTargetProperty(widthAni, new PropertyPath(Image.WidthProperty));
                widthAnimate.Children.Add(widthAni);
                widthAnimate.Begin(CardTwo);

                heightAni.From = CardTwo.Height;
                heightAni.To = 229;

                heightAni.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
                Storyboard.SetTargetName(heightAni, CardTwo.Name);
                Storyboard.SetTargetProperty(heightAni, new PropertyPath(Image.HeightProperty));
                heightAnimate.Children.Add(heightAni);
                heightAnimate.Begin(CardTwo);

                if (Margin == "102,67,0,0")
                {
                    marginAni.From = CardTwo.Margin;
                    marginAni.To = new Thickness(393, 43, 0, 0);
                }
                else if (Margin == "240,43,0,0")
                {
                    marginAni.From = CardTwo.Margin;
                    marginAni.To = new Thickness(565, 43, 0, 0);
                }
                else if (Margin == "393,21,0,0")
                {
                    marginAni.From = CardTwo.Margin;
                    marginAni.To = new Thickness(748, 43, 0, 0);
                }
                else if (Margin == "565,43,0,0")
                {
                    marginAni.From = CardTwo.Margin;
                    marginAni.To = new Thickness(102, 43, 0, 0);
                }
                else if (Margin == "718,67,0,0")
                {
                    marginAni.From = CardTwo.Margin;
                    marginAni.To = new Thickness(240, 21, 0, 0);
                }

                marginAni.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
                Storyboard.SetTargetName(marginAni, CardTwo.Name);
                Storyboard.SetTargetProperty(marginAni, new PropertyPath(Image.MarginProperty));
                marginAnimate.Children.Add(marginAni);
                marginAnimate.Begin(CardTwo);

                //CardFour 

                widthAni.From = CardThree.Width;
                widthAni.To = 132;

                widthAni.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
                Storyboard.SetTargetName(widthAni, CardThree.Name);
                Storyboard.SetTargetProperty(widthAni, new PropertyPath(Image.WidthProperty));
                widthAnimate.Children.Add(widthAni);
                widthAnimate.Begin(CardThree);

                heightAni.From = CardThree.Height;
                heightAni.To = 229;

                heightAni.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
                Storyboard.SetTargetName(heightAni, CardThree.Name);
                Storyboard.SetTargetProperty(heightAni, new PropertyPath(Image.HeightProperty));
                heightAnimate.Children.Add(heightAni);
                heightAnimate.Begin(CardThree);

                if (Margin == "102,67,0,0")
                {
                    marginAni.From = CardThree.Margin;
                    marginAni.To = new Thickness(565, 43, 0, 0);
                }
                else if (Margin == "240,43,0,0")
                {
                    marginAni.From = CardThree.Margin;
                    marginAni.To = new Thickness(718, 43, 0, 0);
                }
                else if (Margin == "393,21,0,0")
                {
                    marginAni.From = CardThree.Margin;
                    marginAni.To = new Thickness(102, 43, 0, 0);
                }
                else if (Margin == "565,43,0,0")
                {
                    marginAni.From = CardThree.Margin;
                    marginAni.To = new Thickness(240, 43, 0, 0);
                }
                else if (Margin == "718,67,0,0")
                {
                    marginAni.From = CardOver.Margin;
                    marginAni.To = new Thickness(718, 43, 0, 0);
                }

                marginAni.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
                Storyboard.SetTargetName(marginAni, CardThree.Name);
                Storyboard.SetTargetProperty(marginAni, new PropertyPath(Image.MarginProperty));
                marginAnimate.Children.Add(marginAni);
                marginAnimate.Begin(CardThree);

                //CardFive 

                widthAni.From = CardFour.Width;
                widthAni.To = 132;

                widthAni.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
                Storyboard.SetTargetName(widthAni, CardFour.Name);
                Storyboard.SetTargetProperty(widthAni, new PropertyPath(Image.WidthProperty));
                widthAnimate.Children.Add(widthAni);
                widthAnimate.Begin(CardFour);

                heightAni.From = CardFour.Height;
                heightAni.To = 229;

                heightAni.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
                Storyboard.SetTargetName(heightAni, CardFour.Name);
                Storyboard.SetTargetProperty(heightAni, new PropertyPath(Image.HeightProperty));
                heightAnimate.Children.Add(heightAni);
                heightAnimate.Begin(CardFour);

                if (Margin == "102,67,0,0")
                {
                    marginAni.From = CardFour.Margin;
                    marginAni.To = new Thickness(718, 43, 0, 0);
                }
                else if (Margin == "240,43,0,0")
                {
                    marginAni.From = CardFour.Margin;
                    marginAni.To = new Thickness(102, 43, 0, 0);
                }
                else if (Margin == "393,21,0,0")
                {
                    marginAni.From = CardFour.Margin;
                    marginAni.To = new Thickness(240, 43, 0, 0);
                }
                else if (Margin == "565,43,0,0")
                {
                    marginAni.From = CardFour.Margin;
                    marginAni.To = new Thickness(393, 43, 0, 0);
                }
                else if (Margin == "718,67,0,0")
                {
                    marginAni.From = CardFour.Margin;
                    marginAni.To = new Thickness(565, 43, 0, 0);
                }

                marginAni.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
                Storyboard.SetTargetName(marginAni, CardFour.Name);
                Storyboard.SetTargetProperty(marginAni, new PropertyPath(Image.MarginProperty));
                marginAnimate.Children.Add(marginAni);
                marginAnimate.Begin(CardFour);

                marginAni.AutoReverse = true;
                heightAni.AutoReverse = true;
                widthAni.AutoReverse = true; 

               
        }
    }
}
