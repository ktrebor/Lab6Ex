using Lab6Ex1_DiffApproach.ConturiBancare.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Ex1_DiffApproach.ConturiBancare
{
    public class ContCurent : ContBancar
    {
        protected const int limitaDescoperireCont = 5000;

        public ContCurent(string numeCont) : base(numeCont) 
        {
        }

        public override TipCont tip
        {
            get
            {
                return TipCont.Curent;
            }
        }

        public override void Depune(decimal suma)
        {
            sold += suma;
        }

        public override void Extrage(decimal suma)
        {
            if (suma > sold + limitaDescoperireCont)
            {
                Console.WriteLine($"Fonduri insuficiente. Suma ceruta depaseste plafonul de descoperire de cont de {limitaDescoperireCont}RON.");
            }
            else if (suma > sold)
            {
                Console.WriteLine($"Atentie! Suma ceruta depaseste soldul disponibil. Se permite descoperirea de cont in limita plafonului de {limitaDescoperireCont}RON.");
                sold -= suma;
            }
            else
            {
                sold -= suma;
            }
        }

        public override string ToString()
        {
            string baseDesc = base.ToString();
            return $"{baseDesc} Limita descoperire: {limitaDescoperireCont}RON. ";
        }
    }
}
