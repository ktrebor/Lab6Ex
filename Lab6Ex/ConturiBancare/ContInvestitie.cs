using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab6Ex.ConturiBancare.Enums;

namespace Lab6Ex.ConturiBancare
{
    public class ContInvestitie : ContBancar
    {
        protected const decimal rataDobanda = 0.01m;
        protected const int ziuaTermenExtragere = 15;
        
        public ContInvestitie(string numeCont) : base(numeCont, TipCont.Investitie) 
        {  
        }

        public override void Extrage(decimal suma)
        {
            var ziuaCurenta = DateTime.Now.Day;

            if (ziuaCurenta < ziuaTermenExtragere)
            {
                Console.WriteLine($"Atentie! Suma poate fi extrasa doar dupa ziua {ziuaTermenExtragere}-a lunii curente.");
            }
            else
            {
                sold -= suma;
            }
        }

        public override void Depune(decimal suma)
        {
            base.Depune(suma);
            sold *= (1 + rataDobanda);
        }

        public override string ToString()
        {
            string baseDesc = base.ToString();
            return $"{baseDesc}. Rata dobanda: {rataDobanda * 100}%. Ziua termen extragere: {ziuaTermenExtragere}.";
        }
    }
}