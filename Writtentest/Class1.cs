using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writtentest
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int count1=0,count2=0,count3 = 0;
            string name=Console.ReadLine();
            
            for(int i=0;i<name.Length;i++)
            {
                if (name[i]>='A'&& name[i]<='Z'|| name[i] >= 'a' && name[i] <= 'z')
                {
                    count1++;
                }
                else if (name[i]>='0'&& name[i]<='9')
                {
                    count2++;
                }
                else
                {
                    count3++;
                }
            }

            Console.WriteLine($" number of Alphabet are {count1}");
            Console.WriteLine($" number of Digit are {count2}");
            Console.WriteLine($" number of special character are {count3}");

        }
    }
}

namespace Writtentest
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            int count = 0;
            string str=Console.ReadLine();
            char ch=Convert.ToChar(Console.ReadLine());
            for(int i=0;i<str.Length;i++)
            {
                if (str[i] == ch)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}



namespace Writtentest
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int[]arr= new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                
            }
          

            int max = arr[0];
            for(int i=1;i<arr.Length;i++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);

        }
    }
}


namespace Writtentest
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            int temp,r, revrese = 0;
            int num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while(num > 0)
            {
                r = num % 10;
                revrese = revrese * 10 + r;
                num=num/ 10;
            }
           if(temp==revrese)
            {
                Console.WriteLine("given number is  palindrome ");
            }
            else
            {
                Console.WriteLine("given number is not  palindrome ");
            }
        }
    }
}
namespace Writtentest
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            int[]arr= new int[] {1,2,3,4,5,6,7,8};  
            for(int i=0;i<arr.Length;i=i+2)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}