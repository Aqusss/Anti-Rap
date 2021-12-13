using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _Parce;
using _FinanceManager;

namespace _Check
{
    class Check
    {
        private List<Parce> parces;
        public Check() { }

        public void Refill(Parce parce, double sum)
        {
            foreach (Parce el in parces)
            {
                if (el == parce)
                {
                    el.Balance += sum;
                }
            }
        }

        public void AddParce(Parce parce)
        {
            parces.Append(parce);
        }

        public void RemoveParce(Parce parce)
        {
            parces.Remove(parce);
        }
    }
}
