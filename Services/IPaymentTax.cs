using PaymentsExercise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsExercise.Services
{
  interface IPaymentTax
  {
    public void paymentTax(List<Installment> installments , Contract contract);
  }
}
