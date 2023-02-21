using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);
        int guess = -1;
        int guessCount = 0;

        Console.WriteLine("0-100 arasında bir sayı tahmin edin.");

        while (guess != randomNumber)
        {
            Console.Write("Tahmininiz: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Lütfen geçerli bir sayı girin.");
                continue;
            }
            guessCount++;

            if (guess < randomNumber)
            {
                Console.WriteLine("Daha yüksek bir sayı girin.");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Daha düşük bir sayı girin.");
            }
            else
            {
                Console.WriteLine("Tebrikler, doğru tahmin! {0} tahminde bildiniz.", guessCount);
            }
        }
    }
}
