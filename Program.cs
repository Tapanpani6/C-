using System;

namespace Csharp;

class Program
{
    public static void Main(string[] args)

    {
        Program x = new Program();
        x.Fibonacci();
        //x.RemoveDuplicate();
        //x.Ternary();
        //x.PrimeNumber();
        //x.StringReverse();
        //x.ReverseNumber();
        //x.palindrome();
        //x.swap_number();
        //x.swap_number_without_3rd_variable();
    }
    public void RemoveDuplicate()
    {
        string str = "Tapan";
        string result = string.Empty;
        for(int i=0;i<str.Length;i++)
        {
            if (!result.Contains(str[i]))
            {
                result = result + str[i];
            }

        }
        Console.WriteLine(result);
        Console.ReadLine();
    }
    public void Ternary()
    {
        int a = 10;
        int b = 20;
        int largest = (a > b) ? a : b;
        Console.WriteLine("Largest Number is: "+largest);
    }
    public void Fibonacci()
    {
        int a = 0;
        int b = 1;
        int c;

        for (int i = 0; i <= 9; i++)
        {
            c = a + b;
            a = b;
            b = c;
            Console.WriteLine(c);

        }
    }
    public void PrimeNumber()
    {
        Console.WriteLine("Enter a number: ");
        int number;
        number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for(int i=1;i<=number;i++)
        {
            if(number%i==0)
            {
                count++;
            }
        }
        if(count==2)
        {
            Console.WriteLine(number+" is a prime number.");
        }
        else
        {
            Console.WriteLine(number+" is not a prime number.");
        }
        Console.ReadLine();
    }
    public void StringReverse()
    {

        Console.WriteLine("Enter a string to reverse: ");
        string s = Console.ReadLine();
        string reverse = string.Empty;
        for(int i=s.Length-1;i>=0;i--)
        {
            reverse += s[i];
        }

        Console.WriteLine($"Reverse String is :"+reverse);
        Console.ReadLine();
        
    }
    public void ReverseNumber()
    { 
        int num=341, rem, res=0;
        while (num>0)
        {
            rem = num % 10;
            res = res * 10 + rem;
            num = num / 10;
        }
        Console.WriteLine("reverse of a number is " + res);
    }
    public void palindrome()
    {
        int num = 121;
        int rem;
        int res=0;
        int temp = num;
        while(num!=0)
        {
            rem = num % 10;
            res = res * 10 + rem;
            num = num / 10;
        }
        num = temp;
        if(num==res)
        {
            Console.WriteLine("Palindrome number");
        }
        else
        {
            Console.WriteLine("Not a palindrome number");
        }
    }
    public void swap_number()
    {
        int a = 20;
        int b = 30;
        int temp;

        Console.WriteLine("Before Swappingvalue of a: "+a+ " Value of b: "+b);
        temp = a;//20
        a = b;//30
        b = temp;//
        Console.WriteLine("After Swappingvalue of a: " + a + " Value of b: " + b);
        Console.ReadLine();
    }
    public void swap_number_without_3rd_variable()
    {
        int a = 121;
        int b = 45;

        Console.WriteLine("Before Swappingvalue of a: " + a + " Value of b: " + b);
        a = a + b;//50
        b = a - b; //20
        a = a - b; //30
        Console.WriteLine("After Swappingvalue of a: " + a + " Value of b: " + b);
        Console.ReadLine();
    }
}
