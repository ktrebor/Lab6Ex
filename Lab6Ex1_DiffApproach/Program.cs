using Lab6Ex1_DiffApproach.ConturiBancare;
using Lab6Ex1_DiffApproach.ConturiBancare.Enums;
using System;

namespace Lab6Ex1_DiffApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var creatorContulEconomic = ContBancar.GetCreator(TipCont.Economie);
            var contEconomic = creatorContulEconomic.CreateContBancar("Contul lui Vasile");

            var creatorContInvestitie = ContBancar.GetCreator(TipCont.Investitie);
            var contInvestitie = creatorContInvestitie.CreateContBancar("lalsdpclo31jd1123");

            var creatorContCurent = ContBancar.GetCreator(TipCont.Curent);
            var contCurent = creatorContCurent.CreateContBancar("oaoapapal");

            Console.WriteLine(ContBancar.GetNumarTotalConturi()); 
            
            contCurent.Depune(10000);
            contInvestitie.Depune(1000);
            contEconomic.Depune(1000);
            
            Console.WriteLine(contCurent);
            Console.WriteLine(contInvestitie);
            Console.WriteLine(contEconomic);

            contCurent.Extrage(14000);
            contInvestitie.Extrage(2000);
            contEconomic.Extrage(1000);
            
            Console.WriteLine(contCurent);
            Console.WriteLine(contInvestitie);
            Console.WriteLine(contEconomic);
        }
    }
}
