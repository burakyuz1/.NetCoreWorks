using System;
using System.Threading.Tasks;

namespace AsenkronProgramlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayilariYazdir();
            HarfleriYazdir();

            Console.WriteLine("MERHABA DUNYA");
            Console.ReadLine();
        }


        static async Task SayilariYazdir()
        {
            for (int i = 0; i < 26; i++)
            {
                Console.Write(i + " ");
                await Task.Delay(400);
            }
        }
        static async Task HarfleriYazdir()
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Console.Write(c + " ");
                await Task.Delay(400);

            }

        }
    }
}
