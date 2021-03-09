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
using static CalculatorPR2._4method;
namespace CalculatorPR2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void Add(object sender, RoutedEventArgs e)
        {
            Rez.Text = Convert.ToString(ADD(Convert.ToDouble(First.Text), Convert.ToDouble(Second.Text)));
        }
        void Sub(object sender, RoutedEventArgs e)
        {
            Rez.Text = Convert.ToString(SUB(Convert.ToDouble(First.Text), Convert.ToDouble(Second.Text)));
        }
        void Div(object sender, RoutedEventArgs e)
        {
            Rez.Text = Convert.ToString(DIV(Convert.ToDouble(First.Text), Convert.ToDouble(Second.Text)));
        }
        void Mul(object sender, RoutedEventArgs e)
        {
            Rez.Text = Convert.ToString(MUL(Convert.ToDouble(First.Text), Convert.ToDouble(Second.Text)));
        }




        private void Second_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            CheckIsNumeric(e);
        }
        private void CheckIsNumeric(TextCompositionEventArgs e)
        {
            int result;

            if (!(int.TryParse(e.Text, out result) || e.Text == "."))
            {
                e.Handled = true;
            }
        }

        private void First_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            CheckIsNumeric(e);
        }

    
    }
}
