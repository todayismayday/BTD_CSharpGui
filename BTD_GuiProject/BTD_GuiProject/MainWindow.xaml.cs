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

namespace BTD_GuiProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            windowMain.MaxHeight = 465;
            windowMain.MinHeight = 465;
            windowMain.MaxWidth = 800;
            windowMain.MinWidth = 800;
        }

        private void btCal_Click(object sender, RoutedEventArgs e)
        {
            if (txtIncome.Text == string.Empty)
            {
                MessageBox.Show("Please input your income");
            }
            else if (txtExpenses.Text == string.Empty)
            {
                MessageBox.Show("Please input your expenses");
            }
            else if (txtWishlist.Text == string.Empty)
            {
                MessageBox.Show("Please input the price of your wishlist");
            }
            else if(float.Parse(txtIncome.Text) < float.Parse(txtExpenses.Text))
            {
                MessageBox.Show("Your income shouldn't be lower than your expenses...");
            }
            else
            {
                calculateDay();
            }
        }


        private void calculateDay()
        {
            float income = float.Parse(txtIncome.Text);
            float expenses = float.Parse(txtExpenses.Text);
            float price = float.Parse(txtWishlist.Text);

            float lmoney = 0f;
            double dayTilGetItem = 0;

            lmoney = income - expenses;
            dayTilGetItem = Math.Ceiling(price / lmoney);

            if (dayTilGetItem >= 0 ) 
            {
                MessageBox.Show("Do your best with your money saving plan!!!");
                txtDays.Text = dayTilGetItem.ToString();
            }

        }
    }
}
