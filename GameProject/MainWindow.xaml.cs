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

namespace GameProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> questoionNumbers = new List<int> { 1,2,3,4,5,6,7,8,9,10};

        int qNum = 0;
        int i;
        int score;
        public MainWindow()
        {
            InitializeComponent();
           /* StartGame();
            NextQuestion();*/
        }

        private void RestartGame()
        {
            score = 0;
            qNum = -1;
            i = 0;
            
        }
        private void StartGame()
        {
            score = 0;
            qNum = -1;
        }
        private void EndGame()
        {
            if(score<5)
            {
                txtQustion.Text = "Its a Loose Hahahahahahaha!";
            }
            else
            {
                txtQustion.Text = "Its a Win Yip Yip Hahahahaha!";
                RestartGame();
            }
        }
        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            Button SenderButton = sender as Button;

            if(SenderButton.Tag.ToString()=="1")
            {
                score++;
            }
            if(qNum<0)
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }
            scoreText.Content = "Answered Correctly" + score + "/" + questoionNumbers.Count;
        //run next question 
          NextQuestion();
        }

        private void NextQuestion()
        {
            if(qNum<questoionNumbers.Count)
            {
                i = questoionNumbers[qNum];
            }
            else
            {
                EndGame();
            }

            //
            foreach (var item in myCanvas.Children.OfType<Button>())
            {
                item.Tag = "0";
                item.Background = Brushes.DarkSalmon;
            }

            switch (i) 
            {
                case 1:
                    qImage.Source = new BitmapImage(new Uri(@"./Images/JoshDo.jpg",UriKind.RelativeOrAbsolute));
                    txtQustion.Text = "Do you know the country of this guy";
                    ans1.Content = "South Africa";
                    ans2.Content = "England";
                    ans3.Content = "Zambia";
                    ans4.Content = "Uganda";

                    ans2.Tag = "1";
                    break;

                case 2:
                    qImage.Source = new BitmapImage(new Uri(@"./Images/josuaDoe.png",UriKind.RelativeOrAbsolute));
                    txtQustion.Text = "Which Shop have Image of this Guy";
                    ans1.Content = "Joshua Doe";
                    ans2.Content = "mfundo Store";
                    ans3.Content = "Makeleni Store";
                    ans4.Content = "Ntlavu Spaza";

                    ans1.Tag = "1";
                    break;

                case 3:
                    qImage.Source = new BitmapImage(new Uri(@"./Images/jos.jpg", UriKind.RelativeOrAbsolute));
                    txtQustion.Text = "Who is this Guy";
                    ans1.Content = "Mfundo";
                    ans2.Content = "Malapane";
                    ans3.Content = "Joshua Doe";
                    ans4.Content = "Josia Doe";

                    ans3.Tag = "1";
                    break;

                case 4:
                    qImage.Source = new BitmapImage(new Uri(@"./Images/pai.jpg", UriKind.RelativeOrAbsolute));
                    txtQustion.Text = "Who is the owner of this PIc";
                    ans1.Content = "Wendly";
                    ans2.Content = "Paccaso";
                    ans3.Content = "Mundi";
                    ans4.Content = "Picasso";

                    ans4.Tag = "1";
                    break;

                case 5:
                    qImage.Source = new BitmapImage(new Uri(@"./Images/a1.jpg", UriKind.RelativeOrAbsolute));
                    txtQustion.Text = "what is the name of this animal";
                    ans1.Content = "Nkau";
                    ans2.Content = "Monkey";
                    ans3.Content = "Manky";
                    ans4.Content = "baboon";

                    ans2.Tag = "1";
                    break;

                case 6:
                    qImage.Source = new BitmapImage(new Uri(@"./Images/a2.jpg", UriKind.RelativeOrAbsolute));
                    txtQustion.Text = "How dangerous is this animal toward humans";
                    ans1.Content = "Not Dangerous";
                    ans2.Content = "Most Dangerous";
                    ans3.Content = "Less Dangerous";
                    ans4.Content = " Very Friendly";

                    ans4.Tag = "1";
                    break;
                case 7:
                    qImage.Source = new BitmapImage(new Uri(@"./Images/a3.jpg", UriKind.RelativeOrAbsolute));
                    txtQustion.Text = "How dangerous is this animal toward humans";
                    ans1.Content = "Not Dangerous";
                    ans2.Content = "Most Dangerous";
                    ans3.Content = "Less Dangerous";
                    ans4.Content = "Friendly";

                    ans2.Tag = "1";
                    break;
                case 8:
                    qImage.Source = new BitmapImage(new Uri(@"./Images/a4.jpg", UriKind.RelativeOrAbsolute));
                    txtQustion.Text = "What insect kills this animal";
                    ans1.Content = "ants";
                    ans2.Content = "fly";
                    ans3.Content = "Amasonja";
                    ans4.Content = "anty";

                    ans1.Tag = "1";
                    break;
                case 9:
                    qImage.Source = new BitmapImage(new Uri(@"./Images/lion.jpg", UriKind.RelativeOrAbsolute));
                    txtQustion.Text = "How dangerous is this animal toward other animals";
                    ans1.Content = "Not Dangerous";
                    ans2.Content = "Most Dangerous";
                    ans3.Content = "Less Dangerous";
                    ans4.Content = "Friendly";

                    ans2.Tag = "1";
                    break;
                case 10:
                    qImage.Source = new BitmapImage(new Uri(@"./Images/a10.jpg", UriKind.RelativeOrAbsolute));
                    txtQustion.Text = "How tall is this animals";
                    ans1.Content = "Not Tall";
                    ans2.Content = "Less Tall";
                    ans3.Content = "Middle Tall";
                    ans4.Content = "Very Tall";

                    ans4.Tag = "1";
                    break;
                case 11:
                    qImage.Source = new BitmapImage(new Uri(@"./Images/a10.jpg", UriKind.RelativeOrAbsolute));
                    txtQustion.Text = "How many colors in this animal";
                    ans1.Content = "3";
                    ans2.Content = "5";
                    ans3.Content = "2";
                    ans4.Content = "6";

                    ans3.Tag = "1";
                    break;
            }

        }
        
        private void ans1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
