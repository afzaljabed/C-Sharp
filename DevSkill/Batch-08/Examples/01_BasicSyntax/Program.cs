namespace _01_BasicSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int x = 5;
            int y = 10;
            // variable can have alphabet, digit or underscore and it must start with either alphabet or underscore
            int studentAge = 23;
            string studentName = "Jalaluddin";
            bool isAdmitted = true;
            double weight = 83.5;
            char initial = 'A';

            string line = Console.ReadLine();

            string[] lineParts = line.Split(' ');

            for(int i = 0; i < lineParts.Length; i++)
            {
                Console.WriteLine(lineParts[i]);
            }
        }
    }
}
