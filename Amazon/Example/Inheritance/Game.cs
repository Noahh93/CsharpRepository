using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Inheritance
{
    internal class Game
    {
        public void Swap(ref int num1, ref int num2)
        {
            int temp = num2;
            num2 = num1;
            num1 = temp;

        }
        public void GameIsDancing(Fish fish)
        {
            fish.Name = "Barbara";
            fish.Age = 2;
        }
    }
}
