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

namespace GA_JuanHernandez_RTB
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

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            rtbDisplay.Text = txtUserInput.Text;
        }

        private void btnAppend_Click(object sender, RoutedEventArgs e)
        {
            rtbDisplay.Text += " " + txtUserInput2.Text;
        }

        private void btnAppendRTB_Click(object sender, RoutedEventArgs e)
        {
            rtbDisplay.Text += " " + rtbDisplay2.Text;
        }
    }
}
