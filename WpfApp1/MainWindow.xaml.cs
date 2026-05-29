using System;
using System.Windows;

namespace ConverterApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double value = double.Parse(txtValue.Text);
                double result = 0;
                string text = "";

                switch (cmbType.SelectedIndex)
                {
                    case 0: // Метры → Километры
                        result = value / 1000;
                        text = $"{value} м = {result} км";
                        break;
                    case 1: // Километры → Метры
                        result = value * 1000;
                        text = $"{value} км = {result} м";
                        break;
                    case 2: // Цельсий → Фаренгейт
                        result = value * 1.8 + 32;
                        text = $"{value}°C = {result}°F";
                        break;
                    case 3: // Фаренгейт → Цельсий
                        result = (value - 32) / 1.8;
                        text = $"{value}°F = {result:F1}°C";
                        break;
                }

                tbResult.Text = text;
            }
            catch
            {
                MessageBox.Show("Введите число!");
            }
        }
    }
}