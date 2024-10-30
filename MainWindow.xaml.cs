
using System;
using System.Linq;
using System.Windows;

namespace MinMaxCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int[] numbers = new int[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-100, 101);
            }

            int x = numbers.Min();

            int[] twoMaxNumbers = numbers.OrderByDescending(n => n).Take(2).ToArray();
            int y = twoMaxNumbers[0];
            int z = twoMaxNumbers[1];

            double f = Math.Sin(x*(Math.PI/180)) + Math.Cos(y * (Math.PI / 180)) - Math.Tan(z * (Math.PI / 180));

            ResultText.Text = $"Массив: [{string.Join(", ", numbers)}]\n" +
                              $"x (наименьшее число) = {x}\n" +
                              $"y (наибольшее число) = {y}\n" +
                              $"z (второе наибольшее число) = {z}\n\n";
                              
            ResultF.Text = $"f(x, y, z) = {f}\n";
        }
    }
}