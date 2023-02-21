using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int userNumber;

        Console.Write("1-6 arası bir sayı girin: ");
        while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber < 1 || userNumber > 6)
        {
            Console.Write("Geçersiz giriş. Lütfen 1-6 arası bir sayı girin: ");
        }

        int dice1, dice2;
        int tries = 0;

        while (true)
        {
            dice1 = random.Next(1, 7);
            dice2 = random.Next(1, 7);
            tries++;

            Console.WriteLine("{0}. deneme: {1} ve {2}", tries, dice1, dice2);

            if (dice1 + dice2 == 2 * userNumber)
            {
                Console.WriteLine("{0} ve {1} atıldı, tebrikler! {2} denemede bildiniz.", dice1, dice2, tries);
                break;
            }
        }
    }
}
