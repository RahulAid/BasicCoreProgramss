namespace BasicCoreProgramss
{
    internal class Program
    {
        
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a value: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            int i;
            
            for (i = 2; i <= Num; i++)
            {
                if (Num % i == 0)
                {
                    Console.WriteLine(i+" is a Factor of " + Num);

                }
                else
                {
                    Console.WriteLine(i + " is not a Factor of " + Num);
                }
            }
            Console.ReadLine();

        }
    }
}
