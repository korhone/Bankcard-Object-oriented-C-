using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Maksukorttitehtava
{
    class Bankcard
    {
        private double saldo;
        private double moneyLoad;
        private double eatCheapAmmount = 2.60;
        private double eatGoodAmmount = 4.60;
        public Bankcard(double saldo) 
        {
            this.saldo = saldo;
        }
        public override string ToString()
        {
            return $"Balance on the card {saldo.ToString("F")} €.";
        }
        public void eatChep()
        {
            if (saldo - eatCheapAmmount > 0)
                this.saldo = saldo - eatCheapAmmount;
        }
        public void eatGood() 
        {
            if (saldo - eatGoodAmmount >0)
                this.saldo = saldo - 4.60;
        }
        public void LoadMoney(double moneyLoad)
        { 
            this.moneyLoad = moneyLoad;
            if (moneyLoad > 0)
                this.saldo = saldo + moneyLoad;
            else 
                this.saldo = saldo;
        }
    }
}
