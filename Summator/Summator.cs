
namespace Summator
{
    public class Summator
    {
        public double Sum(double[] arr)
        {
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        public static double Average(double[] arr)
        {
            double sum = 0;            

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            double avg = sum / arr.Length;
            return avg;
        }
    }
}
