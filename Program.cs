namespace PNZ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            pnz n = new pnz(num);
            n.check();
        }
    }
}
