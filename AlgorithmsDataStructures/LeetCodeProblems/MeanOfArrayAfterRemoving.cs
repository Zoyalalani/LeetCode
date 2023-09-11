using System;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    //1619. Mean of Array After Removing Some Elements

    public class MeanOfArrayAfterRemoving
    {
        public double TrimMean(int[] arr)
        {
            int Length = arr.Length;
            int fivePercent = (int)Math.Round((double)(0.05 * Length));
            Array.Sort(arr);
            //Removes min 5
            int[] newArray = arr.Skip(fivePercent).ToArray();
            Array.Reverse(newArray);
            int[] arr2 = newArray.Skip(fivePercent).ToArray();
            return (double) (arr2.Sum()) / (Length - (fivePercent + fivePercent));

        }
    }
}
