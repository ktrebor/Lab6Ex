using Lab6Ex1_DiffApproach.ConturiBancare.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Ex1_DiffApproach.ConturiBancare
{
    public class ContInvestitie : ContEconomie
    {
        protected const int ziuaTermenExtragere = 15;

        public ContInvestitie(string numeCont) : base(numeCont)
        {
        }

        public override TipCont tip
        {
            get
            {
                return TipCont.Investitie;
            }
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
                base.Extrage(suma);
            }
        }

        public override string ToString()
        {
            string baseDesc = base.ToString();
            return $"{baseDesc} Ziua termen extragere: {ziuaTermenExtragere}.";
        }
    }
}
