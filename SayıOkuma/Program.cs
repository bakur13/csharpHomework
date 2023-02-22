using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
        string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
        string[] binler = { "", "bin", "milyon", "milyar" };

        Console.Write("0-99999999 arası bir sayı girin: ");
        int sayi;
        while (!int.TryParse(Console.ReadLine(), out sayi) || sayi < 0 || sayi > 99999999)
        {
            Console.Write("Geçersiz giriş. Lütfen 0-99999999 arası bir sayı girin: ");
        }

        if (sayi == 0)
        {
            Console.WriteLine("sıfır");
            return;
        }

        string okunus = "";
        int basamak = 0;
        while (sayi > 0)
        {
            int grup = sayi % 1000;
            if (grup > 0)
            {
                string yuzler = birler[grup / 100] + " yüz ";
                string onlarBinlik = onlar[(grup / 10) % 10];
                string birlerBinlik = birler[grup % 10];
                string binlerStr = binler[basamak];

                if (grup < 100) yuzler = "";
                if (grup % 100 < 10) onlarBinlik = "";
                if (grup % 10 == 0 || grup < 10) birlerBinlik = "";

                okunus = yuzler + onlarBinlik + birlerBinlik + binlerStr + " " + okunus;
            }
            sayi /= 1000;
            basamak++;
        }

        Console.WriteLine(okunus.Trim());
    }
}


/*
9-10: string dizileri birler, onlar ve binler tanımlanıyor. Bu diziler, sayının okunuşunu oluşturmak için kullanılacak olan sayı sözcüklerinin listesini içeriyor. Her biri, sayının farklı bir basamağındaki rakamın okunuşunu temsil eden sözcüklerden oluşuyor.

12-15: Kullanıcıdan bir sayı girmesi isteniyor ve girilen değerin geçerli bir giriş olup olmadığı kontrol ediliyor. int.TryParse metodu, kullanıcının girdiği metnin bir tamsayıya dönüştürülebilir olup olmadığını kontrol eder. Eğer dönüşüm yapılabilirse, out parametresi aracılığıyla dönüştürülmüş sayı değeri sayi değişkenine atanır. Girilen değer geçerli bir giriş değilse, kullanıcıdan tekrar giriş yapması istenir.

17-20: Eğer girilen sayı 0 ise, ekrana sadece "sıfır" yazdırılır ve program sonlanır.

22-31: okunus değişkeni, sayının okunuşunu oluşturmak için kullanılacak olan metni temsil eder. basamak değişkeni, sayının hangi basamağındaki rakamların okunuşunu oluşturmak için kullanılacağını belirler.

32-39: while döngüsü, sayının her bir basamağındaki rakamların okunuşunu oluşturur. Her bir rakamın okunuşu, ilgili grup değişkeninde depolanır. Daha sonra, yuzler, onlarBinlik, birlerBinlik ve binlerStr değişkenleri, grup değişkenindeki rakamların okunuşlarını temsil eden sözcüklerden oluşur. Bu sözcükler, daha sonra okunus değişkeninde kullanılmak üzere birleştirilir.

40-42: sayi değişkeninin değeri, bir sonraki basamağa geçmek için 1000'e bölünür. basamak değişkeni de artırılır.

44-46: Oluşturulan okunuş metni, Trim metodu kullanılarak gereksiz boşluklardan temizlenir ve ekrana yazdırılır.
 */
