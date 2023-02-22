using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();

        int userNumber;

        Console.Write("1-6 arası bir sayı girin: ");

        while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber < 1 || userNumber > 6)
        {
            Console.Write("Geçersiz giriş. Lütfen 1-6 arası bir sayı girin: ");
        }

        int zar1, zar2;
        int sayac = 0;

        while (true)
        {
            zar1 = rnd.Next(1, 7);
            zar2 = rnd.Next(1, 7);
            sayac++;

            Console.WriteLine("{0}. deneme: {1} ve {2}", sayac, zar1, zar2);

            if ( zar2 ==  userNumber&&zar1==userNumber)
            {
                Console.WriteLine("{0} ve {1} atıldı, tebrikler! {2} denemede bildiniz.", zar1, zar2, sayac);
                break;
            }
        }
    }
}
