namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 9 };
            int max = array[0];
            for (int i = 1; i < array.Length; i++) { 
            if (max < array[i]) max = array[i]; 
            }
            Console.WriteLine(max);
            Console.ReadKey();

        }
    }
}
