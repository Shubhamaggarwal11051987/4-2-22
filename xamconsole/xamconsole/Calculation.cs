using System;
using System.Collections.Generic;
using System.Text;

namespace xamconsole
{
    class Calculation
    {

        public static void Program7()
        {
            int[][] nums = new int[3][];
            int[] temp = new int[nums.Length];
            for(int i=0; i<3; i++)
            {
                Console.WriteLine("Enter column size for {0} row",i);
                int ss = int.Parse(Console.ReadLine());
                nums[i] = new int[ss];
                temp[i] = ss;
            }
           
            //enter values in all indexes
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<temp[i]; j++)
                {
                    Console.WriteLine("Enter value of {0} row and {1} column",i,j);
                    int n = int.Parse(Console.ReadLine());
                    nums[i][j] = n;
                }
            }

            //print all values

            //enter values in all indexes
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < temp[i]; j++)
                {
                    Console.Write("  "+nums[i][j]);
                }
                Console.WriteLine();
            }



            /*
            nums[0] = new int[4];
            nums[1] = new int[3];
            nums[2] = new int[2];

            nums[0][0] = 10;
            nums[0][1] = 20;
            nums[0][2] = 30;
            nums[0][3] = 40;

            nums[1][0] = 50;
            nums[1][1] = 60;
            nums[1][2] = 70;

            nums[2][0] = 90;
            nums[2][1] = 99;

            foreach(var i in nums)
            {
                foreach(int j in i)
                {
                    Console.Write("  "+j);
                }
                Console.WriteLine();
            }

            */
        }
        public static void Program6()
        {
            int[,] nums = new int[3, 4];
            nums[0, 0] = 10;
            nums[0, 1] = 40;
            nums[0, 2] = 50;
            nums[0, 3] = 60;
            nums[1, 0] = 20;
            nums[1, 1] = 90;
            nums[1, 2] = 70;
            nums[1, 3] = 10;
            nums[2, 0] = 45;
            nums[2, 1] = 67;
            nums[2, 2] = 76;
            nums[2, 3] = 56;
           

            for(int i=0; i<3; i++)
            {
                for(int j=0; j<4; j++)
                {
                    Console.Write(" "+nums[i,j]);
                }
                Console.WriteLine();
            }
        }

        public  static void Program5()
        {
            int[] nums = new int[10] {33,54,667,8,433,6,2,4,6,54 };

            foreach(int n in nums)
            {
                if (CheckIteminInArray(nums, n))
                {
                    Console.WriteLine("Duplicate: "+n);
                }
            }
        }
        public static bool CheckIteminInArray(int []arr,int num)
        {
            int count = 0;
            foreach(int i in arr)
            {
                if (i == num)
                    count++;
            }
            if (count > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Program4()
        {
            string[] username = new string[10] { "ajay","vijay","amit","ankit","manoj","manish","mohit","subham","sumit","suraj" };
            Console.WriteLine("Enter search by letter ?");
            string txt = Console.ReadLine();
            int count = 0;
            foreach(var str in username)
            {
                if (str.ToLower().StartsWith(txt.ToLower()))
                {
                    Console.WriteLine(str);
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No user found !");
            }

        }

        public static void Program3()
        {
            int[] nums = new int[5] { 11, 17, 45, 27, 13 };
            foreach(int i in nums)
            {
                if (CheckPrime(i))
                {
                    Console.WriteLine(reversNumber(i));
                }
            }

        }
        public static bool CheckPrime(int num)
        {
            bool flag = true;
            for(int i=2; i<num/2; i++)
            {
                if(num%i==0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        } 

        public static int  reversNumber(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                int rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;

            }
            return rev;
        }


        public static void CalculateDiscount()
        {
            Console.WriteLine("Enter Amount ? ");
            decimal amount = decimal.Parse(Console.ReadLine());
            decimal discount, rest;
            if (amount >= 10000)
            {
                discount = amount * 30 / 100;
                rest = amount - discount;
            }
            else if(amount>=5000 && amount < 10000)
            {
                discount = amount * 20 / 100;
                rest = amount - discount;
            }
            else
            {
                discount = amount * 4 / 100;
                rest = amount - discount;
            }
            Console.WriteLine("You  got discount : "+discount);
            Console.WriteLine("Your payable amount : "+rest);
        }
        public  void Product(int x, int y)
        {
            int r = x * y;
            Console.WriteLine("Result is "+r);
        }

        public void PrintName()
        {
            Customer obj = new Customer();
            obj.Test();
            Console.WriteLine("Enter any number ?");
           int n= Int32.Parse(Console.ReadLine());

            int i = 1;
            while (i <= n)
            {
                Console.WriteLine("Rakesh");
                i++;
            }
        }
    }
}
