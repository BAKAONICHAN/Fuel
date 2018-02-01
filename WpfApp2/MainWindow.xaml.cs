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

namespace WpfApp2
{
    
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Summa;
        int countOfBurgersClassic=0;
        int countOfBurgersVegan = 0;
        int countOfChocolate = 0;
        int countOfFuel90 = 0;
        int countOfFuel92 = 0;
        int countOfFuel95 = 0;
        int countOfCola = 0;
        int countOfSprite = 0;
        int priceOfBurgersClassic = 400;
        int priceOfBurgersVegan =500;
        int priceOfChocolate =300;
        int priceOfFuel90 = 150;
        int priceOfFuel92 = 170;
        int priceOfFuel95 = 180;
        int priceOfCola = 150;
        int priceOfSprite = 150;
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            Summa = (countOfSprite * priceOfSprite)+(countOfBurgersClassic * priceOfBurgersClassic)+ (countOfBurgersVegan * priceOfBurgersVegan)+(countOfChocolate * priceOfChocolate)+(countOfFuel90 * priceOfFuel90)+(priceOfFuel92 * countOfFuel92)+(countOfFuel95 * priceOfFuel95)+(priceOfCola * countOfCola);
            MessageBox.Show("Сумма="+Summa);
        }

        private void Choco_Click(object sender, RoutedEventArgs e)
        {
            countOfChocolate = countOfChocolate + 1;
        }

        private void BurgerClassic_Click(object sender, RoutedEventArgs e)
        {
            countOfBurgersClassic = countOfBurgersClassic + 1;
        }

        private void VeganBurger_Click(object sender, RoutedEventArgs e)
        {
            countOfBurgersVegan = countOfBurgersVegan + 1;
        }

        private void Fuel90_Click(object sender, RoutedEventArgs e)
        {
            countOfFuel90 = countOfFuel90 + 1;
        }

        private void Fuel92_Click(object sender, RoutedEventArgs e)
        {
            countOfFuel92 = countOfFuel92 + 1;
        }

        private void Fuel95_Click(object sender, RoutedEventArgs e)
        {
            countOfFuel95 = countOfFuel95 + 1;
        }

        private void Cola_Click(object sender, RoutedEventArgs e)
        {
            countOfCola = countOfCola + 1;
        }

        private void Sprite_Click(object sender, RoutedEventArgs e)
        {
            countOfSprite = countOfSprite + 1;
        }
    }
}
