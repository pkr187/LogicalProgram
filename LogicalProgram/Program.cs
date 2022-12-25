namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programming");
            while (true)
            {
                Console.WriteLine("Select program\n 1.PerfectNumber");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.Number();
                        break;
                        break;
                    default:
                        Console.WriteLine("Select correct option");
                        break;
                }
            }
        }
    }
}