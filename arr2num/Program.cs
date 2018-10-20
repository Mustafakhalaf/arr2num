using System;

namespace arr2num
{
    class Program
    {
//check the value of each number from user array
//to determine the number name that will be printed which is related to that number
// the number is passed as integer from arr[i]
        public static string num2stringconv(int num) 
        {                                           
            if (num == 0)
            {
                return "Zero";
            }
            if (num == 1)
            {
                return "one";
            }
            if (num == 2)
            {
                return "Two";
            }
            if (num == 3)
            {
                return "Three";
            }
            if (num == 4)
            {
                return "Four";
            }
            if (num == 5)
            {
                return "Five";
            }
            if (num == 6)
            {
                return "Six";
            }
            if (num == 7)
            {
                return "Seven";
            }
            if (num == 8)
            {
                return "Eight";
            }
            else
            {
                return "Nine";
            }
        }

        // passing user array element one by one to num2stringconv and retreaving result to store it in 
        public static string[] num2string(int[] arr1) 
        {
            int length = arr1.Length;
            string[] arr = new string[length];
            for (int i = 0; i < length; i++)
            {
                var numberstring = num2stringconv(arr1[i]);
                arr[i] = numberstring;
            }
            return arr;
        }


        static void Main(string[] args)
        {
            
            int s1, i;
            Console.Write("Input the number of elements to be stored in the array :");
            s1 = Convert.ToInt32(Console.ReadLine());// the length of the array Specified by user
            int[] arr1 = new int[s1]; // this is the array where the user will store his input's in

            Console.Write("Input {0} elements in the array :\n", s1);
            for (i = 0; i < s1; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());// storing user inputs
            }

            var output = num2string(arr1);
            foreach (var item in output)// one by one elements will be stored in variable 'item'
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
    }
}
