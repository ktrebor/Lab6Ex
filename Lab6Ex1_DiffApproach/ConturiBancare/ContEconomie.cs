using Lab6Ex1_DiffApproach.ConturiBancare.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Ex1_DiffApproach.ConturiBancare
{
    public class ContEconomie : ContBancar
    {
        protected const decimal rataDobanda = 0.018m;

        public ContEconomie(string numeCont) : base(numeCont) { }

        public override TipCont tip
        {
            get
            {
                return TipCont.Economie;
            }
        }

        public override void Depune(decimal suma)
        {
            sold += suma;
            sold *= (1 + rataDobanda);
        }

        public override void Extrage(decimal suma)
        {
            if (suma > sold)
            {
                Console.WriteLine("Fonduri insuficiente.");
            }
            else
            {
                sold -= suma;
            }
        }

        public override string ToString()
        {
            string baseDesc = base.ToString();
            return $"{baseDesc} Rata dobanda: {rataDobanda * 100}%.";
        }
    }
}
