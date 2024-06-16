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

namespace PracticalWork_9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Separation seporationPage;
        Reverse reversePage;
        public MainWindow()
        {
            InitializeComponent();
            seporationPage = new Separation();
            reversePage = new Reverse();
        }

        private void ReverseText(object sender, RoutedEventArgs e)
        {
            string[] textWords = inputText.Text.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(textWords);
            string reverseText = string.Join(" ", textWords);

            reversePage.reversePageText.Content = reverseText;
            
            MainFrame.Content = reversePage;
        }

        private void SeporationText(object sender, RoutedEventArgs e)
        {
            string[] textWords = inputText.Text.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            int wordNumber = 1;

            for (int i = 0; i < textWords.Length; i++) 
            {
                textWords[i] = $"{wordNumber++} :" + textWords[i];
            }

            seporationPage.seporationListBox.ItemsSource = textWords;

            MainFrame.Content = seporationPage;
        }
    }
}
