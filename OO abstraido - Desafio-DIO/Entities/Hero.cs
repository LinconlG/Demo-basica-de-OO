using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_abstraido___Desafio_DIO.Entities
{
    class Hero
    {
        public string name { get; set; }
        public int level { get; set; }
        public string heroType { get; set; }

        public Hero(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public override string ToString()
        {
            return $"{name} {level} {heroType}";
        }

        public virtual string Attack()
        {
            return name + " atacou";
        }
    }
}
