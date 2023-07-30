using Lab6Ex1_DiffApproach.ConturiBancare.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Ex1_DiffApproach.ConturiBancare.Fabrici
{
    public class CreatorContCurent : CreatorCont
    {
        public override ContBancar CreateContBancar(string name)
        {
            return new ContCurent(name);
        }
    }
}
