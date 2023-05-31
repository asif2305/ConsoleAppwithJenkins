using ConsoleAppwithJenkins;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public void TestMethod1()
        {
            //First  
            Trigonometric.TrianlgeSidesInput(10, 190, 150);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Second Test  
            Trigonometric.TrianlgeSidesInput(10.5, 10.5, 15);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Thisrd Test  
            Trigonometric.TrianlgeSidesInput(10.5, 12.5, 15.5);

        }
    }
}