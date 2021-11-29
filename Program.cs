using PaymentsExercise.Entities;
using PaymentsExercise.Services;
using System;

namespace PaymentsExercise
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter contract data :");
      Console.Write("Number: ");
      int contractNumber = int.Parse(Console.ReadLine());
      Console.Write("Date (mm/dd/yyyy): ");
      DateTime contractDate = DateTime.Parse(Console.ReadLine());
      Console.Write("Contract Value: ");
      double contractValue = double.Parse(Console.ReadLine());
      Console.Write("Number of installments: ");
      int contractInstallments = int.Parse(Console.ReadLine());

      Contract contract = new Contract(contractNumber, contractDate, contractValue, contractInstallments);
      GenerateInstallmentsService installmentService = new GenerateInstallmentsService();
      installmentService.GenerateInstallment(contract);
      PaypalTaxService paypalTaxService = new PaypalTaxService();
      paypalTaxService.paymentTax(contract.installments, contract);

      Console.WriteLine("Installments: ");
      foreach (Installment i in contract.installments)
      {
        Console.WriteLine($"{i.PaymentDate} - {i.InstallmentPrice.ToString("F2")}");
      }

    }
  }
}
