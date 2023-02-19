namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hi there! What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("So, what is your favorite color?");
            string userColor = Console.ReadLine();
            Console.WriteLine("Now, what is your favorite animal?");
            string userAnimal = Console.ReadLine();
            Console.WriteLine("One more thing. What is your favorite band?");
            string userBand = Console.ReadLine();

            Console.WriteLine($"Wonderful! I have a little story to tell you, {userName}. Once upon a time, {userName} was walking through a {userColor} forest. Unfortunately, {userName} was not being very careful, so {userName} accidentally tripped over a giant {userAnimal} who was not in a very good mood, and also the {userAnimal} was hungry. So, sadly, the {userAnimal} ate {userName} immediately. The end. Oh no...you didn't like my story? Well, sorry about that. Why don't you go ahead and listen to {userBand}, because that will surely cheer you up! :)");








        }
    }
}
