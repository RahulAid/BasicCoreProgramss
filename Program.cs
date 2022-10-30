namespace BasicCoreProgramss
{
    internal class Program
    {

        static void Main(String[] args)
        {
            float count;
            float sum = 0;

            Console.WriteLine("Enter Nth Value : ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (count = 1; count <= N; count++)
            {
                 sum += 1 / count;
            }
            Console.WriteLine("Sum of Harmonic numbers series is : {0}",sum);
            Console.ReadLine();
        }
    }
}
