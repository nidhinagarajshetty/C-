
using Reversenum;

class Program
{
    static void Reversenum()
    {
        ReverseNum obj = new ReverseNum(); 
        obj.ReadData();
        obj.Reverse();
        obj.Display();
    }

    static void Main(string[] args)
    {
        Reversenum();  
    }
}