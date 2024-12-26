using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            Title = "Кредитный калькулятор";
            InitializeComponent();
            InterestRateSlider.Minimum = 12;
        }

        async void ShowErrorMessage(string message)
        {
            await Application.Current.MainPage.DisplayAlert("Ошибка", message, "OK");
        }

        private void OnCalculateButtonClicked(object sender, EventArgs e)
        {
            if (LoanAmountEntry.Text != null && LoanTermEntry.Text != null && PaymentTypePicker.SelectedItem != null)
            {
                double loanAmount = double.Parse(LoanAmountEntry.Text);
                int loanTerm = int.Parse(LoanTermEntry.Text);
                double interestRate = InterestRateSlider.Value;
                string paymentType = PaymentTypePicker.SelectedItem.ToString();

                if (loanAmount >= 1000 && loanAmount <= 50000000 )
                {
                    if (loanTerm >= 1 && loanTerm <= 360)
                    {

                        double monthlyPayment = 0;
                        double totalAmount = 0;
                        double overpayment = 0;

                        if (paymentType == "Аннуитетный")
                        {

                            double monthlyRate = interestRate / 100 / 12;
                            monthlyPayment = loanAmount * (monthlyRate * Math.Pow(1 + monthlyRate, loanTerm)) / (Math.Pow(1 + monthlyRate, loanTerm) - 1);
                            totalAmount = monthlyPayment * loanTerm;
                            overpayment = totalAmount - loanAmount;
                            MonthlyPaymentLabel.Text = $"{monthlyPayment:F2} руб.";


                        }
                        else if (paymentType == "Дифференцированный")
                        {

                            double monthlyRate = interestRate / 100 / 12;
                            double principalPayment = loanAmount / loanTerm;
                            double firstPayment = principalPayment + (loanAmount * monthlyRate);
                            monthlyPayment = firstPayment;

                            totalAmount = 0;
                            for (int i = 0; i < loanTerm; i++)
                            {
                                double interestPayment = (loanAmount - (principalPayment * i)) * monthlyRate;
                                totalAmount += principalPayment + interestPayment;
                            }
                            overpayment = totalAmount - loanAmount;
                            MonthlyPaymentLabel.Text = $"...";

                        }
                        TotalAmountLabel.Text = $"{totalAmount:F2} руб.";
                        OverpaymentLabel.Text = $"{overpayment:F2} руб.";
                    }
                    else ShowErrorMessage("Срок кредита не меньше 1 и не больше 360.");
                }
                else ShowErrorMessage("Сумма не меньше 1000 и не больше 50 000 000.");
            }
            else ShowErrorMessage("Заполните поля.");
        }

    }
}