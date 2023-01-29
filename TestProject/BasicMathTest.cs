using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace TestProject
{
    [TestClass]

    public class BasicMathTest
    {
        [TestMethod]
        public void Test_Add_Success()
        {
            BasicMath basicMath = new BasicMath();
            int Result = basicMath.Add(3, 3);

            Assert.AreEqual(6, Result);
            
        }
        [TestMethod]
        public void Test_Add_NotEqual_Success()
        {
            BasicMath basicMath = new BasicMath();
            int Result = basicMath.Add(2,2);

            Assert.AreNotEqual(7, Result);
        }
        [TestMethod]
        public void Test_MultiplyEqual_Success()
        {
            BasicMath basicMath = new BasicMath();
            int Result = basicMath.Multiply(3, 3);

            Assert.AreEqual(9, Result);
        }
        [TestMethod]
        public void Test_MultiplyNot_Equal_Success()
        {
            BasicMath basicMath = new BasicMath();
            int Result = basicMath.Multiply(3, 3);

            Assert.AreNotEqual(2, Result);
        }
    }
}
