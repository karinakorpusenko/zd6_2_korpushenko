using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page : ContentPage
    {
        public Page()
        {
            InitializeComponent();
        }
        private void OnCalculateClicked(object sender, EventArgs e)
        {
            double amount;
            double interest;
            int term;
            if (string.IsNullOrWhiteSpace(loanAmountEntry.Text) ||
    string.IsNullOrWhiteSpace(interestRateEntry.Text) ||
    string.IsNullOrWhiteSpace(loanTermEntry.Text))
            {
                resultLabel.Text = "Пожалуйста, заполните все поля.";
            }
            // Проверяем, что введенные значения корректны
          else  if (double.TryParse(loanAmountEntry.Text, out amount) &&
                double.TryParse(interestRateEntry.Text, out interest) &&
                int.TryParse(loanTermEntry.Text, out term))
            {
                // Выполняем расчет
                interest =interest/100 / 12; // Преобразуем процентную ставку
                term *= 12; // Преобразуем срок в месяцы

                double monthlyPayment = (amount * interest) / (1 - Math.Pow(1 + interest, -term));
                resultLabel.Text = $"Ежемесячный платеж: {monthlyPayment:C}";
            }
            else
            {
                // Обработка ошибок ввода
                resultLabel.Text = "Пожалуйста, введите корректные значения.";
            }

           
        }
    }
}