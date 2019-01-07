using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resualt_01
{
    class Coockie
    {
        private bool gluten;//Sets a private key to a Boolean Gluten-containing value
        public bool Gluten
        {
            get { return gluten; }
            set { gluten = value; }
        }

        private int eggs;
        public int Eggs
        {
            get { return eggs; }
            set { eggs = value; }
        }
        private double sugar;

        public double Sugar
        {
            get { return sugar; }
            set { sugar = value; }
        }
        private double flour;

        public double Flour
        {
            get { return flour; }
            set { flour = value; }
        }
        
    }
}
