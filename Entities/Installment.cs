using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsExercise.Entities
{
  class Installment
  {
    public Installment(double installmentPrice)
    {
      
      InstallmentPrice = installmentPrice;
      
    }

    public int InstallmentNumber{ get; set; }
    public double InstallmentPrice { get; set; }

    public DateTime PaymentDate { get; set; }

 
  }
}
