using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov.Substitution.Principle.LSP.Utils;

public interface IPaymentIntrument
{
    void CollectPayment();

    void Validate();
}
