using Lab6Ex.ConturiBancare.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab6Ex.ConturiBancare
{
    public class ContEconomie : ContBancar
    {
        const decimal rataDobanda = 0.02m;

        public ContEconomie(string numeCont) : base(numeCont, TipCont.Economie) { }

        public override void Depune(decimal suma)
        {
            base.Depune(suma);
            sold *= (1 + rataDobanda);
        }

        public override string ToString()
        {
            string baseDesc = base.ToString();
            return $"{baseDesc}. Rata dobanda: {rataDobanda * 100}%. ";
        }
    }
}
