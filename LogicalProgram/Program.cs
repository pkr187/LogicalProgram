namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programming");
                Console.WriteLine("Select program\n 1. DayOfWeek");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                    DayOfWeek dayOfWeek = new DayOfWeek();
                    dayOfWeek.Days();
                        break;
                    default:
                        Console.WriteLine("Select correct option");
                        break;
                }
            
        }
    }
}