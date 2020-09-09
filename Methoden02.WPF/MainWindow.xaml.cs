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

namespace Methoden02.WPF
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            //double netEuro = double.Parse(txtNetEuro.Text);
            //double exchange = double.Parse(txtExchange.Text);
            //double vat = double.Parse(txtVAT.Text);
            //tblEuro.Text = GenerateReportEuro(netEuro, vat);
            //tblDollar.Text = GenerateReportDollar(netEuro, vat, exchange);

            tblEuro.Text = GenerateReportEuro(txtNetEuro.Text, txtVAT.Text);
        }

        private string GenerateReportEuro(double net, double vat)
        {

            double vatTotal = net * (vat / 100);
            double totalAmount = net + vatTotal;
            string report = "Netto bedrag = " + net.ToString("#,##0.00") + " EURO" + Environment.NewLine;
            report += "BTW " + vat.ToString("#,##0.00") + "% = " + vatTotal.ToString("#,##0.00") + " EURO" + Environment.NewLine;
            report += "Totaal bedrag = " + totalAmount.ToString("#,##0.00") + " EURO";
            return report;
        }
        private string GenerateReportEuro(string netInText, string vatInText)
        {
            double net = double.Parse(netInText);
            double vat = double.Parse(vatInText);

            double vatTotal = net * (vat / 100);
            double totalAmount = net + vatTotal;
            string report = "Netto bedrag = " + net.ToString("#,##0.00") + " EURO" + Environment.NewLine;
            report += "BTW " + vat.ToString("#,##0.00") + "% = " + vatTotal.ToString("#,##0.00") + " EURO" + Environment.NewLine;
            report += "Totaal bedrag = " + totalAmount.ToString("#,##0.00") + " EURO";
            return report;
        }

        private string GenerateReportDollar(double net, double vat, double exchangeRate)
        {
            net = net * exchangeRate;
            double vatTotal = net * (vat / 100);
            double totalAmount = net + vatTotal;
            string report = "Netto bedrag = " + net.ToString("#,##0.00") + " DOLLAR" + Environment.NewLine;
            report += "BTW " + vat.ToString("#,##0.00") + "% = " + vatTotal.ToString("#,##0.00") + " DOLLAR" + Environment.NewLine;
            report += "Totaal bedrag = " + totalAmount.ToString("#,##0.00") + " DOLLAR";
            return report;

        }

        private int AddNumbers(int number1, int number2)
        {
            return number1 + number2;
        }
        private double AddNumbers(double number1, int number2)
        {
            return number1 + number2;
        }
    }
}
