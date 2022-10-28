namespace BasicCoreProgramss
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter an Alphabet from a to z : ");
            char n = Convert.ToChar(Console.ReadLine());

            switch (n)
            {
                case 'a':
                    Console.WriteLine(n+" is a Vowel");
                    break;
                case 'e':
                    Console.WriteLine(n+" is a Vowel");
                    break;
                case 'i':
                    Console.WriteLine(n+" is a Vowel");
                    break;
                case 'o':
                    Console.WriteLine(n+" is a Vowel");
                    break;
                case 'u':
                    Console.WriteLine(n+" is a Vowel");
                    break;
                default:
                    Console.WriteLine(n+" is a Consonant");
                    break;
            }
            Console.ReadLine();

        }
    }
}