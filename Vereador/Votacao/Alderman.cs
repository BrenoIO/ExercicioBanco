using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votacao
{
    internal class Alderman
    {
        public string Name { get; private set; }
        public int Age { get; set; }
        public string PoliticalParty { get; set; }
        


        public Alderman(string name, int age, string politicalParty)
        {
            Name = name;
            Age = age;
            PoliticalParty = politicalParty;
        }

        public override string ToString()
        {
            return $"Nome: {Name}\nIdade: {Age}\nPartido: {PoliticalParty}\n";
        }
    }


}
