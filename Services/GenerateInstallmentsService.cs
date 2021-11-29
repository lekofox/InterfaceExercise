using PaymentsExercise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsExercise.Services
{
  class GenerateInstallmentsService 
  {
    public void GenerateInstallment(Contract contract)
    {
      List<Installment> installments = new List<Installment>();
      int InstallmentAmount = contract.NumberOfInstallments;
      double installmentPrice = contract.ContractValue / InstallmentAmount;

      for (int i = 0; i < InstallmentAmount; i++)
      {
        installments.Add(new Installment(installmentPrice));
      }

      contract.installments = installments;
    }
  }
}
