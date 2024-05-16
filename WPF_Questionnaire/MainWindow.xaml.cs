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
using Questionnaire_library;
using TriviaApiLibrary;

namespace WPF_Questionnaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        int score = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GObtn_Click(object sender, RoutedEventArgs e)
        {
            //when button is clicked, the first question will be displayed on the screen
            //the possible answers will be displayed on the buttons
            //the image will be displayed on the screen
            
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            //when button is clicked , check if the answer is correct. if not, display the correct answer and change image to cross.png, else change image to tick.png

        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            //when button is clicked , check if the answer is correct. if not, display the correct answer and change image to cross.png, else change image to tick.png
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            //when button is clicked , check if the answer is correct. if not, display the correct answer and change image to cross.png, else change image to tick.png
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            //when button is clicked , another question will be displayed
            //if the answer is right , the score will be increased by 1 and displayed on the screen 
        }

        
    }
}