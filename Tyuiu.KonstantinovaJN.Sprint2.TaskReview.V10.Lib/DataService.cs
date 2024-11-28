using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KonstantinovaJN.Sprint2.TaskReview.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (x >= 0 && y <= -x && y >= (x * x - 2))
            {
                return true;
            }
            if (x <= 0 && y <= x && y >= (x * x - 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
