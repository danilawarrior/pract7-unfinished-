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

namespace pract7_Eliseev_isp31
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

        private void AddTriad(object sender, RoutedEventArgs e)
        {
            try
            {
                Triad triada1 = new Triad(Convert.ToInt32(firstNumber.Text), Convert.ToInt32(secondNumber.Text), Convert.ToInt32(thirdNumber.Text));
                ListBoxOfTriads.Items.Add(triada1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Equal(object sender, RoutedEventArgs e)
        {
            var selectedTriad = ListBoxOfTriads.SelectedItems;

            if (selectedTriad.Count == 2)
            {
                Triad first = selectedTriad[0] as Triad;
                Triad second = selectedTriad[1] as Triad;

                if (first.Equality(second)) 
                {
                    MessageBox.Show("Equal");
                }
                else
                {
                    MessageBox.Show("Not equal");
                }
            }

            if (selectedTriad.Count == 3)
            {
                Triad first = selectedTriad[0] as Triad;
                Triad second = selectedTriad[1] as Triad;
                Triad third = selectedTriad[2] as Triad;

                if (first.Equality(second, third))
                {
                    MessageBox.Show("Equal");
                }
                else MessageBox.Show("Not equal");
            }
        }

        private void About_Program(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать класс Triad (тройничек нечетных чисел). Создать необходимые методы и \r\nсвойства. Определить метод сравнения двух триад на равенство. Создать \r\nперегруженный метод сравнения трех триад на равенство");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EqualPart2(object sender, RoutedEventArgs e)
        {
            var selectedTriad = ListBoxOfTriads.SelectedItems;

            if (selectedTriad.Count == 2)
            {
                Triad first = selectedTriad[0] as Triad;
                Triad second = selectedTriad[1] as Triad;

                if (first == second)
                {
                    MessageBox.Show("Equal");
                }
                else
                {
                    MessageBox.Show("Not equal");
                }
            }
        }

        private void EqualOfTime(object sender, RoutedEventArgs e)
        {
            var selectedTimeMoment = ListBoxOfTriads.SelectedItems;

            if (selectedTimeMoment.Count == 2)
            {
                Time firstMoment = selectedTimeMoment[0] as Time;
                Time secondMoment = selectedTimeMoment[1] as Time;

                if (firstMoment.Comparsion(secondMoment))
                {
                    MessageBox.Show("time moments is equal");                 
                }
                else { MessageBox.Show("time moments is not equal"); }
            }
        }
    }
}
