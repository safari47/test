using System;
namespace TestConsole   
{
    class Programm
    {
        static void Main (string[] args)
        {
Random rnd=new Random();
 int [] num = new int[10];
 int length=num.Length-1;
for (int i=0;i<length+1;i++)
{num[i]=rnd.Next(0,100);
Console.WriteLine(num[i]);
}
Array.Sort(num);
for (int j=0;j<length+1;j++)
{
Console.WriteLine(num[j]);
}
Console.WriteLine ("Это самые большие числа из массива "+num[length]+ ' ' +num[length-1]);
        }
    }
}