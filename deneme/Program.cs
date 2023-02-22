using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);
        int tahmin = -1;
        int sayac= 0;

        Console.WriteLine("0-100 arasında bir sayı tahmin edin.");

        while (tahmin!= randomNumber)
        {
            Console.Write("Tahmininiz: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out tahmin))
            {
                Console.WriteLine("Lütfen geçerli bir sayı girin.");
                continue;
            }
            sayac++;

            if (tahmin < randomNumber)
            {
                Console.WriteLine("Daha yüksek bir sayı girin.");
            }
            else if (tahmin > randomNumber)
            {
                Console.WriteLine("Daha düşük bir sayı girin.");
            }
            else
            {
                Console.WriteLine("Tebrikler, doğru tahmin! {0} tahminde bildiniz.", sayac
                    );
            }
        }
    }
}
