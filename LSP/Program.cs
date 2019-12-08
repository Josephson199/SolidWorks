using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

            SumCalculator sum = new SumCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");

            Console.WriteLine();

            EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");


            //Creating a Better Solution
            //As we can see, this is working just fine.But what is wrong with this solution then?

            //Why are we trying to fix it?

            //Well, as we all know, if a child class inherits from a parent class, then the child class is a parent class. Having that in mind, 
            //we should be able to store a reference to an EvenNumbersSumCalculator as a SumCalculator variable and nothing should change.
            //So, let’s check that out:

            SumCalculator evenSum2 = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum2.Calculate()}");
            Console.ReadKey();

            //As we can see, we are not getting the expected result because our variable evenSum is of type SumCalculator which is a higher order class (a base class). 
            //This means that the Count method from the SumCalculator will be executed.
            //So, this is not right, obviously, because our child class is not behaving as a substitute for the parent class.
        }
    }
}
