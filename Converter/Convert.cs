using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class Convert
    {
        public double Money { get; set; }

        public Enums Enums { get; set;}

        public Convert(double money, Enums enums) 
        {
            Money = money;
            Enums = enums;
            ValutaConvert();
      
        }

        public delegate void del ( double val);
        public del Del;

        public void ValutaConvert()
        {
            if (Enums == Enums.USD)
            {
                Del= (USD.ToUZS);
                Del += USD.ToRUB;
                Del += USD.ToEUR;

            }
            else if (Enums == Enums.RUB)
            {
                Del = (RUB.ToUZS);
                Del += RUB.ToUSD;
                Del += RUB.ToEUR;

            }

            else if (Enums == Enums.UZS)
            {
                Del = (UZS.ToUSD);
                Del += UZS.ToRUB;
                Del += UZS.ToEUR;

            }
            else if (Enums == Enums.EUR)
            {
                Del = (EUR.ToUZS);
                Del += EUR.ToRUB;
                Del += EUR.ToUSD;

            }

            Del.Invoke(Money);

        }

    }
}
