using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a1.Model
{
    internal abstract class Одежда
    {
            protected string название;
            public Одежда(string название)
            {
                this.название = название;
            }
            public virtual void ВывестиРезультат()
            {
                Console.WriteLine("Название: {0}", название);
            }

            public virtual double РасходТкани()
            {
                return 0;
            }
    }
}
