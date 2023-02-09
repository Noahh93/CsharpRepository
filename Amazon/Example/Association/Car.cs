using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Association
{
    internal class Car
    {
        //Field, constructor and object
        private Engine _engine;
        private Wheels[] _wheels1;
        

        public Car() 
        {

            //string[] countries = new string[4];
            //countries[0] = "USA";
            //countries[1] = "Germany";
            //countries[2] = "Italy";


            _engine = new Engine(); //object
            _wheels1 = new Wheels[4];
            for (int i = 0; i < 4; i++)
            {
                _wheels1[i] = new Wheels();
            }


            //_wheels1[0] = new Wheels();
            //_wheels1[1] = new Wheels();
            //_wheels1[2] = new Wheels();

            //for (int i = 0; i < 3; i++)
            //{
            //    //Console.WriteLine(countries[i]);
            //    _wheels1[i].MovingTires();
            //}
        }
        public void CompleteCar()
        {
            _engine.V8(8, "V8");
        }
        public void TireStatus()
        {
            for (int i = 0; i < 4; i++)
            {
                //Console.WriteLine(countries[i]);
                _wheels1[i].MovingTires();
            }
        }
    }
}
