using Lab6Ex1_DiffApproach.ConturiBancare.Enums;
using Lab6Ex1_DiffApproach.ConturiBancare.Fabrici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Ex1_DiffApproach.ConturiBancare
{
    public abstract class ContBancar
    {
        protected Guid idCont { get; }
        protected string numeCont { get; }
        protected decimal sold { get; set; }
        public abstract TipCont tip { get; }

        protected static int totalConturi = 0;
        

        protected ContBancar(string numeCont)
        {
            this.idCont = Guid.NewGuid();
            this.numeCont = numeCont;
            this.sold = sold;
            totalConturi++;
        }

        public abstract void Depune(decimal suma);
        public abstract void Extrage(decimal suma);


        public static CreatorCont GetCreator(TipCont tip)
        {
            switch (tip)
            {
                case TipCont.Curent:
                    return new CreatorContCurent();
                case TipCont.Economie:
                    return new CreatorContEconomii();
                case TipCont.Investitie:
                    return new CreatorContInvestitii();
                default:
                    throw new ArgumentException("Tip Cont invalid.");
            }
        }

        public override string ToString()
        {
            return $"Tip cont: {tip}. Nume cont: {numeCont}. Sold: {sold}RON. ID Cont: {idCont}.";
        }

        public static int GetNumarTotalConturi()
        {
            return totalConturi;
        }
    }
}