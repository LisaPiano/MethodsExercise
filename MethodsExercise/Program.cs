using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {

        //-----------EXERCISE 2----Writing Methods for Math Operators_______
        public static int Add(params int[] ListNumbers)
        {
            int total = 0;
            foreach (int number in ListNumbers)
            {
                total += number;
            }
            return total;
        }

        public static int Subtract(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1 - num2;
            }
            else
            {
                return num2 - num2;
            }
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }



        static void Main(string[] args)
        {

            int addAnswer = Add(3, 5, 10, 20, 3);
            Console.WriteLine(addAnswer);

            int subtractAnswer = Subtract(3, 5);
            Console.WriteLine(subtractAnswer);

            int multiplyAnswer = Multiply(3, 5);
            Console.WriteLine(multiplyAnswer);

            int divideAnswer = Divide(3, 5);
            Console.WriteLine(divideAnswer);

            Console.WriteLine("Ok...so now, why don't you give me a number for the next operation? Enter here:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Thanks...so now, please give me a second number. Enter here:");
            int num2 = int.Parse(Console.ReadLine());

            int modulusAnswer = Modulus(num1, num2);
            Console.WriteLine($"And, the final answer is....{modulusAnswer}!");






            //-----------EXERCISE 1_______
            //----Designing a madlibs type exercise to practicing inputing and outputing variables


            Console.WriteLine("Now, please give me some information, and I will tell you a story!");
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("So, what is your favorite color?");
            string userColor = Console.ReadLine();
            Console.WriteLine("Now, what is your favorite animal?");
            string userAnimal = Console.ReadLine();
            Console.WriteLine("One more thing. What is your favorite band?");
            string userBand = Console.ReadLine();

            Console.WriteLine($"Wonderful! I have a little story to tell you, {userName}. Once upon a time, {userName} was walking through a {userColor} forest. Unfortunately, {userName} was not being very careful, so {userName} accidentally tripped over a giant {userAnimal} who was not in a very good mood, and also the {userAnimal} was hungry. So, sadly, the {userAnimal} ate {userName} immediately. The end. Oh no...you didn't like my story? Well, sorry about that. Why don't you go ahead and listen to {userBand}, because that will surely cheer you up! :)");










        }//end main
    } //end program
}//end namespace
