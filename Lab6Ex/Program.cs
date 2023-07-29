using Lab6Ex.ConturiBancare;
using Lab6Ex.ConturiBancare.Enums;
using System;

namespace Lab6Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contulDeEconomii = new ContEconomie("cont economic");
            contulDeEconomii.Depune(100);
            Console.WriteLine(contulDeEconomii);
            contulDeEconomii.Extrage(500);
            Console.WriteLine(contulDeEconomii);

            
            var contulDeInvestitii = new ContInvestitie("cont invest");
            contulDeInvestitii.Depune(5000);

            Console.WriteLine(contulDeInvestitii);
            contulDeInvestitii.Extrage(1000);
            Console.WriteLine(contulDeInvestitii);

            var contCurent = new ContCurent("cont curent");
            contCurent.Depune(100);
            Console.WriteLine(contCurent);
            contCurent.Extrage(500);
            Console.WriteLine(contCurent);

            Console.WriteLine(ContBancar.GetNumarTotalConturi());
        }
    }
}
