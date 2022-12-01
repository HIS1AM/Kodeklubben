namespace HelloWorld
{
    class Kodeklubben
    {
        static void oppgave1()
        {
            Console.WriteLine("Hello, World!");
        }
        static void oppgave2()
        {
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
        static void oppgave3(string Abdi, string abo)
        {
            Console.WriteLine(Abdi);
            Console.WriteLine(abo);
        }
        static int oppgave4(int tall1, int tall2)
        {
            return tall1 + tall2;
            
        }

        static void Main(string[] args)
        {

            Console.WriteLine(oppgave4(6,1));
        }
    }
}
