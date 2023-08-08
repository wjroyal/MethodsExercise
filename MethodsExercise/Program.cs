namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string userColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string userAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string userBand = Console.ReadLine();

            Console.WriteLine($"The users name is {userName}. {userName}'s favorite color is {userColor}. {userName}'s favorite animal is {userAnimal}. It should come as no surprise that {userName}'s favorite band is {userBand}.");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number to add");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a new number");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a second number");
            int i = int.Parse(Console.ReadLine());

            int diff = Subtract(h, i);
            Console.WriteLine($"The difference of the first and second number is {diff}.");

            Console.WriteLine("Give me another number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a second number");
            int y = int.Parse(Console.ReadLine());

            int prod = Multiply(x, y);
            Console.WriteLine($"The product of the two numbers is {prod}");

            Console.WriteLine("Give me a new number");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another new number");
            int g = int.Parse(Console.ReadLine());

            int quot = Divide(f, g);
            int mod = Modulus(f, g);
            Console.WriteLine($"The quotient of the two provided numbers is {quot} with a remainder of {mod}.");

        }
        public static int Sum(int num1, int num2)
        {


            return num1 + num2;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int f, int g)
        {
            return f / g;
        }

        public static int Subtract(int h, int i)
        {
            return h - i;
        }

        public static int Modulus(int f, int g)
        {
            return f % g;
        }
    }
    }

