using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Polymorphism.Problem_2
{
    internal class Dog : Animal
    {
        public Dog()
        {
        }

        public Dog(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + " WOOF";
        }
    }
}
