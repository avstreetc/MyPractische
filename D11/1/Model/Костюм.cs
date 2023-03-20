using a1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a1.Model
{
    internal class Костюм : Одежда
    {
        protected double H; //рост

        public Костюм(string название, double H) : base(название)
        {
            this.H = H;
        }

        public override void ВывестиРезультат()
        {
            Console.WriteLine("Название: {0}, Рост: {1:F1}, Расход ткани: {2:F1} м.", название, H, РасходТкани());
        }

        public override double РасходТкани()
        {
            {
                return 2 * H + 0.3;
            }
        }
    }
}
