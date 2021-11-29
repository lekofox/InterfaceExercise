using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsExercise.Entities
{
  class Contract
  {
    public Contract(int contractNumber, DateTime contractDate, double contractValue, int numberOfInstallments)
    {
      ContractNumber = contractNumber;
      ContractDate = contractDate;
      ContractValue = contractValue;
      NumberOfInstallments = numberOfInstallments;
    }

    public int ContractNumber { get; set; }
    public DateTime ContractDate { get; set; }

    public double ContractValue { get; set; }

    public int NumberOfInstallments { get; set; }

    public List<Installment> installments { get;  set; }
  }
}
