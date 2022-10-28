namespace BasicCoreProgramss
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a Number whose Powers are to be calculated : ");
            long N = Convert.ToInt32(Console.ReadLine());
            int num = 1;
            Console.WriteLine("The powers of " + N + " are");
            for (int i = 2; i < N; i++)
            {
                 num = num * 2;
                if ( num < N)
                {
                    Console.WriteLine(num);
                }
                
            }
            Console.ReadLine();

        }
    }
}