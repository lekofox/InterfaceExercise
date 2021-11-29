using PaymentsExercise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsExercise.Services
{
  class PaypalTaxService : IPaymentTax
  {
    public void paymentTax(List<Installment> installments, Contract contract)
    {
      int counter = 1;


      foreach (Installment i in installments)
      {
        double price = i.InstallmentPrice + i.InstallmentPrice * (1 * counter) / 100;
        double finalPrice = price + price * 2 / 100;
        i.InstallmentNumber = counter;
        i.InstallmentPrice = finalPrice;
        i.PaymentDate = contract.ContractDate.AddMonths(counter);
        counter++;
      }
     
    }
  }
}
