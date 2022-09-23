namespace TaskSkilvul
{
    class Calculator
    {
        static void Main(string[] args)
        {

            Console.WriteLine("============================");
            Console.WriteLine("\t CALCULATOR");
            Console.WriteLine("============================");
            Console.WriteLine("Press 1 for Addition         (+)");
            Console.WriteLine("Press 2 for Subtraction      (-)");
            Console.WriteLine("Press 3 for Multiplication   (X)");
            Console.WriteLine("Press 4 for Division         (/)");
            Console.WriteLine();

            do
            {
                Console.WriteLine("============================");
                Console.Write("Enter your choice :");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter 1st Number :");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter 2nd Number :");
                int y = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                switch (choice)
                {
                    case 1:
                        {
                            result = Addition(x, y);
                            break;
                        }
                    case 2:
                        {
                            result = Subtraction(x, y);
                            break;
                        }
                    case 3:
                        {
                            result = Multiplication(x, y);
                            break;
                        }
                    case 4:
                        {
                            result = Division(x, y);
                            break;
                        }
                    default:
                        Console.WriteLine("Wrong action!! try again");
                        break;
                }
                Console.WriteLine("The result is {0}", result);
                Console.WriteLine("============================");
                Console.Write("Do you want to continue? (Y/N) :");
            } while (Console.ReadLine().ToUpper() == "Y");

        }
        //Addition  
        public static int Addition(int x, int y)
        {
            int result = x + y;
            return result;
        }
        //Substraction  
        public static int Subtraction(int x, int y)
        {
            int result = x - y;
            return result;
        }
        //Multiplication  
        public static int Multiplication(int x, int y)
        {
            int result = x * y;
            return result;
        }
        //Division  
        public static int Division(int x, int y)
        {
            int result = x / y;
            return result;
        }
    }
}