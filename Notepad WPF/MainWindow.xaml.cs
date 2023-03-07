using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace Notepad_WPF
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

        private void AutoSave_Checked(object sender, RoutedEventArgs e)
        {
            if (AutoSave.IsChecked == true)
            {
                File.WriteAllText("BizimFile.txt", textboxyazi.Text);

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("BizimFile.txt", textboxyazi.Text);
            textbox.AppendText(Directory.GetCurrentDirectory() + "\\BizimFile.txt");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textboxyazi.Cut();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textboxyazi.Copy();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textboxyazi.Paste();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textboxyazi.Focus();
            textboxyazi.SelectAll();
        }


    }
}
