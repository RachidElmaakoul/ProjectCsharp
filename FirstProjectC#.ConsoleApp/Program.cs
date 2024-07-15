namespace FirstProjectC_.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager M = new Manager(1000, "Mehdi .el ", 180, 10);
            Maintanence Ms = new Maintanence(1001, "Lukas .el", 183, 11);

            Salse s = new Salse(1002, "Sally .M", 176,9, 10000m, 0.05m);

            Devloper d = new Devloper(1003, "rachid el maakoul", 180, 15, true);
             

            Employye[] employyes = { M, Ms, s, d };
            foreach (var employye in employyes)
            {
                Console.WriteLine("\n---------------------");
                Console.WriteLine(employye);
            }

            Console.ReadKey();
        }
    }
}
