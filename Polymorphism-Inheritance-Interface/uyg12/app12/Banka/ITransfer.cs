using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app12.Banka
{
    public interface ITransfer : IBankaHesap
    {
        bool TransferYap(IBankaHesap aliciHesap,
            decimal miktar);
    }
}
