using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_abstraido___Desafio_DIO.Entities
{
    class Wizard : Hero
    {


        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
        }

        public override string Attack()
        {
            return name + " lançou magia";
        }
    }
}
