namespace Sum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            static void sum()
            {
                Sum obj = new Sum();      
                obj.ReadNumber();         
                obj.CalculateSum();       
                obj.Display();            
            }

                sum(); 
            }
        }
    }
    

