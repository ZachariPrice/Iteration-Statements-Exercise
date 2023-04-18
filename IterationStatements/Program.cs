namespace IterationStatements
{
    public class Program 
    {
        static void Main(string[] args)
        {
            //PrintBy3();
            //Print1000();
            //AreTheyEqual(5 , 6);
            //EvenOrOdd(88);
            //PosOrNeg(-500);
            CanYouVote();
        }
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Print1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                    Console.WriteLine(i);
            }//write logic here that prints out numbers 1000 through -1000
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintBy3()
        {
            for(int k = 3; k <= 999; k+=3) 
            {
                Console.WriteLine(k);
            }//write logic here that prints numbers 3 through 999 by 3
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void AreTheyEqual(int num1 , int num2)
        {
            if(num1 == num2)
            {
                Console.WriteLine($"These two numbers are equal");
            }
            else
            {
                Console.WriteLine($"These two numbers are not equal");
            }
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int num1)
        {
            if(num1 % 2 == 0)
            {
                Console.WriteLine($"Even");
            }
            else
            {
                Console.WriteLine($"Odd");
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static void PosOrNeg(int num1)
        {
            if (num1 >= 0)
            {
                Console.WriteLine($"Positive");
            }
            else
            {
                Console.WriteLine($"Negative");
            }
        }
            //Write a method to read the age of a candidate and determine whether they can vote.
            //Hint: Use Parse or the safer TryParse() for an extra challenge
            //Parse()
            //TryParse()
        public static void CanYouVote()
        {
            Console.WriteLine($"How old are you");
            var answer = int.Parse(Console.ReadLine());
            
            if(answer < 18)
            {
                Console.WriteLine($"You can't vote");
            }
            else
            {
                Console.WriteLine($"You can vote");
            }

        }
        
            //Call the methods to test them in the Main method below
        
    }
}
