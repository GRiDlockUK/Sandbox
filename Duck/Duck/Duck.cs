using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    class Duck
    {
        QuackBehaviour quackBehaviour;

        public void PerformQuack()
        {
            quackBehaviour.quack();
        }
    }

}
