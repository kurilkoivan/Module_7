using System.Runtime.CompilerServices;

class Helper
{
    int num1 = 3;
    int num2 = 58;
    static void Swap(ref int num1,ref int num2) 
    {
        int num3 = num1;
        num2 = num1;
        num2 = num3;
        Console.WriteLine(num1); //58
        Console.WriteLine(num2); //3
    } 

}



