using System.Collections.Specialized;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            int x =int.Parse(Console.ReadLine());
            if (x % 3 == 0 && x % 4 == 0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            #endregion
            #region 2
            int y = int.Parse(Console.ReadLine());
            if (y>0)
                Console.WriteLine("positive");
            else
                Console.WriteLine("negative");
            #endregion
            #region 3
            
            
            int[] num = new int[3];
            for (int i = 0; i < num.Length; i++)
            {
                num[i]= int.Parse(Console.ReadLine());


            }
            Console.WriteLine(num.Max());
            Console.WriteLine(num.Min());

            #endregion
            #region 4
            int a = int.Parse(Console.ReadLine());
            if (x % 2 == 0 )
                Console.WriteLine("even");
            else
                Console.WriteLine("odd");
            #endregion
            #region 5
            string c = Console.ReadLine();
            if (c=="a"||c=="o"||c=="u"||c=="i"||c=="e")
                Console.WriteLine("vowel");
            else
                Console.WriteLine("consonant");
            #endregion
            #region 6
            int a1=int.Parse(Console.ReadLine());
            for (int i = 1; i <= a1; i++)
                Console.WriteLine(i);

            #endregion
            #region 7
            int a2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
                Console.WriteLine(i*a2);
            #endregion
            #region 8
            int a3 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a3; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            #endregion
            #region 9
            int a4 = int.Parse(Console.ReadLine());
            int a5 = int.Parse(Console.ReadLine());
            double a6 = Math.Pow(a4, a5);
            Console.WriteLine(a6);
            #endregion
            #region 10
            int[] num1 = new int[5];
            int sum = 0;
            double xx = (sum / 500d) * 100d;
            for (int i = 0; i < num1.Length; i++)
            {
                num1[i] = int.Parse(Console.ReadLine());
                sum += num1[i];
            }
            Console.WriteLine("Total marks "+sum);
            Console.WriteLine("Average Marks "+sum / 5);
            Console.WriteLine("Percentage "+xx);

            #endregion
            #region 11
            int s1=int.Parse(Console.ReadLine());
            if (s1 == 1)
                Console.WriteLine(31);
            else if(s1==2)
                Console.WriteLine(28);
            else if (s1 == 3)
               Console.WriteLine(31);
            else if (s1 == 4)
                Console.WriteLine(30);
            else if (s1 == 5)
                Console.WriteLine(31);
            else if (s1 == 6)
                Console.WriteLine(30);
            else if (s1 == 7)
                Console.WriteLine(31);
            else if (s1 == 8)
                Console.WriteLine(31);
            else if (s1 == 9)
                Console.WriteLine(30);
            else if (s1 == 10)
                Console.WriteLine(31);
            else if (s1 == 11)
                Console.WriteLine(30);
            else 
                Console.WriteLine(31);




            #endregion
            #region 12
            int s2=int.Parse(Console.ReadLine());
            
            for (int i = 0; i < s2; i++)
            {
                for (int j = 0; j < s2; j++)
                {
                    if (i == j)
                        Console.Write("1");
                    else
                        Console.Write("0");

                }
                   
                
            }

            #endregion
            #region 13
            int sum1 = 0;
            int s3=int.Parse(Console.ReadLine());
            int[] num2 = new int[s3];
            for (int i = 0; i < num2.Length; i++)
            {
                num2[i] = int.Parse(Console.ReadLine());
                sum1 += num1[i];
            }
            Console.WriteLine(sum1);
            #endregion
            #region 14
            int f = int.Parse(Console.ReadLine());
            int[] numf = new int[f];
            int[] numf2 = new int[int.MaxValue];
            for (int i = 0; i < numf.Length; i++)
            {
                numf[i] = int.Parse(Console.ReadLine());
                numf2[numf[i]]++;

            }
            for (int i = 0; i < int.MaxValue; i++)
            {
                if (numf2[i] != 0)
                    Console.WriteLine(i + " : " + numf2[i]);


            }

            #endregion
            #region 15
            int s4 = int.Parse(Console.ReadLine());
            int[] num3 = new int[s4];
            for (int i = 0; i < num3.Length; i++)
            {
                num3[i] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine(num3.Max());
            Console.WriteLine(num3.Min());
            #endregion
            #region 16
            int s5 = int.Parse(Console.ReadLine());
            int[] num4 = new int[s5];
            for (int i = 0; i < num4.Length; i++)
            {
                num4[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(num4);
            Console.WriteLine(num4[s5-2]);

            #endregion


        }
    }
}
