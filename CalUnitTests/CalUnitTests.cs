using NUnit.Framework;
using MathOperationsLib;
namespace Tests
{
    [TestFixture] 
    public class CalUnitTests
    {
        IMathOperations _MathOperations=new MathOperations();
        [TestCase(1,2,3)]
        [TestCase(-1,2000,1999)]
        public void AddtoNumbersTest(int a,int b,int expected)
        {
            int actual=_MathOperations.Addition(a,b);
            Assert.AreEqual(expected,actual);
        }
        [TestCase(25,5,5)]
        public void DivisionTest(int a,int b,int expected)
        {
            int actual=_MathOperations.Division(a,b);
            Assert.AreEqual(expected,actual);
        }
    }
}