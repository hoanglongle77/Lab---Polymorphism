using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Polymorphism.Problem_2
{
    internal class Animal
    {
        private string name;
        private string favouriteFood;

        public string Name { get => name; protected set => name=value; }
        public string FavouriteFood { get => favouriteFood; protected set => favouriteFood=value; }

        protected Animal()
        {
        }

        protected Animal(string name, string favouriteFood)
        {
            Name=name;
            FavouriteFood=favouriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
        }
    }
}
