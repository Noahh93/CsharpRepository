using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Association
{
    internal class Human
    {
        private Brain _brain;                   //One to One
        private Heart _heart;       //Field
        private Hair[] _hair = new Hair[1000];  //One to many

        public Human()              //Created a Constructor here
        {
            _brain = new Brain();
            _heart = new Heart();   //HeartObject

            for (int i = 0; i < 1000; i = i + 1)
            {
                _hair[i] = new Hair();
                //Console.WriteLine(i);
            }

            
        }
        public void HumanActivity()
        {
            _brain.Thinking();
            _brain.Stressing();
            _heart.Pumping();
        }
        public void HeartActivity()
        {
            _heart.Pumping();
        }
        public void HairActivity()
        {
            for( int i = 0; i < 5; i++)
            {
                _hair[i].Hairloss();
            }

        }
    }
}
