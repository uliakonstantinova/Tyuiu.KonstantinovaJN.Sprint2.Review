using Tyuiu.KonstantinovaJN.Sprint2.TaskReview.V10.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint2.TaskReview.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = -1;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;
          
            Assert.AreEqual(wait, res);
        }
    }
}