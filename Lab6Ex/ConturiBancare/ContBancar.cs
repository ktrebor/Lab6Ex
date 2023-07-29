using Lab6Ex.ConturiBancare.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Ex.ConturiBancare
{
    public abstract class ContBancar
    {
        protected string numeCont { get; }
        protected decimal sold { get; set; }
        protected Guid idCont { get; }
        protected TipCont tipCont;
        
        private static int totalConturi = 0;

        public ContBancar(string numeCont, TipCont tipCont)
        {
            this.idCont = Guid.NewGuid();
            this.numeCont = numeCont;
            this.sold = 0;
            this.tipCont = tipCont;
            
            totalConturi++;
        }

        public virtual void Depune(decimal suma)
        {
            sold += suma;
        }
        public virtual void Extrage(decimal suma)
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
            return $"Nume cont: {numeCont}. Sold: {sold}. Tip cont: {tipCont}. ID Cont: {idCont}";
        }

        public static int GetNumarTotalConturi()
        {
            return totalConturi;
        }
    }
}
