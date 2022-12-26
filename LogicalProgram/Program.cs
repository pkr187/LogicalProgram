namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programming");
           
                Console.WriteLine("Select program\n 1.CouponNumbers");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                    CouponNumbers couponNumbers = new CouponNumbers();
                    couponNumbers.DistinctCouponNumber();
                        break;
                    default:
                        Console.WriteLine("Select correct option");
                        break;
                }
            
        }
    }
}