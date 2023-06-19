namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Methods.Add(7,14); //pass in arguments
            Methods.Multiply(5, 12); //pass in arguments
            Methods.Subtract(10, 20);// pass in arguments
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();

            Console.WriteLine("What is your favortie music");
             string music = Console.ReadLine();

            Console.WriteLine("What is your favorite animal");
            string animal = Console.ReadLine();
           
            Console.WriteLine($"My name is {name}. My Favorite food is {food}. My favorite music is {music}. My favorite animal is {animal}.");


        }   
    }
}
