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

namespace PE1CEss
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
        int startNummer = 0;
        int eindNummer = 0;
        private void startStudentennummerTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            startNummer = Convert.ToInt32(startStudentennummerTextBox.Text);
            if (startNummer > 12000000 || startNummer < 20000000)
            {
                startStudentennummerTextBox.Text = startNummer.ToString();
            }

        }

        private void eindeStudentennummerTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            eindNummer = Convert.ToInt32(eindeStudentennummerTextBox.Text);
            eindeStudentennummerTextBox.Text = eindNummer.ToString() ;
            if (eindNummer > 12000000 || eindNummer < 20000000)
            {
                eindeStudentennummerTextBox.Text = eindNummer.ToString();
            }
        }

        private void groupButton_Click(object sender, RoutedEventArgs e)
        {
            if (!(eindNummer > startNummer))
            {
                MessageBox.Show("Geef twee geldige studentennummers in voor de start en eindwaarde. Geldige studentennummers zijn getallen tussen 12 miljoen en 20 miljoen. Tot slot moet de startnummer kleiner zijn dan de eindnummer.");
            }
            else
            {

            }
        }
    }
}