namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programming");
                Console.WriteLine("Select program\n 1.Dayoftheweek");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                    Dayoftheweek dayoftheweek = new Dayoftheweek();
                    dayoftheweek.Days();
                        break;
                    default:
                        Console.WriteLine("Select correct option");
                        break;
                }
            
        }
    }
}