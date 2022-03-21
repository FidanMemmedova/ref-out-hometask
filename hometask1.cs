using System;

namespace _20_mart_hometask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 5, 7 };
            int num = 3;

            Asdf(ref nums, num);

        }
        static void Asdf(ref int[] arr, int variable)
        {

            int[] newarray = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newarray[i] = arr[i];
            }
            newarray[arr.Length] = variable;
            arr = newarray;
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
