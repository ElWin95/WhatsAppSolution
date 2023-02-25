namespace WhatsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Massivin uzunlugunu daxil edin:");
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];

            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"Number[{i}]=");
                number[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    Console.WriteLine(number[i]);
                }
            }
        }
    }
}